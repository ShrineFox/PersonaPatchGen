using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using ShrineFox.IO;
using ShrineFoxCom;

namespace PersonaPatchGen
{
    public partial class WizardForm : DarkForm
    {
        // Setup Form

        public static List<Platform> platforms = new List<Platform>()
        {
            new Platform() { Name = "PlayStation 2",
                             ShortName = "PS2",
                             Games = Games.PS2Games,
                             EmulatorName = "PCSX2"
            },
            new Platform() { Name = "PlayStation 3",
                             ShortName = "PS3",
                             Games = Games.PS3Games,
                             EmulatorName = "RPCS3"
            },
            new Platform() { Name = "PlayStation 4",
                             ShortName = "PS4",
                             Games = Games.PS4Games
            },
            new Platform() { Name = "PlayStation Vita",
                             ShortName = "PSV",
                             Games = Games.PSVGames,
                             EmulatorName = "Vita3K"
            },
            new Platform() { Name = "PlayStation Portable",
                             ShortName = "PSP",
                             Games = Games.PSPGames,
                             EmulatorName = "PPSSPP"
            },
            new Platform() { Name = "Nintendo 3DS",
                             ShortName = "3DS",
                             Games = Games.PQGames,
                             EmulatorName = "Citra"
            }
        };

        public static List<string> downloads = new List<string>()
        {
            "./pnach/P3FES_hostFS.txt",
            "./pnach/P4_hostFS.txt",
            "./yml/patch.yml",
            "./yml/p5_ex/patches/patch.yml",
            "./yml/p5_ex/USRDIR/config.yml",
            "./yml/p5_ex/USRDIR/mod.sprx",
            "./yml/p5_ex/hardware/p5ex/conf.yml",
            "./yml/p5_ex/hardware/p5ex/mod.sprx"
        };

        Platform selectedPlatform = new Platform();
        Game selectedGame = new Game();
        string selectedRegion = "";
        string PPUHash = "";
        bool patchesInitialized = false;
        bool selectAll = true;
        string pythonPath = "";

        public WizardForm()
        {
            InitializeComponent();
            SetInitialAppearance();
        }

        private void SetInitialAppearance()
        {
            tabControl_Main.HideTabs = true;
            CreatePages();

#if DEBUG
            Output.VerboseLogging = true;
            comboBox_Platform.SelectedIndex = comboBox_Platform.Items.IndexOf("PlayStation 4");
            comboBox_Region.SelectedIndex = comboBox_Region.Items.IndexOf("EUR");
            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf("Persona 4 Dancing");
            txt_PKGPath.Text = @"C:\Users\Ryan\Documents\GitHub\EP2475-CUSA12811_00-PERSONA4DEU00000-A0100-V0100.pkg";
            btn_Next.Enabled = true;
#endif
        }

        private void CreatePages()
        {
            rtb_1_Welcome.LoadFile(@"./Forms/Documents/Welcome.rtf");
            ShowLastUpdated();
            rtb_3_Platform.LoadFile(@"./Forms/Documents/Platform.rtf");
            rtb_4_Patches.LoadFile(@"./Forms/Documents/Patches.rtf");
            rtb_5_Apply.LoadFile(@"./Forms/Documents/Apply.rtf");
        }

        private void ShowLastUpdated()
        {
            rtb_2_Updates.LoadFile(@"./Forms/Documents/Updates.rtf");
            rtb_2_Updates.AppendText($"\r\nLast Updated: {File.GetLastWriteTime("./yml/patch.yml")}");
        }

        // Page 1: Game Select

        private void Platform_Changed(object sender, EventArgs e)
        {
            UpdateSelectedPlatform();
        }

