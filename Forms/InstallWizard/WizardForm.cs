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
using ShrineFox.IO;
using PersonaGameLib;
using MetroSet_UI.Forms;

namespace PersonaPatchGen
{
    public partial class WizardForm : MetroSetForm
    {
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
