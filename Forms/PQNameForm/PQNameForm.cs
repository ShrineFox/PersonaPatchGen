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

namespace PersonaPatchGen
{
    public partial class PQNameForm : DarkForm
    {
        public string P3HERO { get; private set; } = "";
        public string P4HERO { get; private set; } = "";
        public string P3PHERO { get; private set; } = "";
        public string P5HERO { get; private set; } = "";

        public PQNameForm()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            P3HERO = txt_P3HERO.Text; P4HERO = txt_P4HERO.Text;
            P3PHERO = txt_P3PHERO.Text; P5HERO = txt_P5HERO.Text;
        }
    }
}
