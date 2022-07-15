using System.Windows.Forms;

namespace PersonaPatchGen
{
    partial class MainForm
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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar_Main = new System.Windows.Forms.ProgressBar();
            this.tlp_Divider = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_LogPatches = new System.Windows.Forms.TableLayoutPanel();
            this.chkListBox_Patches = new System.Windows.Forms.CheckedListBox();
            this.txt_Log = new System.Windows.Forms.RichTextBox();
            this.tlp_Options = new System.Windows.Forms.TableLayoutPanel();
            this.txtBox_EmuPath = new DarkUI.Controls.DarkTextBox();
            this.lbl_EmuPath = new DarkUI.Controls.DarkLabel();
            this.txtBox_CRC = new DarkUI.Controls.DarkTextBox();
            this.lbl_CRC = new DarkUI.Controls.DarkLabel();
            this.txtBox_FPKG = new DarkUI.Controls.DarkTextBox();
            this.lbl_FPKG = new DarkUI.Controls.DarkLabel();
            this.comboBox_Region = new DarkUI.Controls.DarkComboBox();
            this.lbl_Region = new DarkUI.Controls.DarkLabel();
            this.lbl_Platform = new DarkUI.Controls.DarkLabel();
            this.comboBox_Platform = new DarkUI.Controls.DarkComboBox();
            this.lbl_Game = new DarkUI.Controls.DarkLabel();
            this.comboBox_Game = new DarkUI.Controls.DarkComboBox();
            this.lbl_Eboot = new DarkUI.Controls.DarkLabel();
            this.txtBox_Eboot = new DarkUI.Controls.DarkTextBox();
            this.btn_Generate = new DarkUI.Controls.DarkButton();
            this.chkBox_Permutations = new DarkUI.Controls.DarkCheckBox();
            this.tlp_Main.SuspendLayout();
            this.tlp_Divider.SuspendLayout();
            this.tlp_LogPatches.SuspendLayout();
            this.tlp_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_Main.ColumnCount = 1;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Main.Controls.Add(this.progressBar_Main, 0, 1);
            this.tlp_Main.Controls.Add(this.tlp_Divider, 0, 0);
            this.tlp_Main.Location = new System.Drawing.Point(-5, 1);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Main.Size = new System.Drawing.Size(921, 495);
            this.tlp_Main.TabIndex = 0;
            // 
            // progressBar_Main
            // 
            this.progressBar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.progressBar_Main.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar_Main.Location = new System.Drawing.Point(3, 473);
            this.progressBar_Main.Name = "progressBar_Main";
            this.progressBar_Main.Size = new System.Drawing.Size(915, 19);
            this.progressBar_Main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Main.TabIndex = 0;
            // 
            // tlp_Divider
            // 
            this.tlp_Divider.ColumnCount = 2;
            this.tlp_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Divider.Controls.Add(this.tlp_LogPatches, 1, 0);
            this.tlp_Divider.Controls.Add(this.tlp_Options, 0, 0);
            this.tlp_Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Divider.Location = new System.Drawing.Point(3, 3);
            this.tlp_Divider.Name = "tlp_Divider";
            this.tlp_Divider.RowCount = 1;
            this.tlp_Divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Divider.Size = new System.Drawing.Size(915, 464);
            this.tlp_Divider.TabIndex = 1;
            // 
            // tlp_LogPatches
            // 
            this.tlp_LogPatches.ColumnCount = 1;
            this.tlp_LogPatches.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_LogPatches.Controls.Add(this.chkListBox_Patches, 0, 0);
            this.tlp_LogPatches.Controls.Add(this.txt_Log, 0, 1);
            this.tlp_LogPatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_LogPatches.Location = new System.Drawing.Point(277, 3);
            this.tlp_LogPatches.Name = "tlp_LogPatches";
            this.tlp_LogPatches.RowCount = 2;
            this.tlp_LogPatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlp_LogPatches.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlp_LogPatches.Size = new System.Drawing.Size(635, 458);
            this.tlp_LogPatches.TabIndex = 0;
            // 
            // chkListBox_Patches
            // 
            this.chkListBox_Patches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.chkListBox_Patches.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkListBox_Patches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkListBox_Patches.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkListBox_Patches.FormattingEnabled = true;
            this.chkListBox_Patches.HorizontalScrollbar = true;
            this.chkListBox_Patches.Location = new System.Drawing.Point(3, 3);
            this.chkListBox_Patches.Name = "chkListBox_Patches";
            this.chkListBox_Patches.Size = new System.Drawing.Size(629, 291);
            this.chkListBox_Patches.TabIndex = 0;
            this.chkListBox_Patches.SelectedIndexChanged += new System.EventHandler(this.SelectedPatch_Changed);
            // 
            // txt_Log
            // 
            this.txt_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txt_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Log.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Log.Location = new System.Drawing.Point(3, 300);
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.ReadOnly = true;
            this.txt_Log.Size = new System.Drawing.Size(629, 155);
            this.txt_Log.TabIndex = 1;
            this.txt_Log.Text = "";
            // 
            // tlp_Options
            // 
            this.tlp_Options.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tlp_Options.ColumnCount = 2;
            this.tlp_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_Options.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp_Options.Controls.Add(this.txtBox_EmuPath, 1, 6);
            this.tlp_Options.Controls.Add(this.lbl_EmuPath, 0, 6);
            this.tlp_Options.Controls.Add(this.txtBox_CRC, 1, 5);
            this.tlp_Options.Controls.Add(this.lbl_CRC, 0, 5);
            this.tlp_Options.Controls.Add(this.txtBox_FPKG, 1, 4);
            this.tlp_Options.Controls.Add(this.lbl_FPKG, 0, 4);
            this.tlp_Options.Controls.Add(this.comboBox_Region, 1, 1);
            this.tlp_Options.Controls.Add(this.lbl_Region, 0, 1);
            this.tlp_Options.Controls.Add(this.lbl_Platform, 0, 0);
            this.tlp_Options.Controls.Add(this.comboBox_Platform, 1, 0);
            this.tlp_Options.Controls.Add(this.lbl_Game, 0, 2);
            this.tlp_Options.Controls.Add(this.comboBox_Game, 1, 2);
            this.tlp_Options.Controls.Add(this.lbl_Eboot, 0, 3);
            this.tlp_Options.Controls.Add(this.txtBox_Eboot, 1, 3);
            this.tlp_Options.Controls.Add(this.btn_Generate, 1, 7);
            this.tlp_Options.Controls.Add(this.chkBox_Permutations, 0, 7);
            this.tlp_Options.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Options.Location = new System.Drawing.Point(3, 3);
            this.tlp_Options.Name = "tlp_Options";
            this.tlp_Options.RowCount = 8;
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62626F));
            this.tlp_Options.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.12121F));
            this.tlp_Options.Size = new System.Drawing.Size(268, 458);
            this.tlp_Options.TabIndex = 1;
            // 
            // txtBox_EmuPath
            // 
            this.txtBox_EmuPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_EmuPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_EmuPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_EmuPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_EmuPath.Location = new System.Drawing.Point(83, 357);
            this.txtBox_EmuPath.Name = "txtBox_EmuPath";
            this.txtBox_EmuPath.ReadOnly = true;
            this.txtBox_EmuPath.Size = new System.Drawing.Size(182, 22);
            this.txtBox_EmuPath.TabIndex = 13;
            this.txtBox_EmuPath.Visible = false;
            // 
            // lbl_EmuPath
            // 
            this.lbl_EmuPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_EmuPath.AutoSize = true;
            this.lbl_EmuPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_EmuPath.Location = new System.Drawing.Point(6, 351);
            this.lbl_EmuPath.Name = "lbl_EmuPath";
            this.lbl_EmuPath.Size = new System.Drawing.Size(71, 34);
            this.lbl_EmuPath.TabIndex = 12;
            this.lbl_EmuPath.Text = "Emulator .exe Path:";
            this.lbl_EmuPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_EmuPath.Visible = false;
            // 
            // txtBox_CRC
            // 
            this.txtBox_CRC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_CRC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_CRC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_CRC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_CRC.Location = new System.Drawing.Point(83, 301);
            this.txtBox_CRC.Name = "txtBox_CRC";
            this.txtBox_CRC.Size = new System.Drawing.Size(182, 22);
            this.txtBox_CRC.TabIndex = 11;
            this.txtBox_CRC.Visible = false;
            // 
            // lbl_CRC
            // 
            this.lbl_CRC.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_CRC.AutoSize = true;
            this.lbl_CRC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_CRC.Location = new System.Drawing.Point(27, 295);
            this.lbl_CRC.Name = "lbl_CRC";
            this.lbl_CRC.Size = new System.Drawing.Size(50, 34);
            this.lbl_CRC.TabIndex = 10;
            this.lbl_CRC.Text = "Game CRC:";
            this.lbl_CRC.Visible = false;
            // 
            // txtBox_FPKG
            // 
            this.txtBox_FPKG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_FPKG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_FPKG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_FPKG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_FPKG.Location = new System.Drawing.Point(83, 245);
            this.txtBox_FPKG.Name = "txtBox_FPKG";
            this.txtBox_FPKG.ReadOnly = true;
            this.txtBox_FPKG.Size = new System.Drawing.Size(182, 22);
            this.txtBox_FPKG.TabIndex = 9;
            this.txtBox_FPKG.Visible = false;
            // 
            // lbl_FPKG
            // 
            this.lbl_FPKG.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_FPKG.AutoSize = true;
            this.lbl_FPKG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_FPKG.Location = new System.Drawing.Point(28, 239);
            this.lbl_FPKG.Name = "lbl_FPKG";
            this.lbl_FPKG.Size = new System.Drawing.Size(49, 34);
            this.lbl_FPKG.TabIndex = 8;
            this.lbl_FPKG.Text = "Base FPKG:";
            this.lbl_FPKG.Visible = false;
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Region.Enabled = false;
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Items.AddRange(new object[] {
            "",
            "USA",
            "EUR"});
            this.comboBox_Region.Location = new System.Drawing.Point(83, 74);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(182, 23);
            this.comboBox_Region.TabIndex = 3;
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.Region_Changed);
            // 
            // lbl_Region
            // 
            this.lbl_Region.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Region.Location = new System.Drawing.Point(20, 77);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(57, 17);
            this.lbl_Region.TabIndex = 2;
            this.lbl_Region.Text = "Region:";
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Platform.Location = new System.Drawing.Point(13, 20);
            this.lbl_Platform.Name = "lbl_Platform";
            this.lbl_Platform.Size = new System.Drawing.Size(64, 17);
            this.lbl_Platform.TabIndex = 0;
            this.lbl_Platform.Text = "Platform:";
            // 
            // comboBox_Platform
            // 
            this.comboBox_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Platform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Platform.FormattingEnabled = true;
            this.comboBox_Platform.Items.AddRange(new object[] {
            "",
            "PlayStation 4",
            "PlayStation 3",
            "PlayStation 2",
            "PlayStation Vita",
            "PlayStation Portable",
            "Nintendo 3DS"});
            this.comboBox_Platform.Location = new System.Drawing.Point(83, 17);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(182, 23);
            this.comboBox_Platform.TabIndex = 1;
            this.comboBox_Platform.SelectedIndexChanged += new System.EventHandler(this.Platform_Changed);
            // 
            // lbl_Game
            // 
            this.lbl_Game.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Game.Location = new System.Drawing.Point(27, 134);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(50, 17);
            this.lbl_Game.TabIndex = 4;
            this.lbl_Game.Text = "Game:";
            // 
            // comboBox_Game
            // 
            this.comboBox_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Game.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Game.Enabled = false;
            this.comboBox_Game.FormattingEnabled = true;
            this.comboBox_Game.Location = new System.Drawing.Point(83, 131);
            this.comboBox_Game.Name = "comboBox_Game";
            this.comboBox_Game.Size = new System.Drawing.Size(182, 23);
            this.comboBox_Game.TabIndex = 5;
            this.comboBox_Game.SelectedIndexChanged += new System.EventHandler(this.Game_Changed);
            // 
            // lbl_Eboot
            // 
            this.lbl_Eboot.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Eboot.AutoSize = true;
            this.lbl_Eboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Eboot.Location = new System.Drawing.Point(16, 191);
            this.lbl_Eboot.Name = "lbl_Eboot";
            this.lbl_Eboot.Size = new System.Drawing.Size(61, 17);
            this.lbl_Eboot.TabIndex = 6;
            this.lbl_Eboot.Text = "EBOOT:";
            this.lbl_Eboot.Visible = false;
            // 
            // txtBox_Eboot
            // 
            this.txtBox_Eboot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Eboot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtBox_Eboot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBox_Eboot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtBox_Eboot.Location = new System.Drawing.Point(83, 188);
            this.txtBox_Eboot.Name = "txtBox_Eboot";
            this.txtBox_Eboot.ReadOnly = true;
            this.txtBox_Eboot.Size = new System.Drawing.Size(182, 22);
            this.txtBox_Eboot.TabIndex = 7;
            this.txtBox_Eboot.Visible = false;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Generate.Enabled = false;
            this.btn_Generate.Location = new System.Drawing.Point(83, 400);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Generate.Size = new System.Drawing.Size(182, 55);
            this.btn_Generate.TabIndex = 14;
            this.btn_Generate.Text = "Generate Patches";
            // 
            // chkBox_Permutations
            // 
            this.chkBox_Permutations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBox_Permutations.AutoSize = true;
            this.chkBox_Permutations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.chkBox_Permutations.Location = new System.Drawing.Point(3, 400);
            this.chkBox_Permutations.Name = "chkBox_Permutations";
            this.chkBox_Permutations.Size = new System.Drawing.Size(74, 55);
            this.chkBox_Permutations.TabIndex = 15;
            this.chkBox_Permutations.Text = "Generate All Combos";
            this.chkBox_Permutations.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.tlp_Main);
            this.MinimumSize = new System.Drawing.Size(930, 540);
            this.Name = "MainForm";
            this.Text = "Persona Patch Generator";
            this.tlp_Main.ResumeLayout(false);
            this.tlp_Divider.ResumeLayout(false);
            this.tlp_LogPatches.ResumeLayout(false);
            this.tlp_Options.ResumeLayout(false);
            this.tlp_Options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private ProgressBar progressBar_Main;
        private TableLayoutPanel tlp_Divider;
        private TableLayoutPanel tlp_LogPatches;
        private TableLayoutPanel tlp_Options;
        private DarkUI.Controls.DarkLabel lbl_Platform;
        private DarkUI.Controls.DarkComboBox comboBox_Platform;
        private CheckedListBox chkListBox_Patches;
        private RichTextBox txt_Log;
        private DarkUI.Controls.DarkComboBox comboBox_Region;
        private DarkUI.Controls.DarkLabel lbl_Region;
        private DarkUI.Controls.DarkLabel lbl_Game;
        private DarkUI.Controls.DarkComboBox comboBox_Game;
        private DarkUI.Controls.DarkLabel lbl_Eboot;
        private DarkUI.Controls.DarkTextBox txtBox_Eboot;
        private DarkUI.Controls.DarkLabel lbl_FPKG;
        private DarkUI.Controls.DarkTextBox txtBox_FPKG;
        private DarkUI.Controls.DarkLabel lbl_CRC;
        private DarkUI.Controls.DarkTextBox txtBox_CRC;
        private DarkUI.Controls.DarkLabel lbl_EmuPath;
        private DarkUI.Controls.DarkTextBox txtBox_EmuPath;
        private DarkUI.Controls.DarkButton btn_Generate;
        private DarkUI.Controls.DarkCheckBox chkBox_Permutations;
    }
}

