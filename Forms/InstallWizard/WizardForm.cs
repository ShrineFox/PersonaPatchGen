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
using PersonaPatchGen;

namespace PersonaPatchGen
{
    public partial class WizardForm : DarkForm
    {
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

        // Prevent users navigating TabControl via Ctrl+Tab and Ctrl+Shift+Tab.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (System.Convert.ToBoolean(keyData & Keys.Tab | Keys.Control))
                return true;

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
