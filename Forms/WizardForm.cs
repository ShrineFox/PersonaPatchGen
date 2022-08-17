using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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

        public WizardForm()
        {
            InitializeComponent();
            SetInitialAppearance();
        }

        private void SetInitialAppearance()
        {
            tabControl_Main.HideTabs = true;
            SetupLogging();
            CreatePages();

#if DEBUG
            Output.VerboseLogging = true;
            comboBox_Platform.SelectedIndex = comboBox_Platform.Items.IndexOf("PlayStation 4");
            comboBox_Region.SelectedIndex = comboBox_Region.Items.IndexOf("USA");
            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf("Persona 5 Dancing");
            txt_PKGPath.Text = @"F:\Games\Persona\Backups\PS4\Persona 5 Dancing\USA\UP2611-CUSA12380_00-PERSONA5DUS00000-A0100-V0100.pkg";
            btn_Next.Enabled = true;
#endif
        }

        private void SetupLogging()
        {
            Output.LogPath = "PatchLog.txt";
            Output.LogControl = rtb_Apply_Log;
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
            progressBar_Updates.Value = 20;
            btn_Next.Enabled = false;

            rtb_Updates_Log.AppendText($"\r\ndownload started {DateTime.Now}\r\n-------------------");
            foreach (var url in downloads)
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        client.DownloadFile(url.Replace("./", "https://shrinefox.com/"), url);
                        rtb_Updates_Log.AppendText($"\r\nUpdated: {url}");
                    }
                    catch
                    {
                        rtb_Updates_Log.AppendText($"\r\nFailed to download: {url}");
                        btn_Action.Text = "Try Again";
                        btn_Action.Enabled = true;
                    }
                    progressBar_Updates.PerformStep();
                }
            }
            rtb_Updates_Log.AppendText($"\r\nDone");
            ShowLastUpdated();
            btn_Next.Enabled = true;
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
            rtb_Apply_Log.Clear();

            switch(selectedPlatform.ShortName)
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
            ExtractPS4Bins();
            //ExtractPS4ELF();
            //PatchELF();
            //CreateUpdate();
        }

        private async void ExtractPS4Bins()
        {
            string outputDir = Path.Combine(Exe.Directory(), "extracted");
            if (Directory.Exists(outputDir))
                Directory.Delete(outputDir, true);
            Directory.CreateDirectory(outputDir);

            Exe.Run("Dependencies\\PS4\\PkgTool.exe", $"pkg_listentries \"{txt_PKGPath.Text}\"");
            await Task.Delay(400);
            int start = rtb_Apply_Log.Text.LastIndexOf('?');
            string[] output = Regex.Replace(rtb_Apply_Log.Text.Substring(start).Replace("? Name\n", ""), " {2,}", "\t").Split('\n');
            rtb_Apply_Log.Clear();

            foreach (var line in output)
            {
                string[] splitLine = line.Split('\t');
                switch (splitLine.Last())
                {
                    case "NPBIND_DAT":
                        ExtractPKGFile(Convert.ToInt32(splitLine[3]), $"{outputDir}\\npbind.dat");
                        break;
                    case "NPTITLE_DAT":
                        ExtractPKGFile(Convert.ToInt32(splitLine[3]), $"{outputDir}\\nptitle.dat");
                        break;
                    case "PARAM_SFO":
                        ExtractPKGFile(Convert.ToInt32(splitLine[3]), $"{outputDir}\\param.sfo");
                        break;
                    default:
                        break;
                }
            }
            await Task.Delay(400);
            if (File.Exists(".\\extracted\\nptitle.dat") && File.Exists(".\\extracted\\npbind.dat") && File.Exists(".\\extracted\\param.sfo"))
                Output.Log("Successfully extracted files from Base Game FPKG!");
            else
                Output.Log("Failed to extract all of the following files from Base Game FPKG:\r\n\tnptitle.dat npbind.dat param.sfo");
        }

        private void ExtractPKGFile(int id, string outputPath)
        {
            Exe.Run("Dependencies\\PS4\\PkgTool.exe", $"pkg_extractentry --passcode 00000000000000000000000000000000 \"{txt_PKGPath.Text}\" {id} \"{outputPath}\"");
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

        private void PerformAction()
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
