using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShrineFox.IO;

namespace PersonaPatchGen
{
    public partial class PQNameForm : Form
    {
        public string P3HERO_First { get; private set; } = "";
        public string P3HERO_Last { get; private set; } = "";
        public string P4HERO_First { get; private set; } = "";
        public string P4HERO_Last { get; private set; } = "";
        public string P3PHERO_First { get; private set; } = "";
        public string P3PHERO_Last { get; private set; } = "";
        public string P5HERO_First { get; private set; } = "";
        public string P5HERO_Last { get; private set; } = "";

        private static string txtPath = Path.Combine(Exe.Directory(), "Dependencies/3DS/PQNames.txt");

        public PQNameForm(bool PQ2 = false)
        {
            InitializeComponent();
            LoadUserPreferredNames();
            if (!PQ2)
            {
                txt_P3PHERO_First.Enabled = false;
                txt_P3PHERO_Last.Enabled = false;
                txt_P5HERO_First.Enabled = false;
                txt_P5HERO_Last.Enabled = false;
                groupBox_PQ2Names.Visible = false;
                tlp_PQNames_Main.SetColumnSpan(groupBox_PQNames, 2);
            }
        }

        private void LoadUserPreferredNames()
        {
            if (File.Exists(txtPath))
            {
                string[] lines = File.ReadAllLines(txtPath);
                if (lines.Length >= 8)
                {
                    for (int i = 0; i < 8; i++)
                    {
                        switch (i)
                        {
                            case 0:
                                txt_P3HERO_First.Text = lines[i];
                                break;
                            case 1:
                                txt_P3HERO_Last.Text = lines[i];
                                break;
                            case 2:
                                txt_P4HERO_First.Text = lines[i];
                                break;
                            case 3:
                                txt_P4HERO_Last.Text = lines[i];
                                break;
                            case 4:
                                txt_P3PHERO_First.Text = lines[i];
                                break;
                            case 5:
                                txt_P3PHERO_Last.Text = lines[i];
                                break;
                            case 6:
                                txt_P5HERO_First.Text = lines[i];
                                break;
                            case 7:
                                txt_P5HERO_Last.Text = lines[i];
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
                
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            P3HERO_First = txt_P3HERO_First.Text; P3HERO_Last = txt_P3HERO_Last.Text; 
            P4HERO_First = txt_P4HERO_First.Text; P4HERO_Last = txt_P4HERO_Last.Text;
            P3PHERO_First = txt_P3PHERO_First.Text; P3PHERO_Last = txt_P3PHERO_Last.Text;
            P5HERO_First = txt_P5HERO_First.Text; P5HERO_Last = txt_P5HERO_Last.Text;
            SaveUserPreferredNames();
            this.DialogResult = DialogResult.OK;

        }

        private void SaveUserPreferredNames()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(txt_P3HERO_First.Text); builder.AppendLine(txt_P3HERO_Last.Text);
            builder.AppendLine(txt_P4HERO_First.Text); builder.AppendLine(txt_P4HERO_Last.Text);
            builder.AppendLine(txt_P3PHERO_First.Text); builder.AppendLine(txt_P3PHERO_Last.Text);
            builder.AppendLine(txt_P5HERO_First.Text); builder.AppendLine(txt_P5HERO_Last.Text);
            File.WriteAllText(txtPath, builder.ToString());
        }
    }
}
