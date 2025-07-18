using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonaGameLib;

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void SetInitialAppearance()
        {
            // Hide tabs of tabview and set up tab contents
            tabControl_Main.HideTabs = true;
            CreatePages();

#if DEBUG
            Output.VerboseLogging = true;
            Output.LogControl = rtb_Apply_Log;
            Output.Logging = true;
            
            comboBox_Platform.SelectedIndex = comboBox_Platform.Items.IndexOf("PlayStation 4");
            comboBox_Region.SelectedIndex = comboBox_Region.Items.IndexOf("USA");
            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf("Persona 5 Royal");
            txt_PKGPath.Text = @"Z:\Games\Persona\Backups\PS4\Persona 5 Royal\USA\UP0177-CUSA17416_00-PERSONA5R0000000-A0100-V0100.pkg";
            btn_Next.Enabled = true;
#endif
        }

        /// <summary>
        /// Applies rich text description to each "page" of the tabview.
        /// </summary>
        private void CreatePages()
        {
            rtb_1_Welcome.LoadFile(@"./Forms/InstallWizard/Documents/Welcome.rtf");
            //ShowLastUpdated();
            rtb_3_Platform.LoadFile(@"./Forms/InstallWizard/Documents/Platform.rtf");
            rtb_4_Patches.LoadFile(@"./Forms/InstallWizard/Documents/Patches.rtf");
            rtb_5_Apply.LoadFile(@"./Forms/InstallWizard/Documents/Apply.rtf");
        }

        /// <summary>
        /// Display date/time when updatable files were last changed.
        /// </summary>
        private void ShowLastUpdated()
        {
            //rtb_2_Updates.LoadFile(@"./Forms/InstallWizard/Documents/Updates.rtf");
            //rtb_2_Updates.AppendText($"\r\nLast Updated: {File.GetLastWriteTime("./Dependencies/PS3/patch.yml")}");
        }

        /// <summary>
        /// Update variable for selected platform, and toggle whether user can select region.
        /// </summary>
        private void UpdateSelectedPlatform()
        {
            selectedPlatform = new Platform();

            if (PersonaGames.Platforms.Any(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString())))
            {
                selectedPlatform = PersonaGames.Platforms.Single(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString()));
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

        /// <summary>
        /// Update selected region variable, and toggle whether user can select game.
        /// </summary>
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

        /// <summary>
        /// Update currently selected game, and toggle whether user can proceed to next tab.
        /// </summary>
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

        /// <summary>
        /// List of paths to updatable files on remote web server, no longer needed.
        /// </summary>
        public static List<string> downloads = new List<string>()
        {
            /*
            "./pnach/P3FES_hostFS.txt",
            "./pnach/P4_hostFS.txt",
            "./yml/patch.yml",
            "./yml/p5_ex/patches/patch.yml",
            "./yml/p5_ex/USRDIR/config.yml",
            "./yml/p5_ex/USRDIR/mod.sprx",
            "./yml/p5_ex/hardware/p5ex/conf.yml",
            "./yml/p5_ex/hardware/p5ex/mod.sprx"
            */
        };

        /// <summary>
        /// Download latest patches from remote web server.
        /// </summary>
        private void DownloadPatches()
        {
            /*
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
                            client.DownloadFile(url.Replace("./", "https://shrinefox.com/"), 
                                url.Replace("./pnach", "./Dependencies/PS2").Replace("./yml", "./Dependencies/PS3"));
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
            */
        }

        /// <summary>
        /// Update options on target platform tab depending on user selection.
        /// </summary>
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

        /// <summary>
        /// Allow user to proceed to next tab if using emulator (and valid EXE is entered).
        /// </summary>
        private void AdvanceIfEmuValid()
        {
            if (!radio_Console.Checked && File.Exists(txt_ExePath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        /// <summary>
        /// Allow user to proceed to next tab if using console (and valid PKG/ISO is entered).
        /// </summary>
        private void AdvanceIfPKGValid()
        {
            if (radio_Console.Checked && File.Exists(txt_PKGPath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        /// <summary>
        /// Depending on target platform, update labels of input paths.
        /// </summary>
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

        /// <summary>
        /// Determine whether user can go back/forth between tabs based on current variable values.
        /// </summary>
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

        /// <summary>
        /// Fill out patches tab based on current selections.
        /// </summary>
        private void SetupPatches()
        {
            foreach (var patch in selectedGame.Patches)
            {
                chkListBox_Patches.Items.Add(patch.Name, patch.Enabled);
            }
            patchesInitialized = true;
        }

        /// <summary>
        /// Set toggled patches back to their original state.
        /// </summary>
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

        /// <summary>
        /// Enable or disable all selectable patches.
        /// </summary>
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

        /// <summary>
        /// Apply patches to game depending on target platform.
        /// </summary>
        private void ApplyPatches()
        {
            btn_Action.Enabled = false;
            btn_Back.Enabled = false;
            rtb_Apply_Log.Clear();

            DateTime startedAt = DateTime.Now;

            Thread.Sleep(200);
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
            }).Start();

            DateTime endedAt = DateTime.Now;
            TimeSpan duration = endedAt - startedAt;
            PatchLog($"Completed in: {duration}");

            btn_Action.Enabled = true;
            btn_Back.Enabled = true;
        }

        /// <summary>
        /// Generate all permutations of currently enabled patches (for PS4/Vita).
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Perform the function of the current tabpage.
        /// </summary>
        /// <returns></returns>
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
                if (chk_Permutations.Checked)
                    if (!WinFormsDialogs.ShowMessageBox("Generate All Patch Combos?", 
                        "You have checked the \"All Combos\" box, which means every possible combination of selected patches " +
                        "will be output. This can take a lot of time and use a lot of resources and disk space, are you sure " +
                        "you would like to continue?", MessageBoxButtons.YesNo))
                        return false;
                if (chkListBox_Patches.CheckedItems.Count < 1)
                    return false;
                ApplyPatches();
            }

            return true;
        }

        /// <summary>
        /// Check if Python 3+ is installed.
        /// </summary>
        /// <returns></returns>
        private bool Python3Installed()
        {
            ShrineFox.IO.Python.GetInstalls("3.0.0");
            if (ShrineFox.IO.Python.FoundLocations.Count() > 0)
            {
                pythonPath = ShrineFox.IO.Python.FoundLocations.First().Value;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Prompt user to download and install Python if not found.
        /// </summary>
        private void DownloadPython3()
        {
            string downloadURL = "https://www.python.org/ftp/python/3.6.8/python-3.6.8-amd64.exe";
            if (!Environment.Is64BitOperatingSystem)
                downloadURL = "https://www.python.org/ftp/python/3.6.8/python-3.6.8.exe";

            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(downloadURL, "pythonsetup.exe");
                    Exe.Run("pythonsetup.exe");
                }
                catch
                {
                    MessageBox.Show("Failed to download and install Python automatically.");
                }
            }
        }
    }
}
