using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;
using ShrineFoxCom;

namespace PersonaPatchGen
{
    public partial class MainForm : DarkForm
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
        Platform selectedPlatform = new Platform();
        Game selectedGame = new Game();
        string selectedRegion = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Platform_Changed(object sender, EventArgs e)
        {
            ResetAllControls();

            selectedPlatform = new Platform();

            if (platforms.Any(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString())))
            {
                selectedPlatform = platforms.Single(x => x.Name.Equals(comboBox_Platform.SelectedItem.ToString()));
                comboBox_Region.Enabled = true;
            }
        }

        private void ResetAllControls()
        {
            btn_Generate.Enabled = false;
            comboBox_Game.Items.Clear();
            chkListBox_Patches.Items.Clear();
            comboBox_Region.Enabled = false;
            comboBox_Region.SelectedIndex = 0;
            comboBox_Game.Enabled = false;
            txt_Log.Clear();
            HideAllVariableControls();

            txtBox_CRC.Text = "";
            txtBox_Eboot.Text = "";
            txtBox_EmuPath.Text = "";
            txtBox_FPKG.Text = "";
            chkBox_Permutations.Checked = false;
        }

        private void Region_Changed(object sender, EventArgs e)
        {
            btn_Generate.Enabled = false;
            comboBox_Game.Items.Clear();
            chkListBox_Patches.Items.Clear();
            comboBox_Game.Enabled = false;
            HideAllVariableControls();

            selectedRegion = comboBox_Region.SelectedItem.ToString();
            var regionGames = selectedPlatform.Games.Where(x => x.Region.Equals(selectedRegion));

            if (regionGames.Count() > 0)
            {
                comboBox_Game.Items.Add("");

                foreach (var game in regionGames)
                    comboBox_Game.Items.Add(game.Name);
                comboBox_Game.Enabled = true;
            }
        }

        private void Game_Changed(object sender, EventArgs e)
        {
            HideAllVariableControls();
            btn_Generate.Enabled = false;
            chkListBox_Patches.Items.Clear();
            selectedGame = new Game();

            if (selectedPlatform.Games.Any(x => x.Name.Equals(comboBox_Game.SelectedItem.ToString())))
            {
                selectedGame = selectedPlatform.Games.Single(x =>
                    x.Name.Equals(comboBox_Game.SelectedItem.ToString())
                    && x.Region.Equals(selectedRegion));

                foreach (var patch in selectedGame.Patches)
                    chkListBox_Patches.Items.Add(patch.Name, patch.OnByDefault);

                SetControlVisibility();
            } 
        }

        private void SetControlVisibility()
        {
            HideAllVariableControls();
            btn_Generate.Enabled = true;

            switch (selectedPlatform.ShortName)
            {
                case "PS2":
                    lbl_CRC.Text = "Game CRC:";
                    lbl_CRC.Visible = true; txtBox_CRC.Visible = true;
                    lbl_EmuPath.Text = "PCSX2 .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    break;
                case "PS3":
                    lbl_CRC.Text = "Game PPU Hash:";
                    lbl_CRC.Visible = true; txtBox_CRC.Visible = true;
                    lbl_EmuPath.Text = "RPCS3 .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    break;
                case "PS4":
                    lbl_Eboot.Visible = true; txtBox_Eboot.Visible = true;
                    lbl_FPKG.Visible = true; txtBox_FPKG.Visible = true;
                    chkBox_Permutations.Visible = true;
                    break;
                case "PSP":
                    lbl_Eboot.Visible = true; txtBox_Eboot.Visible = true;
                    lbl_EmuPath.Text = "PPSSPP .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    break;
                case "PSV":
                    lbl_Eboot.Visible = true; txtBox_Eboot.Visible = true;
                    lbl_EmuPath.Text = "Vita3K .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    chkBox_Permutations.Visible = true;
                    break;
                case "3DS":
                    lbl_EmuPath.Text = "Citra .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    break;
                default:
                    btn_Generate.Enabled = false;
                    break;
            }
        }

        private void HideAllVariableControls()
        {
            lbl_CRC.Visible = false; txtBox_CRC.Visible = false;
            lbl_EmuPath.Visible = false; txtBox_EmuPath.Visible = false;
            lbl_Eboot.Visible = false; txtBox_Eboot.Visible = false;
            lbl_FPKG.Visible = false; txtBox_FPKG.Visible = false;
            chkBox_Permutations.Visible = false;
            txt_Log.Clear();
        }

        private void SelectedPatch_Changed(object sender, EventArgs e)
        {
            if (chkListBox_Patches.SelectedItem != null &&
                selectedGame.Patches.Any(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString())))
            {
                var selectedPatch = selectedGame.Patches.Single(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString()));

                txt_Log.Clear();
                txt_Log.AppendText($"\n\n{selectedPatch.Name} by {selectedPatch.Author}\n\n" +
                    $"{selectedPatch.Description}");
            }
        }

    }
}
