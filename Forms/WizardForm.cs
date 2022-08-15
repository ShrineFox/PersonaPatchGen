using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
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
            CreatePages();
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

            if (File.Exists(txt_ExePath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
        }

        private void Checked_Changed(object sender, EventArgs e)
        {
            ResetPatches();

            if (radio_Console.Checked)
            {
                lbl_ExePath.Visible = false;
                tlp_3_Platform_ExePath.Visible = false;
                btn_Next.Enabled = true;
            }
            else
            {
                lbl_ExePath.Visible = true;
                tlp_3_Platform_ExePath.Visible = true;

                if (!File.Exists(txt_ExePath.Text))
                    btn_Next.Enabled = false;
                else
                    btn_Next.Enabled = true;
            }
        }

        private void ExePath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txt_ExePath.Text))
                btn_Next.Enabled = true;
            else
                btn_Next.Enabled = false;
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
            if (tabControl_Main.SelectedTab.Text == "Platform" && selectedPlatform.EmulatorName != "" && !radio_Console.Checked)
            {
                if (!File.Exists(txt_ExePath.Text))
                    btn_Next.Enabled = false;
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
            throw new NotImplementedException();
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
            if (ActiveControl is TabControl)
            {
                if (System.Convert.ToBoolean(keyData & Keys.Tab | Keys.Control))
                    return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
