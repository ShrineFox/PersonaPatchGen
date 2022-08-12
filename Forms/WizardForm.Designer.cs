using System.Windows.Forms;

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
            this.progressBar_Main = new System.Windows.Forms.ProgressBar();
            this.tabControl_Main = new ShrineFox.IO.TabControl();
            this.tabPage_1_Welcome = new System.Windows.Forms.TabPage();
            this.tlp_1_Welcome = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_1_Welcome = new System.Windows.Forms.Panel();
            this.pnl_1_Welcome_Inner = new System.Windows.Forms.Panel();
            this.tlp_1_Welcome_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Next = new DarkUI.Controls.DarkButton();
            this.lbl_Platform = new DarkUI.Controls.DarkLabel();
            this.lbl_Region = new DarkUI.Controls.DarkLabel();
            this.lbl_Game = new DarkUI.Controls.DarkLabel();
            this.comboBox_Game = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Region = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Platform = new DarkUI.Controls.DarkComboBox();
            this.rtb_1_Welcome = new ShrineFox.IO.SFRichTextBox();
            this.tabPage_2_Updates = new System.Windows.Forms.TabPage();
            this.tlp_2_Updates = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_2_Updates = new System.Windows.Forms.Panel();
            this.pnl_2_Updates_Inner = new System.Windows.Forms.Panel();
            this.tlp_2_Updates_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_2_Updates = new ShrineFox.IO.SFRichTextBox();
            this.tlp_2_Updates_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Back_2 = new DarkUI.Controls.DarkButton();
            this.btn_TryAgain_2 = new DarkUI.Controls.DarkButton();
            this.btn_Next_2 = new DarkUI.Controls.DarkButton();
            this.circleBar_Updates = new CircularProgressBar.CircularProgressBar();
            this.tabPage_3_Platform = new System.Windows.Forms.TabPage();
            this.tlp_3_Platform = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_3_Platform = new System.Windows.Forms.Panel();
            this.pnl_3_Platform_Inner = new System.Windows.Forms.Panel();
            this.tlp_3_Platform_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_3_Back = new DarkUI.Controls.DarkButton();
            this.btn_3_Next = new DarkUI.Controls.DarkButton();
            this.lbl_TargetPlatform = new DarkUI.Controls.DarkLabel();
            this.rtb_3_Platform = new ShrineFox.IO.SFRichTextBox();
            this.lbl_ExePath = new DarkUI.Controls.DarkLabel();
            this.tlp_3_Platform_ExePath = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ExePath = new DarkUI.Controls.DarkButton();
            this.txt_ExePath = new DarkUI.Controls.DarkTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radio_Emu = new DarkUI.Controls.DarkRadioButton();
            this.radio_Console = new DarkUI.Controls.DarkRadioButton();
            this.tlp_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_1_Welcome.SuspendLayout();
            this.tlp_1_Welcome.SuspendLayout();
            this.pnl_1_Welcome_Inner.SuspendLayout();
            this.tlp_1_Welcome_Inner.SuspendLayout();
            this.tabPage_2_Updates.SuspendLayout();
            this.tlp_2_Updates.SuspendLayout();
            this.pnl_2_Updates_Inner.SuspendLayout();
            this.tlp_2_Updates_Inner.SuspendLayout();
            this.tlp_2_Updates_Buttons.SuspendLayout();
            this.tabPage_3_Platform.SuspendLayout();
            this.tlp_3_Platform.SuspendLayout();
            this.pnl_3_Platform_Inner.SuspendLayout();
            this.tlp_3_Platform_Inner.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_3_Platform_ExePath.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.tlp_Main.Controls.Add(this.tabControl_Main, 0, 0);
            this.tlp_Main.Location = new System.Drawing.Point(-5, 1);
            this.tlp_Main.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Main.Name = "tlp_Main";
            this.tlp_Main.RowCount = 2;
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlp_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Main.Size = new System.Drawing.Size(921, 495);
            this.tlp_Main.TabIndex = 0;
            // 
            // progressBar_Main
            // 
            this.progressBar_Main.BackColor = System.Drawing.Color.Green;
            this.progressBar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Main.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar_Main.Location = new System.Drawing.Point(0, 470);
            this.progressBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Main.Name = "progressBar_Main";
            this.progressBar_Main.Size = new System.Drawing.Size(921, 25);
            this.progressBar_Main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Main.TabIndex = 0;
            this.progressBar_Main.Visible = false;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Controls.Add(this.tabPage_1_Welcome);
            this.tabControl_Main.Controls.Add(this.tabPage_2_Updates);
            this.tabControl_Main.Controls.Add(this.tabPage_3_Platform);
            this.tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            this.tabControl_Main.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Size = new System.Drawing.Size(915, 464);
            this.tabControl_Main.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.MainTab_Changed);
            // 
            // tabPage_1_Welcome
            // 
            this.tabPage_1_Welcome.Controls.Add(this.tlp_1_Welcome);
            this.tabPage_1_Welcome.Location = new System.Drawing.Point(4, 27);
            this.tabPage_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_1_Welcome.Name = "tabPage_1_Welcome";
            this.tabPage_1_Welcome.Size = new System.Drawing.Size(907, 433);
            this.tabPage_1_Welcome.TabIndex = 0;
            this.tabPage_1_Welcome.Text = "Welcome";
            this.tabPage_1_Welcome.UseVisualStyleBackColor = true;
            // 
            // tlp_1_Welcome
            // 
            this.tlp_1_Welcome.ColumnCount = 2;
            this.tlp_1_Welcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59647F));
            this.tlp_1_Welcome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40353F));
            this.tlp_1_Welcome.Controls.Add(this.pnl_1_Welcome, 0, 0);
            this.tlp_1_Welcome.Controls.Add(this.pnl_1_Welcome_Inner, 1, 0);
            this.tlp_1_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_1_Welcome.Location = new System.Drawing.Point(0, 0);
            this.tlp_1_Welcome.Name = "tlp_1_Welcome";
            this.tlp_1_Welcome.RowCount = 1;
            this.tlp_1_Welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79263F));
            this.tlp_1_Welcome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F));
            this.tlp_1_Welcome.Size = new System.Drawing.Size(907, 433);
            this.tlp_1_Welcome.TabIndex = 0;
            // 
            // pnl_1_Welcome
            // 
            this.pnl_1_Welcome.BackgroundImage = global::PersonaPatchGen.Properties.Resources.Welcome;
            this.pnl_1_Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_1_Welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_1_Welcome.Location = new System.Drawing.Point(3, 3);
            this.pnl_1_Welcome.Name = "pnl_1_Welcome";
            this.pnl_1_Welcome.Size = new System.Drawing.Size(334, 427);
            this.pnl_1_Welcome.TabIndex = 0;
            // 
            // pnl_1_Welcome_Inner
            // 
            this.pnl_1_Welcome_Inner.Controls.Add(this.tlp_1_Welcome_Inner);
            this.pnl_1_Welcome_Inner.Location = new System.Drawing.Point(343, 3);
            this.pnl_1_Welcome_Inner.Name = "pnl_1_Welcome_Inner";
            this.pnl_1_Welcome_Inner.Size = new System.Drawing.Size(560, 427);
            this.pnl_1_Welcome_Inner.TabIndex = 1;
            // 
            // tlp_1_Welcome_Inner
            // 
            this.tlp_1_Welcome_Inner.AutoScroll = true;
            this.tlp_1_Welcome_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_1_Welcome_Inner.ColumnCount = 2;
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_1_Welcome_Inner.Controls.Add(this.btn_Next, 1, 4);
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
            this.tlp_1_Welcome_Inner.RowCount = 5;
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_1_Welcome_Inner.Size = new System.Drawing.Size(560, 427);
            this.tlp_1_Welcome_Inner.TabIndex = 2;
            // 
            // btn_Next
            // 
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Next.Enabled = false;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Next.Location = new System.Drawing.Point(412, 354);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(15);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Next.Size = new System.Drawing.Size(133, 58);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next >";
            this.btn_Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Platform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Platform.Location = new System.Drawing.Point(27, 222);
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
            this.lbl_Region.Location = new System.Drawing.Point(33, 264);
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
            this.lbl_Game.Location = new System.Drawing.Point(43, 306);
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
            this.comboBox_Game.Location = new System.Drawing.Point(127, 303);
            this.comboBox_Game.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Game.Name = "comboBox_Game";
            this.comboBox_Game.Size = new System.Drawing.Size(418, 29);
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
            this.comboBox_Region.Location = new System.Drawing.Point(127, 261);
            this.comboBox_Region.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(418, 29);
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
            this.comboBox_Platform.Location = new System.Drawing.Point(127, 219);
            this.comboBox_Platform.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(418, 29);
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
            this.rtb_1_Welcome.Location = new System.Drawing.Point(112, 0);
            this.rtb_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_1_Welcome.Name = "rtb_1_Welcome";
            this.rtb_1_Welcome.ReadOnly = true;
            this.rtb_1_Welcome.Size = new System.Drawing.Size(448, 213);
            this.rtb_1_Welcome.TabIndex = 1;
            this.rtb_1_Welcome.Text = "";
            // 
            // tabPage_2_Updates
            // 
            this.tabPage_2_Updates.Controls.Add(this.tlp_2_Updates);
            this.tabPage_2_Updates.Location = new System.Drawing.Point(4, 27);
            this.tabPage_2_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_2_Updates.Name = "tabPage_2_Updates";
            this.tabPage_2_Updates.Size = new System.Drawing.Size(907, 433);
            this.tabPage_2_Updates.TabIndex = 1;
            this.tabPage_2_Updates.Text = "Updates";
            this.tabPage_2_Updates.UseVisualStyleBackColor = true;
            // 
            // tlp_2_Updates
            // 
            this.tlp_2_Updates.ColumnCount = 2;
            this.tlp_2_Updates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59647F));
            this.tlp_2_Updates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40353F));
            this.tlp_2_Updates.Controls.Add(this.pnl_2_Updates, 0, 0);
            this.tlp_2_Updates.Controls.Add(this.pnl_2_Updates_Inner, 1, 0);
            this.tlp_2_Updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_2_Updates.Location = new System.Drawing.Point(0, 0);
            this.tlp_2_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_2_Updates.Name = "tlp_2_Updates";
            this.tlp_2_Updates.RowCount = 1;
            this.tlp_2_Updates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79263F));
            this.tlp_2_Updates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F));
            this.tlp_2_Updates.Size = new System.Drawing.Size(907, 433);
            this.tlp_2_Updates.TabIndex = 1;
            // 
            // pnl_2_Updates
            // 
            this.pnl_2_Updates.BackgroundImage = global::PersonaPatchGen.Properties.Resources.Welcome;
            this.pnl_2_Updates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_2_Updates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_2_Updates.Location = new System.Drawing.Point(3, 3);
            this.pnl_2_Updates.Name = "pnl_2_Updates";
            this.pnl_2_Updates.Size = new System.Drawing.Size(334, 427);
            this.pnl_2_Updates.TabIndex = 0;
            // 
            // pnl_2_Updates_Inner
            // 
            this.pnl_2_Updates_Inner.Controls.Add(this.tlp_2_Updates_Inner);
            this.pnl_2_Updates_Inner.Location = new System.Drawing.Point(343, 3);
            this.pnl_2_Updates_Inner.Name = "pnl_2_Updates_Inner";
            this.pnl_2_Updates_Inner.Size = new System.Drawing.Size(557, 421);
            this.pnl_2_Updates_Inner.TabIndex = 1;
            // 
            // tlp_2_Updates_Inner
            // 
            this.tlp_2_Updates_Inner.AutoScroll = true;
            this.tlp_2_Updates_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_2_Updates_Inner.ColumnCount = 2;
            this.tlp_2_Updates_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_2_Updates_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_2_Updates_Inner.Controls.Add(this.rtb_2_Updates, 1, 0);
            this.tlp_2_Updates_Inner.Controls.Add(this.tlp_2_Updates_Buttons, 1, 2);
            this.tlp_2_Updates_Inner.Controls.Add(this.circleBar_Updates, 1, 1);
            this.tlp_2_Updates_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_2_Updates_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_2_Updates_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_2_Updates_Inner.Name = "tlp_2_Updates_Inner";
            this.tlp_2_Updates_Inner.RowCount = 3;
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp_2_Updates_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_2_Updates_Inner.Size = new System.Drawing.Size(557, 421);
            this.tlp_2_Updates_Inner.TabIndex = 2;
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
            this.rtb_2_Updates.HideSelection = false;
            this.rtb_2_Updates.Location = new System.Drawing.Point(111, 0);
            this.rtb_2_Updates.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_2_Updates.Name = "rtb_2_Updates";
            this.rtb_2_Updates.ReadOnly = true;
            this.rtb_2_Updates.Size = new System.Drawing.Size(446, 210);
            this.rtb_2_Updates.TabIndex = 1;
            this.rtb_2_Updates.Text = "";
            // 
            // tlp_2_Updates_Buttons
            // 
            this.tlp_2_Updates_Buttons.ColumnCount = 3;
            this.tlp_2_Updates_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_2_Updates_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_2_Updates_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tlp_2_Updates_Buttons.Controls.Add(this.btn_Back_2, 0, 0);
            this.tlp_2_Updates_Buttons.Controls.Add(this.btn_TryAgain_2, 1, 0);
            this.tlp_2_Updates_Buttons.Controls.Add(this.btn_Next_2, 2, 0);
            this.tlp_2_Updates_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_2_Updates_Buttons.Location = new System.Drawing.Point(111, 336);
            this.tlp_2_Updates_Buttons.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_2_Updates_Buttons.Name = "tlp_2_Updates_Buttons";
            this.tlp_2_Updates_Buttons.RowCount = 1;
            this.tlp_2_Updates_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_2_Updates_Buttons.Size = new System.Drawing.Size(446, 85);
            this.tlp_2_Updates_Buttons.TabIndex = 3;
            // 
            // btn_Back_2
            // 
            this.btn_Back_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Back_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Back_2.Location = new System.Drawing.Point(15, 15);
            this.btn_Back_2.Margin = new System.Windows.Forms.Padding(15);
            this.btn_Back_2.Name = "btn_Back_2";
            this.btn_Back_2.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Back_2.Size = new System.Drawing.Size(123, 55);
            this.btn_Back_2.TabIndex = 5;
            this.btn_Back_2.Text = "< Back";
            this.btn_Back_2.Click += new System.EventHandler(this.Back_Click);
            // 
            // btn_TryAgain_2
            // 
            this.btn_TryAgain_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TryAgain_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_TryAgain_2.Location = new System.Drawing.Point(168, 15);
            this.btn_TryAgain_2.Margin = new System.Windows.Forms.Padding(15);
            this.btn_TryAgain_2.Name = "btn_TryAgain_2";
            this.btn_TryAgain_2.Padding = new System.Windows.Forms.Padding(5);
            this.btn_TryAgain_2.Size = new System.Drawing.Size(123, 55);
            this.btn_TryAgain_2.TabIndex = 4;
            this.btn_TryAgain_2.Text = "Download";
            this.btn_TryAgain_2.Click += new System.EventHandler(this.TryAgain_Click);
            // 
            // btn_Next_2
            // 
            this.btn_Next_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Next_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Next_2.Location = new System.Drawing.Point(321, 15);
            this.btn_Next_2.Margin = new System.Windows.Forms.Padding(15);
            this.btn_Next_2.Name = "btn_Next_2";
            this.btn_Next_2.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Next_2.Size = new System.Drawing.Size(110, 55);
            this.btn_Next_2.TabIndex = 3;
            this.btn_Next_2.Text = "Next >";
            this.btn_Next_2.Click += new System.EventHandler(this.Next_Click);
            // 
            // circleBar_Updates
            // 
            this.circleBar_Updates.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.circleBar_Updates.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleBar_Updates.AnimationSpeed = 500;
            this.circleBar_Updates.BackColor = System.Drawing.Color.Transparent;
            this.circleBar_Updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.circleBar_Updates.ForeColor = System.Drawing.Color.Silver;
            this.circleBar_Updates.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circleBar_Updates.InnerMargin = 2;
            this.circleBar_Updates.InnerWidth = -1;
            this.circleBar_Updates.Location = new System.Drawing.Point(273, 213);
            this.circleBar_Updates.MarqueeAnimationSpeed = 2000;
            this.circleBar_Updates.Name = "circleBar_Updates";
            this.circleBar_Updates.OuterColor = System.Drawing.Color.Gray;
            this.circleBar_Updates.OuterMargin = -25;
            this.circleBar_Updates.OuterWidth = 26;
            this.circleBar_Updates.ProgressColor = System.Drawing.Color.MintCream;
            this.circleBar_Updates.ProgressWidth = 25;
            this.circleBar_Updates.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.circleBar_Updates.Size = new System.Drawing.Size(122, 120);
            this.circleBar_Updates.StartAngle = 270;
            this.circleBar_Updates.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleBar_Updates.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circleBar_Updates.SubscriptText = "";
            this.circleBar_Updates.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circleBar_Updates.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circleBar_Updates.SuperscriptText = "";
            this.circleBar_Updates.TabIndex = 4;
            this.circleBar_Updates.Text = "Ready. . .";
            this.circleBar_Updates.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circleBar_Updates.Value = 1;
            // 
            // tabPage_3_Platform
            // 
            this.tabPage_3_Platform.Controls.Add(this.tlp_3_Platform);
            this.tabPage_3_Platform.Location = new System.Drawing.Point(4, 27);
            this.tabPage_3_Platform.Name = "tabPage_3_Platform";
            this.tabPage_3_Platform.Size = new System.Drawing.Size(907, 433);
            this.tabPage_3_Platform.TabIndex = 2;
            this.tabPage_3_Platform.Text = "Platform";
            this.tabPage_3_Platform.UseVisualStyleBackColor = true;
            // 
            // tlp_3_Platform
            // 
            this.tlp_3_Platform.ColumnCount = 2;
            this.tlp_3_Platform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.59647F));
            this.tlp_3_Platform.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.40353F));
            this.tlp_3_Platform.Controls.Add(this.pnl_3_Platform, 0, 0);
            this.tlp_3_Platform.Controls.Add(this.pnl_3_Platform_Inner, 1, 0);
            this.tlp_3_Platform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_3_Platform.Location = new System.Drawing.Point(0, 0);
            this.tlp_3_Platform.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_3_Platform.Name = "tlp_3_Platform";
            this.tlp_3_Platform.RowCount = 1;
            this.tlp_3_Platform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79263F));
            this.tlp_3_Platform.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20737F));
            this.tlp_3_Platform.Size = new System.Drawing.Size(907, 433);
            this.tlp_3_Platform.TabIndex = 1;
            // 
            // pnl_3_Platform
            // 
            this.pnl_3_Platform.BackgroundImage = global::PersonaPatchGen.Properties.Resources.Welcome;
            this.pnl_3_Platform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_3_Platform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_3_Platform.Location = new System.Drawing.Point(3, 3);
            this.pnl_3_Platform.Name = "pnl_3_Platform";
            this.pnl_3_Platform.Size = new System.Drawing.Size(334, 427);
            this.pnl_3_Platform.TabIndex = 0;
            // 
            // pnl_3_Platform_Inner
            // 
            this.pnl_3_Platform_Inner.Controls.Add(this.tlp_3_Platform_Inner);
            this.pnl_3_Platform_Inner.Location = new System.Drawing.Point(343, 3);
            this.pnl_3_Platform_Inner.Name = "pnl_3_Platform_Inner";
            this.pnl_3_Platform_Inner.Size = new System.Drawing.Size(560, 427);
            this.pnl_3_Platform_Inner.TabIndex = 1;
            // 
            // tlp_3_Platform_Inner
            // 
            this.tlp_3_Platform_Inner.AutoScroll = true;
            this.tlp_3_Platform_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_3_Platform_Inner.ColumnCount = 2;
            this.tlp_3_Platform_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_3_Platform_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp_3_Platform_Inner.Controls.Add(this.tableLayoutPanel1, 1, 3);
            this.tlp_3_Platform_Inner.Controls.Add(this.lbl_TargetPlatform, 0, 1);
            this.tlp_3_Platform_Inner.Controls.Add(this.rtb_3_Platform, 1, 0);
            this.tlp_3_Platform_Inner.Controls.Add(this.lbl_ExePath, 0, 2);
            this.tlp_3_Platform_Inner.Controls.Add(this.tlp_3_Platform_ExePath, 1, 2);
            this.tlp_3_Platform_Inner.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlp_3_Platform_Inner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_3_Platform_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_3_Platform_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_3_Platform_Inner.Name = "tlp_3_Platform_Inner";
            this.tlp_3_Platform_Inner.RowCount = 4;
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_3_Platform_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_3_Platform_Inner.Size = new System.Drawing.Size(560, 427);
            this.tlp_3_Platform_Inner.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.Controls.Add(this.btn_3_Back, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_3_Next, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(112, 341);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(448, 86);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btn_3_Back
            // 
            this.btn_3_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_3_Back.Location = new System.Drawing.Point(15, 15);
            this.btn_3_Back.Margin = new System.Windows.Forms.Padding(15);
            this.btn_3_Back.Name = "btn_3_Back";
            this.btn_3_Back.Padding = new System.Windows.Forms.Padding(5);
            this.btn_3_Back.Size = new System.Drawing.Size(124, 56);
            this.btn_3_Back.TabIndex = 5;
            this.btn_3_Back.Text = "< Back";
            this.btn_3_Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // btn_3_Next
            // 
            this.btn_3_Next.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_3_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_3_Next.Location = new System.Drawing.Point(323, 15);
            this.btn_3_Next.Margin = new System.Windows.Forms.Padding(15);
            this.btn_3_Next.Name = "btn_3_Next";
            this.btn_3_Next.Padding = new System.Windows.Forms.Padding(5);
            this.btn_3_Next.Size = new System.Drawing.Size(110, 56);
            this.btn_3_Next.TabIndex = 3;
            this.btn_3_Next.Text = "Next >";
            this.btn_3_Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // lbl_TargetPlatform
            // 
            this.lbl_TargetPlatform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_TargetPlatform.AutoSize = true;
            this.lbl_TargetPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_TargetPlatform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_TargetPlatform.Location = new System.Drawing.Point(27, 221);
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
            this.rtb_3_Platform.Location = new System.Drawing.Point(112, 0);
            this.rtb_3_Platform.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_3_Platform.Name = "rtb_3_Platform";
            this.rtb_3_Platform.ReadOnly = true;
            this.rtb_3_Platform.Size = new System.Drawing.Size(448, 213);
            this.rtb_3_Platform.TabIndex = 1;
            this.rtb_3_Platform.Text = "";
            // 
            // lbl_ExePath
            // 
            this.lbl_ExePath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_ExePath.AutoSize = true;
            this.lbl_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_ExePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_ExePath.Location = new System.Drawing.Point(18, 285);
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
            this.tlp_3_Platform_ExePath.Location = new System.Drawing.Point(112, 277);
            this.tlp_3_Platform_ExePath.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_3_Platform_ExePath.Name = "tlp_3_Platform_ExePath";
            this.tlp_3_Platform_ExePath.RowCount = 1;
            this.tlp_3_Platform_ExePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_3_Platform_ExePath.Size = new System.Drawing.Size(448, 64);
            this.tlp_3_Platform_ExePath.TabIndex = 11;
            this.tlp_3_Platform_ExePath.Visible = false;
            // 
            // btn_ExePath
            // 
            this.btn_ExePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_ExePath.Location = new System.Drawing.Point(370, 20);
            this.btn_ExePath.Margin = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.btn_ExePath.Name = "btn_ExePath";
            this.btn_ExePath.Padding = new System.Windows.Forms.Padding(5);
            this.btn_ExePath.Size = new System.Drawing.Size(68, 24);
            this.btn_ExePath.TabIndex = 13;
            this.btn_ExePath.Text = "...";
            this.btn_ExePath.Click += new System.EventHandler(this.ExePath_Browse_Click);
            // 
            // txt_ExePath
            // 
            this.txt_ExePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ExePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_ExePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ExePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_ExePath.Location = new System.Drawing.Point(15, 21);
            this.txt_ExePath.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.txt_ExePath.Name = "txt_ExePath";
            this.txt_ExePath.Size = new System.Drawing.Size(330, 22);
            this.txt_ExePath.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radio_Emu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radio_Console, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(114, 213);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(446, 64);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // radio_Emu
            // 
            this.radio_Emu.AutoSize = true;
            this.radio_Emu.Dock = System.Windows.Forms.DockStyle.Left;
            this.radio_Emu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Emu.Location = new System.Drawing.Point(226, 3);
            this.radio_Emu.Name = "radio_Emu";
            this.radio_Emu.Size = new System.Drawing.Size(110, 58);
            this.radio_Emu.TabIndex = 1;
            this.radio_Emu.Text = "Emulator";
            this.radio_Emu.CheckedChanged += new System.EventHandler(this.Console_Checked);
            // 
            // radio_Console
            // 
            this.radio_Console.AutoSize = true;
            this.radio_Console.Checked = true;
            this.radio_Console.Dock = System.Windows.Forms.DockStyle.Right;
            this.radio_Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radio_Console.Location = new System.Drawing.Point(114, 3);
            this.radio_Console.Name = "radio_Console";
            this.radio_Console.Size = new System.Drawing.Size(106, 58);
            this.radio_Console.TabIndex = 0;
            this.radio_Console.TabStop = true;
            this.radio_Console.Text = "Console";
            this.radio_Console.CheckedChanged += new System.EventHandler(this.Console_Checked);
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
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_1_Welcome.ResumeLayout(false);
            this.tlp_1_Welcome.ResumeLayout(false);
            this.pnl_1_Welcome_Inner.ResumeLayout(false);
            this.tlp_1_Welcome_Inner.ResumeLayout(false);
            this.tlp_1_Welcome_Inner.PerformLayout();
            this.tabPage_2_Updates.ResumeLayout(false);
            this.tlp_2_Updates.ResumeLayout(false);
            this.pnl_2_Updates_Inner.ResumeLayout(false);
            this.tlp_2_Updates_Inner.ResumeLayout(false);
            this.tlp_2_Updates_Buttons.ResumeLayout(false);
            this.tabPage_3_Platform.ResumeLayout(false);
            this.tlp_3_Platform.ResumeLayout(false);
            this.pnl_3_Platform_Inner.ResumeLayout(false);
            this.tlp_3_Platform_Inner.ResumeLayout(false);
            this.tlp_3_Platform_Inner.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_3_Platform_ExePath.ResumeLayout(false);
            this.tlp_3_Platform_ExePath.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private ProgressBar progressBar_Main;
        private ShrineFox.IO.TabControl tabControl_Main;
        private TabPage tabPage_1_Welcome;
        private TabPage tabPage_2_Updates;
        private TableLayoutPanel tlp_1_Welcome;
        private Panel pnl_1_Welcome;
        private Panel pnl_1_Welcome_Inner;
        private TableLayoutPanel tlp_1_Welcome_Inner;
        private ShrineFox.IO.SFRichTextBox rtb_1_Welcome;
        private DarkUI.Controls.DarkButton btn_Next;
        private DarkUI.Controls.DarkLabel lbl_Platform;
        private DarkUI.Controls.DarkLabel lbl_Region;
        private DarkUI.Controls.DarkLabel lbl_Game;
        private DarkUI.Controls.DarkComboBox comboBox_Game;
        private DarkUI.Controls.DarkComboBox comboBox_Region;
        private DarkUI.Controls.DarkComboBox comboBox_Platform;
        private TableLayoutPanel tlp_2_Updates;
        private Panel pnl_2_Updates;
        private Panel pnl_2_Updates_Inner;
        private TableLayoutPanel tlp_2_Updates_Inner;
        private ShrineFox.IO.SFRichTextBox rtb_2_Updates;
        private TableLayoutPanel tlp_2_Updates_Buttons;
        private DarkUI.Controls.DarkButton btn_Back_2;
        private DarkUI.Controls.DarkButton btn_TryAgain_2;
        private DarkUI.Controls.DarkButton btn_Next_2;
        private CircularProgressBar.CircularProgressBar circleBar_Updates;
        private TabPage tabPage_3_Platform;
        private TableLayoutPanel tlp_3_Platform;
        private Panel pnl_3_Platform;
        private Panel pnl_3_Platform_Inner;
        private TableLayoutPanel tlp_3_Platform_Inner;
        private DarkUI.Controls.DarkLabel lbl_TargetPlatform;
        private ShrineFox.IO.SFRichTextBox rtb_3_Platform;
        private TableLayoutPanel tableLayoutPanel1;
        private DarkUI.Controls.DarkButton btn_3_Back;
        private DarkUI.Controls.DarkButton btn_3_Next;
        private DarkUI.Controls.DarkLabel lbl_ExePath;
        private TableLayoutPanel tlp_3_Platform_ExePath;
        private DarkUI.Controls.DarkTextBox txt_ExePath;
        private DarkUI.Controls.DarkButton btn_ExePath;
        private TableLayoutPanel tableLayoutPanel2;
        private DarkUI.Controls.DarkRadioButton radio_Console;
        private DarkUI.Controls.DarkRadioButton radio_Emu;
    }
}

