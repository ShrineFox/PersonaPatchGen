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

        Platform selectedPlatform = new Platform();
        Game selectedGame = new Game();
        string selectedRegion = "";
        string selectedTarget = "";
        string PPUHash = "";

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
            CreatPage_Welcome();
        }

        private void CreatPage_Welcome()
        {
            rtb_1_Welcome.LoadFile(@"./Forms/Documents/Welcome.rtf");
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

        private void Next_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedIndex += 1;
        }

        private void Platform_Changed(object sender, EventArgs e)
        {

        }

        private void Region_Changed(object sender, EventArgs e)
        {

        }

        private void Game_Changed(object sender, EventArgs e)
        {

        }
    }
}
