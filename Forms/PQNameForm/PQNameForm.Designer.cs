using DarkUI.Forms;

namespace PersonaPatchGen.Forms.PQNameForm
{
    partial class PQNameForm : DarkForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PQNameForm));
            this.tlp_PQNames_Main = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Confirm = new DarkUI.Controls.DarkButton();
            this.groupBox_PQNames = new System.Windows.Forms.GroupBox();
            this.groupBox_PQ2Names = new System.Windows.Forms.GroupBox();
            this.tlp_PQ1_Names = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_P3HERO = new DarkUI.Controls.DarkLabel();
            this.lbl_P4HERO = new DarkUI.Controls.DarkLabel();
            this.txt_P3HERO = new DarkUI.Controls.DarkTextBox();
            this.txt_P4HERO = new DarkUI.Controls.DarkTextBox();
            this.tlp_PQ2_Names = new System.Windows.Forms.TableLayoutPanel();
            this.txt_P5HERO = new DarkUI.Controls.DarkTextBox();
            this.lbl_P3PHERO = new DarkUI.Controls.DarkLabel();
            this.lbl_P5HERO = new DarkUI.Controls.DarkLabel();
            this.txt_P3PHERO = new DarkUI.Controls.DarkTextBox();
            this.tlp_PQNames_Main.SuspendLayout();
            this.groupBox_PQNames.SuspendLayout();
            this.groupBox_PQ2Names.SuspendLayout();
            this.tlp_PQ1_Names.SuspendLayout();
            this.tlp_PQ2_Names.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_PQNames_Main
            // 
            this.tlp_PQNames_Main.ColumnCount = 2;
            this.tlp_PQNames_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQNames_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQNames_Main.Controls.Add(this.groupBox_PQ2Names, 1, 0);
            this.tlp_PQNames_Main.Controls.Add(this.btn_Confirm, 1, 1);
            this.tlp_PQNames_Main.Controls.Add(this.groupBox_PQNames, 0, 0);
            this.tlp_PQNames_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PQNames_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_PQNames_Main.Name = "tlp_PQNames_Main";
            this.tlp_PQNames_Main.RowCount = 2;
            this.tlp_PQNames_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_PQNames_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_PQNames_Main.Size = new System.Drawing.Size(446, 220);
            this.tlp_PQNames_Main.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(226, 190);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Confirm.Size = new System.Drawing.Size(217, 27);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm Names";
            this.btn_Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // groupBox_PQNames
            // 
            this.groupBox_PQNames.Controls.Add(this.tlp_PQ1_Names);
            this.groupBox_PQNames.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_PQNames.Location = new System.Drawing.Point(3, 3);
            this.groupBox_PQNames.Name = "groupBox_PQNames";
            this.groupBox_PQNames.Size = new System.Drawing.Size(217, 181);
            this.groupBox_PQNames.TabIndex = 1;
            this.groupBox_PQNames.TabStop = false;
            this.groupBox_PQNames.Text = "Persona Q1+2";
            // 
            // groupBox_PQ2Names
            // 
            this.groupBox_PQ2Names.Controls.Add(this.tlp_PQ2_Names);
            this.groupBox_PQ2Names.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_PQ2Names.Location = new System.Drawing.Point(226, 3);
            this.groupBox_PQ2Names.Name = "groupBox_PQ2Names";
            this.groupBox_PQ2Names.Size = new System.Drawing.Size(217, 181);
            this.groupBox_PQ2Names.TabIndex = 2;
            this.groupBox_PQ2Names.TabStop = false;
            this.groupBox_PQ2Names.Text = "Persona Q2";
            // 
            // tlp_PQ1_Names
            // 
            this.tlp_PQ1_Names.ColumnCount = 2;
            this.tlp_PQ1_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlp_PQ1_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlp_PQ1_Names.Controls.Add(this.txt_P4HERO, 1, 1);
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P3HERO, 0, 0);
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P4HERO, 0, 1);
            this.tlp_PQ1_Names.Controls.Add(this.txt_P3HERO, 1, 0);
            this.tlp_PQ1_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PQ1_Names.Location = new System.Drawing.Point(3, 18);
            this.tlp_PQ1_Names.Name = "tlp_PQ1_Names";
            this.tlp_PQ1_Names.RowCount = 2;
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQ1_Names.Size = new System.Drawing.Size(211, 160);
            this.tlp_PQ1_Names.TabIndex = 0;
            // 
            // lbl_P3HERO
            // 
            this.lbl_P3HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3HERO.AutoSize = true;
            this.lbl_P3HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3HERO.Location = new System.Drawing.Point(3, 23);
            this.lbl_P3HERO.Name = "lbl_P3HERO";
            this.lbl_P3HERO.Size = new System.Drawing.Size(53, 34);
            this.lbl_P3HERO.TabIndex = 0;
            this.lbl_P3HERO.Text = "P3 HERO:";
            this.lbl_P3HERO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_P4HERO
            // 
            this.lbl_P4HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P4HERO.AutoSize = true;
            this.lbl_P4HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P4HERO.Location = new System.Drawing.Point(3, 103);
            this.lbl_P4HERO.Name = "lbl_P4HERO";
            this.lbl_P4HERO.Size = new System.Drawing.Size(53, 34);
            this.lbl_P4HERO.TabIndex = 1;
            this.lbl_P4HERO.Text = "P4 HERO:";
            this.lbl_P4HERO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P3HERO
            // 
            this.txt_P3HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3HERO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3HERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3HERO.Location = new System.Drawing.Point(62, 29);
            this.txt_P3HERO.MaxLength = 16;
            this.txt_P3HERO.Name = "txt_P3HERO";
            this.txt_P3HERO.Size = new System.Drawing.Size(146, 22);
            this.txt_P3HERO.TabIndex = 2;
            this.txt_P3HERO.Text = "Makoto Yuki";
            // 
            // txt_P4HERO
            // 
            this.txt_P4HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P4HERO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P4HERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P4HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P4HERO.Location = new System.Drawing.Point(62, 109);
            this.txt_P4HERO.MaxLength = 16;
            this.txt_P4HERO.Name = "txt_P4HERO";
            this.txt_P4HERO.Size = new System.Drawing.Size(146, 22);
            this.txt_P4HERO.TabIndex = 3;
            this.txt_P4HERO.Text = "Yu Narukami";
            // 
            // tlp_PQ2_Names
            // 
            this.tlp_PQ2_Names.ColumnCount = 2;
            this.tlp_PQ2_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlp_PQ2_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlp_PQ2_Names.Controls.Add(this.txt_P5HERO, 1, 1);
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P3PHERO, 0, 0);
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P5HERO, 0, 1);
            this.tlp_PQ2_Names.Controls.Add(this.txt_P3PHERO, 1, 0);
            this.tlp_PQ2_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PQ2_Names.Location = new System.Drawing.Point(3, 18);
            this.tlp_PQ2_Names.Name = "tlp_PQ2_Names";
            this.tlp_PQ2_Names.RowCount = 2;
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_PQ2_Names.Size = new System.Drawing.Size(211, 160);
            this.tlp_PQ2_Names.TabIndex = 1;
            // 
            // txt_P5HERO
            // 
            this.txt_P5HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P5HERO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P5HERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P5HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P5HERO.Location = new System.Drawing.Point(62, 109);
            this.txt_P5HERO.MaxLength = 16;
            this.txt_P5HERO.Name = "txt_P5HERO";
            this.txt_P5HERO.Size = new System.Drawing.Size(146, 22);
            this.txt_P5HERO.TabIndex = 3;
            this.txt_P5HERO.Text = "Ren Amamiya";
            // 
            // lbl_P3PHERO
            // 
            this.lbl_P3PHERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3PHERO.AutoSize = true;
            this.lbl_P3PHERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3PHERO.Location = new System.Drawing.Point(3, 23);
            this.lbl_P3PHERO.Name = "lbl_P3PHERO";
            this.lbl_P3PHERO.Size = new System.Drawing.Size(53, 34);
            this.lbl_P3PHERO.TabIndex = 0;
            this.lbl_P3PHERO.Text = "P3P HERO:";
            this.lbl_P3PHERO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_P5HERO
            // 
            this.lbl_P5HERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P5HERO.AutoSize = true;
            this.lbl_P5HERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P5HERO.Location = new System.Drawing.Point(3, 103);
            this.lbl_P5HERO.Name = "lbl_P5HERO";
            this.lbl_P5HERO.Size = new System.Drawing.Size(53, 34);
            this.lbl_P5HERO.TabIndex = 1;
            this.lbl_P5HERO.Text = "P5 HERO:";
            this.lbl_P5HERO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P3PHERO
            // 
            this.txt_P3PHERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3PHERO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3PHERO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3PHERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3PHERO.Location = new System.Drawing.Point(62, 29);
            this.txt_P3PHERO.MaxLength = 16;
            this.txt_P3PHERO.Name = "txt_P3PHERO";
            this.txt_P3PHERO.Size = new System.Drawing.Size(146, 22);
            this.txt_P3PHERO.TabIndex = 2;
            this.txt_P3PHERO.Text = "Kotone Shiomi";
            // 
            // PQNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 220);
            this.Controls.Add(this.tlp_PQNames_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PQNameForm";
            this.Text = "PQNameForm";
            this.tlp_PQNames_Main.ResumeLayout(false);
            this.groupBox_PQNames.ResumeLayout(false);
            this.groupBox_PQ2Names.ResumeLayout(false);
            this.tlp_PQ1_Names.ResumeLayout(false);
            this.tlp_PQ1_Names.PerformLayout();
            this.tlp_PQ2_Names.ResumeLayout(false);
            this.tlp_PQ2_Names.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_PQNames_Main;
        private DarkUI.Controls.DarkButton btn_Confirm;
        private System.Windows.Forms.GroupBox groupBox_PQNames;
        private System.Windows.Forms.GroupBox groupBox_PQ2Names;
        private System.Windows.Forms.TableLayoutPanel tlp_PQ1_Names;
        private DarkUI.Controls.DarkLabel lbl_P3HERO;
        private DarkUI.Controls.DarkLabel lbl_P4HERO;
        private DarkUI.Controls.DarkTextBox txt_P3HERO;
        private DarkUI.Controls.DarkTextBox txt_P4HERO;
        private System.Windows.Forms.TableLayoutPanel tlp_PQ2_Names;
        private DarkUI.Controls.DarkTextBox txt_P5HERO;
        private DarkUI.Controls.DarkLabel lbl_P3PHERO;
        private DarkUI.Controls.DarkLabel lbl_P5HERO;
        private DarkUI.Controls.DarkTextBox txt_P3PHERO;
    }
}