        private void UpdateSelectedPlatform()
        {
            selectedPlatform = new Platform();

            if (platforms.Any(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString())))
            {
                selectedPlatform = platforms.Single(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString()));
                comboBox_Region.Visible = true; lbl_Region.Visible = true;
                SetupTargetPlatformPage();
            }
            else
            {
                comboBox_Region.Visible = false; lbl_Region.Visible = false;
            }
            comboBox_Game.Visible = false; lbl_Game.Visible = false;
            btn_Next.Enabled = false;
        }

        private void Region_Changed(object sender, EventArgs e)
        {
            UpdateSelectedRegion();
        }

        private void UpdateSelectedRegion()
        {
            comboBox_Game.Items.Clear();

            selectedRegion = comboBox_Region.SelectedItem.ToString();
            var regionGames = selectedPlatform.Games.Where(x => x.Region.Equals(selectedRegion));

            if (regionGames.Count() > 0)
            {
                comboBox_Game.Items.Add("");

                foreach (var game in regionGames)
                    comboBox_Game.Items.Add(game.Name);
                comboBox_Game.Visible = true; lbl_Game.Visible = true;
                comboBox_Game.SelectedIndex = 0;
            }
            else
                comboBox_Game.Visible = false; lbl_Game.Visible = false;
            btn_Next.Enabled = false;
        }

        private void Game_Changed(object sender, EventArgs e)
        {
            UpdateSelectedGame();
        }

        private void UpdateSelectedGame()
        {
            if (selectedPlatform.Games.Any(x => x.Name.Equals(comboBox_Game.SelectedItem.ToString())))
            {
                selectedGame = selectedPlatform.Games.Single(x =>
                    x.Name.Equals(comboBox_Game.SelectedItem.ToString())
                    && x.Region.Equals(selectedRegion));
                ResetPatches();
                btn_Next.Enabled = true;
            }
            else
                btn_Next.Enabled = false;
        }

        // Page 2: Download Updates

        private void DownloadPatches()
        {
            btn_Next.Enabled = false;
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                DownloadLog($"\r\ndownload started {DateTime.Now}\r\n-------------------");
                for (int i = 0; i < downloads.Count; i++)
                {
                    string url = downloads[i];

                    using (var client = new WebClient())
                    {
                        try
                        {
                            client.DownloadFile(url.Replace("./", "https://shrinefox.com/"), url);
                            DownloadLog($"\r\nUpdated: {url}");
                        }
                        catch
                        {
                            DownloadLog($"\r\nFailed to download: {url}");
                            btn_Action.Text = "Try Again";
                            btn_Action.Enabled = true;
                        }
                        var fraction = Decimal.Divide(i + 1, downloads.Count());
                        int progress = Convert.ToInt32(fraction * 100);
                        SetProgress(progress);
                    }
                }
                DownloadLog($"\r\nDone!");
                SetProgress(100);
                SystemSounds.Exclamation.Play();
            }).Start();

            ShowLastUpdated();
            btn_Next.Enabled = true;
        }

        private void DownloadLog(string msg)
        {
            rtb_Updates_Log.SyncUI(() => { rtb_Updates_Log.AppendText(msg); }, true);
        }

        private void PatchLog(string msg)
        {
            rtb_Patches_Log.SyncUI(() => { rtb_Patches_Log.AppendText(msg); }, true);
        }

        private void SetProgress(int percent)
        {
            progressBar_Apply.SyncUI(() => { progressBar_Apply.Value = percent; progressBar_Apply.Update(); }, true);
            progressBar_Updates.SyncUI(() => { progressBar_Updates.Value = percent; progressBar_Updates.Update(); }, true);
        }

        // Page 3: Target Platform

        private void SetupTargetPlatformPage()
        {
            if (selectedPlatform.EmulatorName == "")
            {
                radio_Console.Checked = true;
                radio_Emu.Checked = false;
                radio_Emu.Enabled = false;

                lbl_ExePath.Visible = false;
                tlp_3_Platform_ExePath.Visible = false;
            }
            else
            {
                radio_Console.Checked = false;
                radio_Emu.Checked = true;
                radio_Emu.Text = selectedPlatform.EmulatorName;
                radio_Emu.Enabled = true;

                lbl_ExePath.Visible = true;
                lbl_ExePath.Text = $"{selectedPlatform.EmulatorName} .exe Path:";
                tlp_3_Platform_ExePath.Visible = true;
            }
        }

        private void ExePath_Browse(object sender, EventArgs e)
        {
            string path = ShrineFox.IO.WinFormsEvents.FilePath_Click($"Select your emulator's {selectedPlatform.EmulatorName}.exe");
            txt_ExePath.Text = path;

            AdvanceIfEmuValid();
        }

        private void AdvanceIfEmuValid()
        {
            if (!radio_Console.Checked && File.Exists(txt_ExePath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        private void PKGPath_Browse(object sender, EventArgs e)
        {
            string path = ShrineFox.IO.WinFormsEvents.FilePath_Click($"Select game file");
            txt_PKGPath.Text = path;

            AdvanceIfPKGValid();
        }

        private void AdvanceIfPKGValid()
        {
            if (radio_Console.Checked && File.Exists(txt_PKGPath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        private void Path_TextChanged(object sender, EventArgs e)
        {
            AdvanceIfPKGValid();
            AdvanceIfEmuValid();
        }

        private void Checked_Changed(object sender, EventArgs e)
        {
            ResetPatches();
        }

        private void SetInputFileLabels()
        {
            if (selectedPlatform.ShortName != "3DS")
            {
                lbl_PKGPath.Visible = true;
                tlp_3_Platform_PKGPath.Visible = true;
            }
            
            switch (selectedPlatform.ShortName)
            {
                case "PS2":
                    lbl_PKGPath.Text = ".ISO Path:";
                    break;
                case "PS3":
                case "PSV":
                case "PSP":
                    chk_Permutations.Visible = true;
                    lbl_PKGPath.Text = "EBOOT .BIN Path:";
                    break;
                case "PS4":
                    chk_Permutations.Visible = true;
                    lbl_PKGPath.Text = "Base Game FPKG Path:";
                    break;
                default:
                    chk_Permutations.Visible = false;
                    chk_Permutations.Checked = false;
                    lbl_PKGPath.Text = "Input File Path:";
                    break;
            }

            if (!File.Exists(txt_PKGPath.Text) && (selectedPlatform.ShortName != "3DS"))
                btn_Next.Enabled = false;
            else
                btn_Next.Enabled = true;
        }

        // Changing Selected Tab

        private void MainTab_Changed(object sender, EventArgs e)
        {
            SetupPageButtons();
        }

        private void SetupPageButtons()
        {
            // Only show Previous Page button when current page > 0
            if (tabControl_Main.SelectedIndex >= 1)
                btn_Back.Visible = true;
            else
                btn_Back.Visible = false;
            // Disable Next Button unless conditions to advance are met
            btn_Next.Visible = true;
            btn_Next.Enabled = true;
            if (tabControl_Main.SelectedTab.Text == "Platform")
            {
                if (selectedPlatform.EmulatorName != "" && !radio_Console.Checked)
                {
                    if (!File.Exists(txt_ExePath.Text))
                        btn_Next.Enabled = false;
                }
                else if (radio_Console.Checked)
                {
                    if ((selectedPlatform.ShortName == "PS4" || selectedPlatform.ShortName == "PSV" || selectedPlatform.ShortName == "PS2" || selectedPlatform.ShortName == "PSP")
                        && !File.Exists(txt_PKGPath.Text))
                        btn_Next.Enabled = false;
                    else
                        btn_Next.Enabled = true;
                }
            }
            else if (tabControl_Main.SelectedTab.Text == "Apply")
                btn_Next.Visible = false;
            // Only show Action button when used by a page
            btn_Action.Visible = false;
            btn_Action.Enabled = false;
            if (tabControl_Main.SelectedTab.Text == "Updates")
            {
                btn_Action.Text = "Download";
                btn_Action.Visible = true;
                btn_Action.Enabled = true;
            }
            else if (tabControl_Main.SelectedTab.Text == "Patches")
            {
                btn_Action.Text = "Toggle All";
                btn_Action.Visible = true;
                btn_Action.Enabled = true;
            }
            else if (tabControl_Main.SelectedTab.Text == "Apply")
            {
                btn_Action.Text = "Apply Patches";
                btn_Action.Visible = true;
                btn_Action.Enabled = true;
            }

            // Reload patches if game platform or target platform have changed
            // or load for the first time when Patches page has been reached
            if (!patchesInitialized && tabControl_Main.SelectedTab.Text == "Patches")
            {
                SetupPatches();
            }
        }

        // Select Patches Page

        private void SetupPatches()
        {
            foreach (var patch in selectedGame.Patches)
            {
                chkListBox_Patches.Items.Add(patch.Name, patch.OnByDefault);
            }
            patchesInitialized = true;

            if (radio_Console.Checked)
            {
                lbl_ConsoleIP.Visible = true;
                txt_ConsoleIP.Visible = true;
                lbl_ExePath.Visible = false;
            }
            else
            {
                lbl_ConsoleIP.Visible = false;
                txt_ConsoleIP.Visible = false;
            }

        }

        private void ResetPatches()
        {
            chkListBox_Patches.Items.Clear();
            patchesInitialized = false;

            if (radio_Console.Checked)
            {
                lbl_ExePath.Visible = false;
                tlp_3_Platform_ExePath.Visible = false;
                SetInputFileLabels();
            }
            else
            {
                lbl_ExePath.Visible = true;
                tlp_3_Platform_ExePath.Visible = true;
                lbl_PKGPath.Visible = false;
                tlp_3_Platform_PKGPath.Visible = false;

                if (!File.Exists(txt_ExePath.Text))
                    btn_Next.Enabled = false;
                else
                    btn_Next.Enabled = true;
            }
        }

        private void SelectedPatch_Changed(object sender, EventArgs e)
        {
            if (chkListBox_Patches.SelectedItem != null &&
                selectedGame.Patches.Any(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString())))
            {
                var selectedPatch = selectedGame.Patches.Single(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString()));

                rtb_Patches_Log.Clear();
                rtb_Patches_Log.AppendText($"{selectedPatch.Name} {selectedPatch.Version} by {selectedPatch.Author}\n\n" +
                    $"{selectedPatch.Description}");
            }
        }

        private void ToggleAllPatches()
        {
            for (int i = 0; i < chkListBox_Patches.Items.Count; i++)
            {
                if (selectAll)
                    chkListBox_Patches.SetItemCheckState(i, CheckState.Checked);
                else
                    chkListBox_Patches.SetItemCheckState(i, CheckState.Unchecked);
            }
            selectAll = !selectAll;
        }

        // Apply Patches Page 
        private void ApplyPatches()
        {
            btn_Action.Enabled = false;
            btn_Back.Enabled = false;
            rtb_Apply_Log.Clear();

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                switch (selectedPlatform.ShortName)
                {
                    case "PS2":
                        PatchPS2Game();
                        break;
                    case "PS3":
                        PatchPS3Game();
                        break;
                    case "PS4":
                        PatchPS4Game();
                        break;
                    case "3DS":
                        Patch3DSGame();
                        break;
                    default:
                        break;
                }
                SetProgress(100);
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Done!");
            }).Start();

            btn_Action.Enabled = true;
            btn_Back.Enabled = true;
        }

        private void Patch3DSGame()
        {
            /*
            ApplyPatches();
            FTPCodeBin();
            */
        }

        private void PatchPS4Game()
        {
            SetProgress(0);

            if (Python3Installed())
            {
                if (selectedGame.ShortName != "P5R" || CheckP5RUpdateFiles())
                {
                    string outputDir = Path.Combine(Exe.Directory(), $"Output\\{selectedGame.TitleID}");
                    if (!Directory.Exists($"{outputDir}\\base_extracted"))
                        Directory.CreateDirectory($"{outputDir}\\base_extracted");

                    if (!File.Exists($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat") || !File.Exists($"{outputDir}\\base_extracted\\Sc0\\npbind.dat") 
                        || !File.Exists($"{outputDir}\\base_extracted\\Sc0\\param.sfo") || !File.Exists($"{outputDir}\\base_extracted\\Image0\\eboot.bin"))
                        ExtractPKG(outputDir);

                    List<List<GamePatch>> patchCombos = GetPatchCombos();

                    for (int i = 0; i < patchCombos.Count; i++)
                    {
                        PatchLog($"Creating PKG ({i + 1}/{patchCombos.Count()}, please be patient as this can take a very long time...");
                        Thread.Sleep(200);
                        CreateUpdatePKG(patchCombos[i], outputDir);
                    }
                }
            }
        }

        private bool CheckP5RUpdateFiles()
        {
            bool fileMissing = false;
            string updateFilesDir = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch\\USRDIR");

            foreach (var file in new string[] { "patch2R.cpk", "patch2R_F.cpk", "patch2R_G.cpk", "patch2R_I.cpk", "patch2R_S.cpk" })
            {
                if (!File.Exists(Path.Combine(updateFilesDir, file)))
                    fileMissing = true;
            }
            if (fileMissing)
            {
                MessageBox.Show($"Please place the extracted CPKs from the P5R v1.02 update in the following directory and try again: {updateFilesDir}");
                return false;
            }
            return true;
        }

        private bool Python3Installed()
        {
            Python.GetInstalls("3.0.0");
            if (Python.FoundLocations.Count() > 0)
            {
                pythonPath = Python.FoundLocations.First().Value;
                return true;
            }
            else
                MessageBox.Show("Please install Python 3.0 or higher in order to apply these patches.");
            return false;
        }

        private void CreateUpdatePKG(List<GamePatch> patchCombo, string outputDir)
        {
            List<string> patchNames = new List<string>();
            List<string> patchShortNames = new List<string>();
            foreach (var patch in patchCombo)
            {
                patchNames.Add(patch.Name);
                patchShortNames.Add(patch.ShortName);
            }
                
            PatchLog($"\t{String.Join("+", patchNames)}");

            SetProgress(1);

            // Update path in gp4 to PKG
            string gp4Path = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch.gp4");
            var gp4Text = File.ReadAllLines(gp4Path);
            for (int i = 0; i < gp4Text.Count(); i++)
                if (gp4Text[i].Contains("app_path="))
                    gp4Text[i] = $"      app_path=\"{txt_PKGPath.Text}\"";

            SetProgress(5);

            // Create working dir from dependencies folder (updated with extracted files from base game PKG)
            string genGP4Dir = Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\GenGP4\\{selectedGame.TitleID}-patch");
            string patchDir = Path.Combine(outputDir, $"{selectedGame.TitleID}-patch");
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\nptitle.dat", Path.Combine(genGP4Dir, "sce_sys\\nptitle.dat"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\npbind.dat"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\npbind.dat", Path.Combine(genGP4Dir, "sce_sys\\npbind.dat"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Sc0\\param.sfo"))
                File.Copy($"{outputDir}\\base_extracted\\Sc0\\param.sfo", Path.Combine(genGP4Dir, "sce_sys\\param.sfo"), true);
            if (File.Exists($"{outputDir}\\base_extracted\\Image0\\eboot.bin"))
                File.Copy($"{outputDir}\\base_extracted\\Image0\\eboot.bin", Path.Combine(genGP4Dir, "eboot.bin"), true);
            FileSys.CopyDir(genGP4Dir, patchDir);
            File.Copy(gp4Path, Path.Combine(Path.GetDirectoryName(patchDir), $"{selectedGame.TitleID}-patch.gp4"), true);

            SetProgress(10);

            // Patch EBOOT
            if (PatchEBOOTWithPPP(Path.Combine(genGP4Dir, "eboot.bin"), patchShortNames))
            {
                PatchLog($"Patched EBOOT successfully.");

                SetProgress(20);

                // Update PKG description
                File.WriteAllText($"{genGP4Dir}\\sce_sys\\changeinfo\\changeinfo.xml", $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<changeinfo>\n  <changes app_ver=\"01.01\">\n    <![CDATA[\nPatched using ShrineFox's PersonaPatcher2 Software\n(based on zarroboogs's ppp):\n\n - {string.Join("\n - ", patchNames)}\n    ]]>\n  </changes>\n</changeinfo>");
                PatchLog("Edited Update PKG description.");

                SetProgress(30);

                if (BuildPKG(patchShortNames, genGP4Dir))
                    PatchLog("Update PKG created successfully!");
                else
                    PatchLog("Update PKG creation failed.");
            }
            else
                PatchLog("Patched EBOOT creation failed.");
        }

        private bool BuildPKG(List<string> patchShortNames, string genGP4Dir)
        {
            // (Re)create temp dir
            string tempPKGDir = Path.Combine(genGP4Dir, "Dependencies\\PS4\\temp");
            Exe.CloseProcess("orbis-pub-cmd", true);
            if (Directory.Exists(tempPKGDir))
                Directory.Delete(tempPKGDir, true);
            Directory.CreateDirectory(tempPKGDir);

            // Generate new PKG file
            string args = $"img_create --oformat pkg --tmp_path ./temp ./{selectedGame.TitleID}-patch.gp4 ./temp";
            Exe.Run(Path.Combine(Exe.Directory(), $"Dependencies\\PS4\\orbis-pub-cmd.exe"), args, true, Path.GetDirectoryName(genGP4Dir));

            // Copy PKG/EBOOT to Output folder
            string pkgPath = $"Dependencies\\PS4\\{selectedGame.PKGName}";
            using (FileSys.WaitForFile(pkgPath)) { };
            if (File.Exists(pkgPath))
            {
                string outputEboot = $"{Exe.Directory()}\\Output\\EBOOT\\{string.Join("\\", patchShortNames)}";
                string outputPKG = $"{Exe.Directory()}\\Output\\PKG\\{string.Join("\\", patchShortNames)}";
                Directory.CreateDirectory(Path.Combine(outputEboot));
                Directory.CreateDirectory(Path.Combine(outputPKG));
                string newEbootPath = Path.Combine(outputEboot, "eboot.bin");
                if (File.Exists(newEbootPath))
                    File.Delete(newEbootPath);
                File.Move(Path.Combine(genGP4Dir, "eboot.bin"), newEbootPath);
                string newPKGPath = Path.Combine(outputPKG, selectedGame.PKGName);
                PatchLog("Patched EBOOT moved to Output folder");
                if (File.Exists(newPKGPath))
                    File.Delete(newPKGPath);
                File.Move(pkgPath, newPKGPath);
                PatchLog("Update PKG moved to Output folder");
                return true;
            }
            return false;
        }

        private bool PatchEBOOTWithPPP(string ebootPath, List<string> patchShortNames)
        {
            // Make sure xdelta.exe is in PATH
            string xdelta = Path.Combine(Exe.Directory(), @"Dependencies\xdelta.exe");
            Directory.CreateDirectory(@"C:\.bin");
            File.Copy(xdelta, @"C:\.bin\xdelta.exe", true);
            var oldValue = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);
            if (!oldValue.Contains(@"C:\.bin"))
                Environment.SetEnvironmentVariable("PATH", oldValue + @";C:\.bin", EnvironmentVariableTarget.User);

            string pyPath = Path.Combine(Exe.Directory(), @"Dependencies\PS4\ppp\patch.py");
            string args = $"{pyPath} {Path.GetFileName(ebootPath)} --patch {string.Join(" ", patchShortNames)}";
            using (FileSys.WaitForFile(ebootPath)) { };
            Exe.Run(pythonPath, args, true, Path.GetDirectoryName(ebootPath));
            string patchedEbootPath = ebootPath + "--patched";
            using (FileSys.WaitForFile(patchedEbootPath)) { };
            if (File.Exists(patchedEbootPath))
            {
                using (FileSys.WaitForFile(ebootPath)) { };
                File.Copy(patchedEbootPath, ebootPath, true);
                
                return true;
            }
            return false;
        }

        private List<List<GamePatch>> GetPatchCombos()
        {
            var patchCombos = new List<List<GamePatch>>();
            List<GamePatch> selectedPatches = new List<GamePatch>();

            foreach (var patch in chkListBox_Patches.CheckedItems)
                selectedPatches.Add(selectedGame.Patches.First(x => x.Name.Equals(patch.ToString())));
            if (chk_Permutations.Checked)
            {
                if (selectedGame.ShortName == "P5R")
                {
                    foreach (var combination in Data.Permutations(selectedPatches)
                        .Where(x => x.Count() > 0)
                        .Where(x =>
                        // Make sure both bgm shuffle types aren't present at the same time
                        !(x.Any(z => z.ShortName.Equals("bgm_ord")) && x.Any(z => z.ShortName.Equals("bgm_rnd")))
                        // Make all_dlc include dlc_msg
                        && !((x.Any(z => z.ShortName.Equals("all_dlc")) && !x.Any(z => z.ShortName.Equals("dlc_msg")))
                        || (x.Any(z => z.ShortName.Equals("dlc_msg")) && !x.Any(z => z.ShortName.Equals("all_dlc"))))
                        ))
                    {
                        patchCombos.Add(combination.ToList());
                    }
                }
                else
                    patchCombos.Add(selectedPatches);
            }
            else
                patchCombos.Add(selectedPatches);

            return patchCombos;
        }

        private void ExtractPKG(string outputDir)
        {
            PatchLog("Extracting PKG. Please wait, this may take a long time. This step only needs to be performed once...");
            Thread.Sleep(200);
            Exe.Run("Dependencies\\PS4\\orbis-pub-cmd.exe", $"img_extract --passcode 00000000000000000000000000000000 \"{txt_PKGPath.Text}\" \"{outputDir}\"");
            PatchLog("Successfully extracted files from Base Game FPKG!");
        }

        private void PatchPS3Game()
        {
            /*
            CreateYML();
            PatchEBOOT();
            FTPEBOOT();
            */
        }

        private void PatchPS2Game()
        {
            /*
            ExtractISO();
            CreatePNACH();
            PatchExecutable();
            RepackISO();
            */
        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void Action_Clicked(object sender, EventArgs e)
        {
            PerformAction();
        }

        private bool PerformAction()
        {
            if (tabControl_Main.SelectedTab.Text == "Updates")
            {
                btn_Action.Enabled = false;
                DownloadPatches();
            }
            else if (tabControl_Main.SelectedTab.Text == "Patches")
            {
                ToggleAllPatches();
            }
            else if (tabControl_Main.SelectedTab.Text == "Apply")
            {
                ApplyPatches();
            }

            return true;
        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            NextPage();
        }

        private void NextPage()
        {
            tabControl_Main.SelectedIndex += 1;
        }

        private void PreviousPage()
        {
            tabControl_Main.SelectedIndex -= 1;
        }

        // Prevent users navigating TabControl via Ctrl+Tab and Ctrl+Shift+Tab.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (System.Convert.ToBoolean(keyData & Keys.Tab | Keys.Control))
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
