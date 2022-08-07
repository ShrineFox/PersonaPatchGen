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
        public static List<Platform> platforms = new List<Platform>()
        {
            new Platform() { Name = "PlayStation 2",
                             ShortName = "PS2",
                             Games = Games.PS2Games
            },
            new Platform() { Name = "PlayStation 3",
                             ShortName = "PS3",
                             Games = Games.PS3Games
            },
            new Platform() { Name = "PlayStation 4",
                             ShortName = "PS4",
                             Games = Games.PS4Games
            },
            new Platform() { Name = "PlayStation Vita",
                             ShortName = "PSV",
                             Games = Games.PSVGames
            },
            new Platform() { Name = "PlayStation Portable",
                             ShortName = "PSP",
                             Games = Games.PSPGames
            },
            new Platform() { Name = "Nintendo 3DS",
                             ShortName = "3DS",
                             Games = Games.PQGames
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
        string selectedTarget = "";
        string PPUHash = "";
        bool downloadComplete = false;

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
            rtb_2_Updates.LoadFile(@"./Forms/Documents/Updates.rtf");
            rtb_3_Platform.LoadFile(@"./Forms/Documents/Platform.rtf");
        }

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
                comboBox_Game.Visible = true; lbl_Game.Visible = true;
            }
            else
            {
                comboBox_Region.Visible = false; lbl_Region.Visible = false;
                comboBox_Game.Visible = false; lbl_Game.Visible = false;
            }
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
            }
            else
                comboBox_Game.Visible = false; lbl_Game.Visible = false;
        }

        private void Game_Changed(object sender, EventArgs e)
        {
            if (selectedPlatform.Games.Any(x => x.Name.Equals(comboBox_Game.SelectedItem.ToString())))
            {
                selectedGame = selectedPlatform.Games.Single(x =>
                    x.Name.Equals(comboBox_Game.SelectedItem.ToString())
                    && x.Region.Equals(selectedRegion));
                btn_Next.Enabled = true;
            }
            else
                btn_Next.Enabled = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex += 1;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex -= 1;
        }

        private void TryAgain_Click(object sender, EventArgs e)
        {
            btn_TryAgain_2.Enabled = false;
            DownloadPatches();
        }

        private void DownloadPatches()
        {
            circleBar_Updates.Value = 20;
            btn_Next_2.Enabled = false;

            rtb_2_Updates.AppendText($"\r\ndownload started {DateTime.Now}\r\n-------------------");
            foreach (var url in downloads)
            {
                using (var client = new WebClient())
                {
                    circleBar_Updates.Text = Path.GetFileName(url);
                    try
                    {
                        client.DownloadFile(url.Replace("./", "https://shrinefox.com/"), url);
                        rtb_2_Updates.AppendText($"\r\nUpdated: {url}");
                    }
                    catch
                    {
                        rtb_2_Updates.AppendText($"\r\nFailed to download: {url}");
                        btn_TryAgain_2.Text = "Try Again";
                        btn_TryAgain_2.Enabled = true;
                    }
                    circleBar_Updates.PerformStep();
                }
            }
            circleBar_Updates.Text = "done";
            btn_Next_2.Enabled = true;
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
