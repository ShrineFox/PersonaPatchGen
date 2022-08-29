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

namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        private void SetInitialAppearance()
        {
            tabControl_Main.HideTabs = true;
            CreatePages();

#if DEBUG
            Output.VerboseLogging = true;
            Output.LogControl = rtb_Patches_Log;
            comboBox_Platform.SelectedIndex = comboBox_Platform.Items.IndexOf("PlayStation 4");
            comboBox_Region.SelectedIndex = comboBox_Region.Items.IndexOf("EUR");
            comboBox_Game.SelectedIndex = comboBox_Game.Items.IndexOf("Persona 4 Dancing");
            txt_PKGPath.Text = @"C:\Users\Ryan\Documents\GitHub\EP2475-CUSA12811_00-PERSONA4DEU00000-A0100-V0100.pkg";
            btn_Next.Enabled = true;
#endif
        }

        private void CreatePages()
        {
            rtb_1_Welcome.LoadFile(@"./Forms/InstallWizard/Documents/Welcome.rtf");
            ShowLastUpdated();
            rtb_3_Platform.LoadFile(@"./Forms/InstallWizard/Documents/Platform.rtf");
            rtb_4_Patches.LoadFile(@"./Forms/InstallWizard/Documents/Patches.rtf");
            rtb_5_Apply.LoadFile(@"./Forms/InstallWizard/Documents/Apply.rtf");
        }

        private void ShowLastUpdated()
        {
            rtb_2_Updates.LoadFile(@"./Forms/InstallWizard/Documents/Updates.rtf");
            rtb_2_Updates.AppendText($"\r\nLast Updated: {File.GetLastWriteTime("./Dependencies/PS3/patch.yml")}");
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
        }

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

        private void AdvanceIfEmuValid()
        {
            if (!radio_Console.Checked && File.Exists(txt_ExePath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        private void AdvanceIfPKGValid()
        {
            if (radio_Console.Checked && File.Exists(txt_PKGPath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
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
                    if (!WinFormsmDialogs.YesNoMsgBox("Generate All Patch Combos?", "You have checked the \"All Combos\" box, which means every possible combination of selected patches will be output. This can take a lot of time and use a lot of resources and disk space, are you sure you'd like to continue?"))
                        return false;
                if (chkListBox_Patches.CheckedItems.Count < 1)
                    return false;
                ApplyPatches();
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
            return false;
        }

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
