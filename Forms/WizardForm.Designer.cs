﻿using System.Windows.Forms;

namespace PersonaPatchGen
{
    partial class WizardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WizardForm));
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_SideImage = new System.Windows.Forms.Panel();
            this.pnl_Main_Inner = new System.Windows.Forms.Panel();
            this.tlp_Main_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Main_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Back = new DarkUI.Controls.DarkButton();
            this.btn_Action = new DarkUI.Controls.DarkButton();
            this.btn_Next = new DarkUI.Controls.DarkButton();
            this.tabControl_Main = new ShrineFox.IO.TabControl();
            this.tabPage_1_Welcome = new System.Windows.Forms.TabPage();
            this.tlp_1_Welcome_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Platform = new DarkUI.Controls.DarkLabel();
            this.lbl_Region = new DarkUI.Controls.DarkLabel();
            this.lbl_Game = new DarkUI.Controls.DarkLabel();
            this.comboBox_Game = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Region = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Platform = new DarkUI.Controls.DarkComboBox();
            this.rtb_1_Welcome = new ShrineFox.IO.SFRichTextBox();
            this.tabPage_2_Updates = new System.Windows.Forms.TabPage();
            this.tlp_2_Updates_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_2_Updates = new ShrineFox.IO.SFRichTextBox();
            this.tabPage_3_Platform = new System.Windows.Forms.TabPage();
            this.tlp_3_Platform_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_TargetPlatform = new DarkUI.Controls.DarkLabel();
            this.rtb_3_Platform = new ShrineFox.IO.SFRichTextBox();
            this.lbl_ExePath = new DarkUI.Controls.DarkLabel();
            this.tlp_3_Platform_ExePath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExePath = new DarkUI.Controls.DarkButton();
            this.txt_ExePath = new DarkUI.Controls.DarkTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radio_Emu = new DarkUI.Controls.DarkRadioButton();
            this.radio_Console = new DarkUI.Controls.DarkRadioButton();
            this.tabPage_4_Console = new System.Windows.Forms.TabPage();
            this.progressBar_Updates = new System.Windows.Forms.ProgressBar();
            this.rtb_Updates_Log = new ShrineFox.IO.SFRichTextBox();
            this.tlp_Main.SuspendLayout();
            this.pnl_Main_Inner.SuspendLayout();
            this.tlp_Main_Inner.SuspendLayout();
            this.tlp_Main_Buttons.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_1_Welcome.SuspendLayout();
            this.tlp_1_Welcome_Inner.SuspendLayout();
            this.tabPage_2_Updates.SuspendLayout();
            this.tlp_2_Updates_Inner.SuspendLayout();
            this.tabPage_3_Platform.SuspendLayout();
            this.tlp_3_Platform_Inner.SuspendLayout();
            this.tlp_3_Platform_ExePath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Main
            // 
            this.tlp_Main.ColumnCount = 2;
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59647F));
            this.tlp_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40353F));
            this.tlp_Main.Controls.Add(this.pnl_SideImage, 0, 0);
            this.tlp_Main.Controls.Add(this.pnl_Main_Inner, 1, 0);
            this.tlp_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 1;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79263F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F));
            this.tlp_Main.Size = new System.Drawing.Size(912, 493);
            this.tlp_Main.TabIndex = 3;
            // 
            // pnl_SideImage
            // 
            this.pnl_SideImage.BackgroundImage = global::PersonaPatchGen.Properties.Resources.Welcome;
            this.pnl_SideImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_SideImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SideImage.Location = new System.Drawing.Point(3, 3);
            this.pnl_SideImage.Name = "pnl_SideImage";
            this.pnl_SideImage.Size = new System.Drawing.Size(336, 487);
            this.pnl_SideImage.TabIndex = 0;
            // 
            // pnl_Main_Inner
            // 
            this.pnl_Main_Inner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Main_Inner.Controls.Add(this.tlp_Main_Inner);
            this.pnl_Main_Inner.Location = new System.Drawing.Point(345, 3);
            this.pnl_Main_Inner.Name = "pnl_Main_Inner";
            this.pnl_Main_Inner.Size = new System.Drawing.Size(564, 487);
            this.pnl_Main_Inner.TabIndex = 1;
            // 
            // tlp_Main_Inner
            // 
            this.tlp_Main_Inner.AutoScroll = true;
            this.tlp_Main_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_Main_Inner.ColumnCount = 1;
            this.tlp_Main_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Main_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_Main_Inner.Controls.Add(this.tlp_Main_Buttons, 0, 1);
            this.tlp_Main_Inner.Controls.Add(this.tabControl_Main, 0, 0);
            this.tlp_Main_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_Main_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main_Inner.Name = "tlp_Main_Inner";
            this.tlp_Main_Inner.RowCount = 2;
            this.tlp_Main_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlp_Main_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Main_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Main_Inner.Size = new System.Drawing.Size(564, 487);
            this.tlp_Main_Inner.TabIndex = 3;
            // 
            // tlp_Main_Buttons
            // 
            this.tlp_Main_Buttons.ColumnCount = 3;
            this.tlp_Main_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_Main_Buttons.Controls.Add(this.btn_Back, 0, 0);
            this.tlp_Main_Buttons.Controls.Add(this.btn_Action, 1, 0);
            this.tlp_Main_Buttons.Controls.Add(this.btn_Next, 2, 0);
            this.tlp_Main_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Main_Buttons.Location = new System.Drawing.Point(0, 438);
            this.tlp_Main_Buttons.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main_Buttons.Name = "tlp_Main_Buttons";
            this.tlp_Main_Buttons.RowCount = 1;
            this.tlp_Main_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Main_Buttons.Size = new System.Drawing.Size(564, 49);
            this.tlp_Main_Buttons.TabIndex = 3;
            // 
            // btn_Back
            // 
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Back.Location = new System.Drawing.Point(3, 3);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Back.Size = new System.Drawing.Size(206, 43);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "< Back";
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.Back_Clicked);
            // 
            // btn_Action
            // 
            this.btn_Action.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Action.Enabled = false;
            this.btn_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Action.Location = new System.Drawing.Point(215, 3);
            this.btn_Action.Name = "btn_Action";
            this.btn_Action.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Action.Size = new System.Drawing.Size(206, 43);
            this.btn_Action.TabIndex = 4;
            this.btn_Action.Text = "Download";
            this.btn_Action.Visible = false;
            this.btn_Action.Click += new System.EventHandler(this.Action_Clicked);
            // 
            // btn_Next
            // 
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next.Enabled = false;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Next.Location = new System.Drawing.Point(427, 3);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(3);
            this.btn_Next.Size = new System.Drawing.Size(134, 43);
            this.btn_Next.TabIndex = 3;
            this.btn_Next.Text = "Next >";
            this.btn_Next.Click += new System.EventHandler(this.Next_Clicked);
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Controls.Add(this.tabPage_1_Welcome);
            this.tabControl_Main.Controls.Add(this.tabPage_2_Updates);
            this.tabControl_Main.Controls.Add(this.tabPage_3_Platform);
            this.tabControl_Main.Controls.Add(this.tabPage_4_Console);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Size = new System.Drawing.Size(564, 438);
            this.tabControl_Main.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.TabIndex = 4;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.MainTab_Changed);
            // 
            // tabPage_1_Welcome
            // 
            this.tabPage_1_Welcome.Controls.Add(this.tlp_1_Welcome_Inner);
            this.tabPage_1_Welcome.Location = new System.Drawing.Point(4, 27);
            this.tabPage_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_1_Welcome.Name = "tabPage_1_Welcome";
            this.tabPage_1_Welcome.Size = new System.Drawing.Size(556, 407);
            this.tabPage_1_Welcome.TabIndex = 0;
            this.tabPage_1_Welcome.Text = "Welcome";
            this.tabPage_1_Welcome.UseVisualStyleBackColor = true;
            // 
            // tlp_1_Welcome_Inner
            // 
            this.tlp_1_Welcome_Inner.AutoScroll = true;
            this.tlp_1_Welcome_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_1_Welcome_Inner.ColumnCount = 2;
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Platform, 0, 1);
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Region, 0, 2);
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Game, 0, 3);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Game, 1, 3);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Region, 1, 2);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Platform, 1, 1);
            this.tlp_1_Welcome_Inner.Controls.Add(this.rtb_1_Welcome, 1, 0);
            this.tlp_1_Welcome_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_1_Welcome_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_1_Welcome_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_1_Welcome_Inner.Name = "tlp_1_Welcome_Inner";
            this.tlp_1_Welcome_Inner.RowCount = 4;
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_1_Welcome_Inner.Size = new System.Drawing.Size(556, 407);
            this.tlp_1_Welcome_Inner.TabIndex = 3;
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Platform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Platform.Location = new System.Drawing.Point(26, 267);
            this.lbl_Platform.Name = "lbl_Platform";
            this.lbl_Platform.Size = new System.Drawing.Size(82, 24);
            this.lbl_Platform.TabIndex = 3;
            this.lbl_Platform.Text = "Platform:";
            // 
            // lbl_Region
            // 
            this.lbl_Region.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Region.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Region.Location = new System.Drawing.Point(32, 317);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(76, 24);
            this.lbl_Region.TabIndex = 4;
            this.lbl_Region.Text = "Region:";
            this.lbl_Region.Visible = false;
            // 
            // lbl_Game
            // 
            this.lbl_Game.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Game.Location = new System.Drawing.Point(42, 368);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(66, 24);
            this.lbl_Game.TabIndex = 5;
            this.lbl_Game.Text = "Game:";
            this.lbl_Game.Visible = false;
            // 
            // comboBox_Game
            // 
            this.comboBox_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Game.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Game.FormattingEnabled = true;
            this.comboBox_Game.Location = new System.Drawing.Point(126, 366);
            this.comboBox_Game.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Game.Name = "comboBox_Game";
            this.comboBox_Game.Size = new System.Drawing.Size(415, 29);
            this.comboBox_Game.TabIndex = 6;
            this.comboBox_Game.Visible = false;
            this.comboBox_Game.SelectedIndexChanged += new System.EventHandler(this.Game_Changed);
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Items.AddRange(new object[] {
            "",
            "USA",
            "EUR"});
            this.comboBox_Region.Location = new System.Drawing.Point(126, 314);
            this.comboBox_Region.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(415, 29);
            this.comboBox_Region.TabIndex = 7;
            this.comboBox_Region.Visible = false;
            this.comboBox_Region.SelectedIndexChanged += new System.EventHandler(this.Region_Changed);
            // 
            // comboBox_Platform
            // 
            this.comboBox_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Platform.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Platform.FormattingEnabled = true;
            this.comboBox_Platform.Items.AddRange(new object[] {
            "",
            "PlayStation 4",
            "PlayStation 3",
            "PlayStation 2",
            "PlayStation Vita",
            "PlayStation Portable",
            "Nintendo 3DS"});
            this.comboBox_Platform.Location = new System.Drawing.Point(126, 264);
            this.comboBox_Platform.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(415, 29);
            this.comboBox_Platform.TabIndex = 8;
            this.comboBox_Platform.SelectedIndexChanged += new System.EventHandler(this.Platform_Changed);
            // 
            // rtb_1_Welcome
            // 
            this.rtb_1_Welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_1_Welcome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.rtb_1_Welcome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_1_Welcome.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_1_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_1_Welcome.ForeColor = System.Drawing.Color.LightGray;
            this.rtb_1_Welcome.Location = new System.Drawing.Point(111, 0);
            this.rtb_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_1_Welcome.Name = "rtb_1_Welcome";
            this.rtb_1_Welcome.ReadOnly = true;
            this.rtb_1_Welcome.Size = new System.Drawing.Size(445, 254);
            this.rtb_1_Welcome.TabIndex = 1;
            this.rtb_1_Welcome.Text = "";
            // 
            // tabPage_2_Updates
            // 
            this.tabPage_2_Updates.Controls.Add(this.tlp_2_Updates_Inner);
            this.tabPage_2_Updates.Location = new System.Drawing.Point(4, 27);
            this.tabPage_2_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_2_Updates.Name = "tabPage_2_Updates";
            this.tabPage_2_Updates.Size = new System.Drawing.Size(556, 407);
            this.tabPage_2_Updates.TabIndex = 1;
            this.tabPage_2_Updates.Text = "Updates";
            this.tabPage_2_Updates.UseVisualStyleBackColor = true;
            // 
            // tlp_2_Updates_Inner
            // 
            this.tlp_2_Updates_Inner.AutoScroll = true;
            this.tlp_2_Updates_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_2_Updates_Inner.ColumnCount = 2;
            this.tlp_2_Updates_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_2_Updates_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_2_Updates_Inner.Controls.Add(this.progressBar_Updates, 0, 2);
            this.tlp_2_Updates_Inner.Controls.Add(this.rtb_Updates_Log, 0, 1);
            this.tlp_2_Updates_Inner.Controls.Add(this.rtb_2_Updates, 1, 0);
            this.tlp_2_Updates_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_2_Updates_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_2_Updates_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_2_Updates_Inner.Name = "tlp_2_Updates_Inner";
            this.tlp_2_Updates_Inner.RowCount = 3;
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_2_Updates_Inner.Size = new System.Drawing.Size(556, 407);
            this.tlp_2_Updates_Inner.TabIndex = 4;
            // 
            // rtb_2_Updates
            // 
            this.rtb_2_Updates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_2_Updates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.rtb_2_Updates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_2_Updates.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_2_Updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_2_Updates.ForeColor = System.Drawing.Color.LightGray;
            this.rtb_2_Updates.Location = new System.Drawing.Point(111, 0);
            this.rtb_2_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_2_Updates.Name = "rtb_2_Updates";
            this.rtb_2_Updates.ReadOnly = true;
            this.rtb_2_Updates.Size = new System.Drawing.Size(445, 223);
            this.rtb_2_Updates.TabIndex = 1;
            this.rtb_2_Updates.Text = "";
            // 
            // tabPage_3_Platform
            // 
            this.tabPage_3_Platform.Controls.Add(this.tlp_3_Platform_Inner);
            this.tabPage_3_Platform.Location = new System.Drawing.Point(4, 27);
            this.tabPage_3_Platform.Name = "tabPage_3_Platform";
            this.tabPage_3_Platform.Size = new System.Drawing.Size(556, 407);
            this.tabPage_3_Platform.TabIndex = 2;
            this.tabPage_3_Platform.Text = "Platform";
            this.tabPage_3_Platform.UseVisualStyleBackColor = true;
            // 
            // tlp_3_Platform_Inner
            // 
            this.tlp_3_Platform_Inner.AutoScroll = true;
            this.tlp_3_Platform_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_3_Platform_Inner.ColumnCount = 2;
            this.tlp_3_Platform_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_3_Platform_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_3_Platform_Inner.Controls.Add(this.lbl_TargetPlatform, 0, 1);
            this.tlp_3_Platform_Inner.Controls.Add(this.rtb_3_Platform, 1, 0);
            this.tlp_3_Platform_Inner.Controls.Add(this.lbl_ExePath, 0, 2);
            this.tlp_3_Platform_Inner.Controls.Add(this.tlp_3_Platform_ExePath, 1, 2);
            this.tlp_3_Platform_Inner.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlp_3_Platform_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_3_Platform_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_3_Platform_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_3_Platform_Inner.Name = "tlp_3_Platform_Inner";
            this.tlp_3_Platform_Inner.RowCount = 3;
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_3_Platform_Inner.Size = new System.Drawing.Size(556, 407);
            this.tlp_3_Platform_Inner.TabIndex = 3;
            // 
            // lbl_TargetPlatform
            // 
            this.lbl_TargetPlatform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TargetPlatform.AutoSize = true;
            this.lbl_TargetPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_TargetPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TargetPlatform.Location = new System.Drawing.Point(26, 268);
            this.lbl_TargetPlatform.Name = "lbl_TargetPlatform";
            this.lbl_TargetPlatform.Size = new System.Drawing.Size(82, 48);
            this.lbl_TargetPlatform.TabIndex = 3;
            this.lbl_TargetPlatform.Text = "Target Platform:";
            this.lbl_TargetPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rtb_3_Platform
            // 
            this.rtb_3_Platform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_3_Platform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.rtb_3_Platform.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_3_Platform.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_3_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_3_Platform.ForeColor = System.Drawing.Color.LightGray;
            this.rtb_3_Platform.Location = new System.Drawing.Point(111, 0);
            this.rtb_3_Platform.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_3_Platform.Name = "rtb_3_Platform";
            this.rtb_3_Platform.ReadOnly = true;
            this.rtb_3_Platform.Size = new System.Drawing.Size(445, 254);
            this.rtb_3_Platform.TabIndex = 1;
            this.rtb_3_Platform.Text = "";
            // 
            // lbl_ExePath
            // 
            this.lbl_ExePath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ExePath.AutoSize = true;
            this.lbl_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_ExePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ExePath.Location = new System.Drawing.Point(17, 344);
            this.lbl_ExePath.Name = "lbl_ExePath";
            this.lbl_ExePath.Size = new System.Drawing.Size(91, 48);
            this.lbl_ExePath.TabIndex = 10;
            this.lbl_ExePath.Text = "Emulator Exe Path:";
            this.lbl_ExePath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_ExePath.Visible = false;
            // 
            // tlp_3_Platform_ExePath
            // 
            this.tlp_3_Platform_ExePath.ColumnCount = 2;
            this.tlp_3_Platform_ExePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_3_Platform_ExePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlp_3_Platform_ExePath.Controls.Add(this.btn_ExePath, 0, 0);
            this.tlp_3_Platform_ExePath.Controls.Add(this.txt_ExePath, 0, 0);
            this.tlp_3_Platform_ExePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_3_Platform_ExePath.Location = new System.Drawing.Point(111, 330);
            this.tlp_3_Platform_ExePath.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_3_Platform_ExePath.Name = "tlp_3_Platform_ExePath";
            this.tlp_3_Platform_ExePath.RowCount = 1;
            this.tlp_3_Platform_ExePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_3_Platform_ExePath.Size = new System.Drawing.Size(445, 77);
            this.tlp_3_Platform_ExePath.TabIndex = 11;
            this.tlp_3_Platform_ExePath.Visible = false;
            // 
            // btn_ExePath
            // 
            this.btn_ExePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_ExePath.Location = new System.Drawing.Point(367, 20);
            this.btn_ExePath.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btn_ExePath.Name = "btn_ExePath";
            this.btn_ExePath.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ExePath.Size = new System.Drawing.Size(68, 37);
            this.btn_ExePath.TabIndex = 13;
            this.btn_ExePath.Text = "...";
            this.btn_ExePath.Click += new System.EventHandler(this.ExePath_Browse);
            // 
            // txt_ExePath
            // 
            this.txt_ExePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ExePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_ExePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_ExePath.Location = new System.Drawing.Point(15, 27);
            this.txt_ExePath.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txt_ExePath.Name = "txt_ExePath";
            this.txt_ExePath.Size = new System.Drawing.Size(327, 22);
            this.txt_ExePath.TabIndex = 12;
            this.txt_ExePath.TextChanged += new System.EventHandler(this.ExePath_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.4382F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.5618F));
            this.tableLayoutPanel2.Controls.Add(this.radio_Emu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radio_Console, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(111, 254);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(445, 76);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // radio_Emu
            // 
            this.radio_Emu.AutoSize = true;
            this.radio_Emu.Dock = System.Windows.Forms.DockStyle.Left;
            this.radio_Emu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Emu.Location = new System.Drawing.Point(133, 3);
            this.radio_Emu.Name = "radio_Emu";
            this.radio_Emu.Size = new System.Drawing.Size(110, 70);
            this.radio_Emu.TabIndex = 1;
            this.radio_Emu.Text = "Emulator";
            this.radio_Emu.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // radio_Console
            // 
            this.radio_Console.AutoSize = true;
            this.radio_Console.Checked = true;
            this.radio_Console.Dock = System.Windows.Forms.DockStyle.Right;
            this.radio_Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Console.Location = new System.Drawing.Point(21, 3);
            this.radio_Console.Name = "radio_Console";
            this.radio_Console.Size = new System.Drawing.Size(106, 70);
            this.radio_Console.TabIndex = 0;
            this.radio_Console.TabStop = true;
            this.radio_Console.Text = "Console";
            this.radio_Console.CheckedChanged += new System.EventHandler(this.Checked_Changed);
            // 
            // tabPage_4_Console
            // 
            this.tabPage_4_Console.Location = new System.Drawing.Point(4, 27);
            this.tabPage_4_Console.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_4_Console.Name = "tabPage_4_Console";
            this.tabPage_4_Console.Size = new System.Drawing.Size(556, 407);
            this.tabPage_4_Console.TabIndex = 3;
            this.tabPage_4_Console.Text = "Console";
            this.tabPage_4_Console.UseVisualStyleBackColor = true;
            // 
            // progressBar_Updates
            // 
            this.tlp_2_Updates_Inner.SetColumnSpan(this.progressBar_Updates, 2);
            this.progressBar_Updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Updates.Location = new System.Drawing.Point(3, 404);
            this.progressBar_Updates.Name = "progressBar_Updates";
            this.progressBar_Updates.Size = new System.Drawing.Size(550, 40);
            this.progressBar_Updates.TabIndex = 2;
            // 
            // rtb_Updates_Log
            // 
            this.rtb_Updates_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Updates_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rtb_Updates_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlp_2_Updates_Inner.SetColumnSpan(this.rtb_Updates_Log, 2);
            this.rtb_Updates_Log.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtb_Updates_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rtb_Updates_Log.ForeColor = System.Drawing.Color.LightGray;
            this.rtb_Updates_Log.Location = new System.Drawing.Point(0, 223);
            this.rtb_Updates_Log.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Updates_Log.Name = "rtb_Updates_Log";
            this.rtb_Updates_Log.ReadOnly = true;
            this.rtb_Updates_Log.Size = new System.Drawing.Size(556, 178);
            this.rtb_Updates_Log.TabIndex = 3;
            this.rtb_Updates_Log.Text = "";
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.tlp_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(930, 540);
            this.MinimumSize = new System.Drawing.Size(930, 540);
            this.Name = "WizardForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Persona Patcher 2";
            this.tlp_Main.ResumeLayout(false);
            this.pnl_Main_Inner.ResumeLayout(false);
            this.tlp_Main_Inner.ResumeLayout(false);
            this.tlp_Main_Buttons.ResumeLayout(false);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_1_Welcome.ResumeLayout(false);
            this.tlp_1_Welcome_Inner.ResumeLayout(false);
            this.tlp_1_Welcome_Inner.PerformLayout();
            this.tabPage_2_Updates.ResumeLayout(false);
            this.tlp_2_Updates_Inner.ResumeLayout(false);
            this.tabPage_3_Platform.ResumeLayout(false);
            this.tlp_3_Platform_Inner.ResumeLayout(false);
            this.tlp_3_Platform_Inner.PerformLayout();
            this.tlp_3_Platform_ExePath.ResumeLayout(false);
            this.tlp_3_Platform_ExePath.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private Panel pnl_SideImage;
        private Panel pnl_Main_Inner;
        private TableLayoutPanel tlp_Main_Inner;
        private TableLayoutPanel tlp_Main_Buttons;
        private DarkUI.Controls.DarkButton btn_Back;
        private DarkUI.Controls.DarkButton btn_Action;
        private DarkUI.Controls.DarkButton btn_Next;
        private ShrineFox.IO.TabControl tabControl_Main;
        private TabPage tabPage_1_Welcome;
        private TabPage tabPage_2_Updates;
        private TabPage tabPage_3_Platform;
        private TabPage tabPage_4_Console;
        private TableLayoutPanel tlp_1_Welcome_Inner;
        private DarkUI.Controls.DarkLabel lbl_Platform;
        private DarkUI.Controls.DarkLabel lbl_Region;
        private DarkUI.Controls.DarkLabel lbl_Game;
        private DarkUI.Controls.DarkComboBox comboBox_Game;
        private DarkUI.Controls.DarkComboBox comboBox_Region;
        private DarkUI.Controls.DarkComboBox comboBox_Platform;
        private ShrineFox.IO.SFRichTextBox rtb_1_Welcome;
        private TableLayoutPanel tlp_3_Platform_Inner;
        private DarkUI.Controls.DarkLabel lbl_TargetPlatform;
        private ShrineFox.IO.SFRichTextBox rtb_3_Platform;
        private DarkUI.Controls.DarkLabel lbl_ExePath;
        private TableLayoutPanel tlp_3_Platform_ExePath;
        private DarkUI.Controls.DarkButton btn_ExePath;
        private DarkUI.Controls.DarkTextBox txt_ExePath;
        private TableLayoutPanel tableLayoutPanel2;
        private DarkUI.Controls.DarkRadioButton radio_Emu;
        private DarkUI.Controls.DarkRadioButton radio_Console;
        private TableLayoutPanel tlp_2_Updates_Inner;
        private ShrineFox.IO.SFRichTextBox rtb_2_Updates;
        private ShrineFox.IO.SFRichTextBox rtb_Updates_Log;
        private ProgressBar progressBar_Updates;
    }
}

