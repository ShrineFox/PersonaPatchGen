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
            txt_Desc.Clear();
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
                    lbl_Eboot.Visible = true; txtBox_Eboot.Visible = true;
                    lbl_Eboot.Text = ".ISO Path:";
                    lbl_CRC.Text = "Game CRC:";
                    lbl_CRC.Visible = true; txtBox_CRC.Visible = true;
                    lbl_EmuPath.Text = "PCSX2 .exe Path:";
                    lbl_EmuPath.Visible = true; txtBox_EmuPath.Visible = true;
                    break;
                case "PS3":
                    lbl_Eboot.Visible = true; txtBox_Eboot.Visible = true;
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
            lbl_Eboot.Text = "EBOOT Path:";
            txt_Desc.Clear();
        }

        private void SelectedPatch_Changed(object sender, EventArgs e)
        {
            if (chkListBox_Patches.SelectedItem != null &&
                selectedGame.Patches.Any(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString())))
            {
                var selectedPatch = selectedGame.Patches.Single(x => x.Name.Equals(chkListBox_Patches.SelectedItem.ToString()));

                txt_Desc.Clear();
                txt_Desc.AppendText($"{selectedPatch.Name} by {selectedPatch.Author}\n\n" +
                    $"{selectedPatch.Description}");
            }
        }

        private void Permutations_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText("======Generate All Combos======\n\nWhen checked, all possible combinations of selected " +
                "patches will be auto-generated.");
        }

        private void Generate_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText("======Generate Patches======\n\nWhen clicked, the selected patches will be applied. " +
                "Depending on the game, platform, and any input paths provided, output may vary.");
        }

        private void EmuPath_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText($"======{lbl_EmuPath.Text.TrimEnd(':')}======\n\nOptional, only include if you are emulating the game on PC. Otherwise, leave blank.");
        }

        private void CRC_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText($"======{lbl_CRC.Text.TrimEnd(':')}======\n\nThis is only required if you are emulating the game on PC, " +
                "otherwise leave it blank! The emulator may not apply the patches without it.\n\n");
            switch(selectedPlatform.ShortName)
            {
                case "PS2":
                    txt_Desc.AppendText($"======PCSX2 Instructions======\n   1. Make sure System > Enable Cheats is checked.\n   " +
                        "2. Start the game and go to Misc > Show Console to open the PCSX2 program log, if it isn't already open." +
                        "\n   3. Stop the game and use CTRL + A to select all the text in the log and copy it to a text editor if needed." +
                        $"\n   4. Search for the \"Game CRC\" and copy and paste it into this program's \"{lbl_CRC.Text.TrimEnd(':')}\" field before patching.");
                    break;
                case "PS3":
                    txt_Desc.AppendText($"======RPCS3 Instructions======\n   1. Launch the game and close it once it's running.\n   " +
                        "2. Open the RPCS3.log file in your RPCS3 directory with a text editor.\n   3. Use CTRL+F to search for " +
                        "\"PPU executable hash\".\n   4. Copy and paste the value starting with \"PPU-\" into this program's " +
                        $"\"{lbl_CRC.Text.TrimEnd(':')}\" field before patching.");
                    break;
                default:
                    break;
            }
        }

        private void FPKG_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText($"======{lbl_FPKG.Text.TrimEnd(':')}======\n\nAn FPKG is a \"fakesigned\" PKG file, which is used to install fanmade, " +
                "repackaged content (homebrew, mods, etc.) on Sony consoles." +
                "\n   1. A console capable of running HEN is required.\n" +
                "\n   2. In order to install game mods on PS4, a fake update must be generated containing the modded content." +
                "\n   3. Fake updates MUST be generated from the same base game FPKG installed on the PS4. You cannot use a retail disc or PSN download due to these limitations." +
                "\n\nPlease provide the path to your Base Game FPKG in order to generate the modded update PKG.");
        }

        private void EBOOT_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText($"======{lbl_Eboot.Text.TrimEnd(':')}======\nThe path to the game's extracted, decrypted executable file.\n\n");
            switch(selectedPlatform.ShortName)
            {
                case "PS2":
                    txt_Desc.AppendText($"======CONSOLE======\nIf you leave the \"{lbl_CRC.Text.TrimEnd(':')}\" field blank, it will be assumed you want a rebuilt ISO (for use on both consoles and emulators)." +
                        "\nThe ISO will be extracted and the executable will be patched with the selected patches." +
                        "\nAdd a shortcut to UltraISO Premium and the ISO will automatically be re-generated after patching, otherwise you will have to do so manually." +
                        "\n\n======EMULATOR======\nIf you entered a CRC, it will be assumed that you are emulating the game with PCSX2. " +
                        "\nIn this case, only the executable will be extracted to the directory containing the ISO. " +
                        "\nYou'll need this later to launch the game with patches.");
                    break;
                case "PS3":
                    txt_Desc.AppendText("======CONSOLE======\nYou only need to provide a path to the EBOOT.BIN if you are modding the game on console. This is what patches will be applied to." +
                        "\n\n======EMULATOR======\nIf you are emulating the game on RPCS3, leave this blank. A patch.yml file will be output instead for use with the emulator.");
                    break;
                case "PSP":
                    txt_Desc.AppendText("======CONSOLE======\nYou only need to provide a path to the EBOOT.BIN if you are modding the game on console and can't use cheats. " +
                        "This is what patches will be applied to." +
                        "\n\n======EMULATOR======\nIf you are emulating the game on PPSSPP, or on a console that can use cheats, leave this blank. " +
                        "A .ini file will be output instead.");
                    break;
                default:
                    txt_Desc.AppendText("This is what the patches will be applied to. Steps on deriving this file vary by platform, " +
                        "so check the game's page on the Amicitia Wiki for more details.");
                    break;
            }
        }

        private void Patches_MouseEnter(object sender, EventArgs e)
        {
            txt_Desc.Clear();
            txt_Desc.AppendText("Click on the name of a patch to view its description." +
                "\nDouble-click on a patch to toggle it." +
                "\n\nHover over an input field on the left for more information." +
                "\n\nClick \"Generate Patches\" when you're ready. You will be informed of any further install steps.");
        }
    }
}
