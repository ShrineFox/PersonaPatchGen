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
            tlp_Main = new TableLayoutPanel();
            pnl_SideImage = new Panel();
            pnl_Main_Inner = new Panel();
            tlp_Main_Inner = new TableLayoutPanel();
            tlp_Main_Buttons = new TableLayoutPanel();
            btn_Back = new MetroSet_UI.Controls.MetroSetButton();
            btn_Action = new MetroSet_UI.Controls.MetroSetButton();
            btn_Next = new MetroSet_UI.Controls.MetroSetButton();
            tabControl_Main = new ShrineFox.IO.TabControl();
            tabPage_1_Welcome = new TabPage();
            tlp_1_Welcome_Inner = new TableLayoutPanel();
            lbl_Platform = new MetroSet_UI.Controls.MetroSetLabel();
            lbl_Region = new MetroSet_UI.Controls.MetroSetLabel();
            lbl_Game = new MetroSet_UI.Controls.MetroSetLabel();
            comboBox_Game = new MetroSet_UI.Controls.MetroSetComboBox();
            comboBox_Region = new MetroSet_UI.Controls.MetroSetComboBox();
            comboBox_Platform = new MetroSet_UI.Controls.MetroSetComboBox();
            rtb_1_Welcome = new RichTextBox();
            tabPage_2_Updates = new TabPage();
            tlp_2_Updates_Inner = new TableLayoutPanel();
            progressBar_Updates = new ProgressBar();
            rtb_Updates_Log = new RichTextBox();
            rtb_2_Updates = new RichTextBox();
            tabPage_3_Platform = new TabPage();
            tlp_3_Platform_Inner = new TableLayoutPanel();
            tlp_3_Platform_GamePath = new TableLayoutPanel();
            btn_GamePath = new MetroSet_UI.Controls.MetroSetButton();
            txt_GamePath = new MetroSet_UI.Controls.MetroSetTextBox();
            lbl_GamePath = new MetroSet_UI.Controls.MetroSetLabel();
            lbl_TargetPlatform = new MetroSet_UI.Controls.MetroSetLabel();
            rtb_3_Platform = new RichTextBox();
            lbl_ExePath = new MetroSet_UI.Controls.MetroSetLabel();
            tlp_3_Platform_ExePath = new TableLayoutPanel();
            btn_ExePath = new MetroSet_UI.Controls.MetroSetButton();
            txt_ExePath = new MetroSet_UI.Controls.MetroSetTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            radio_Emu = new RadioButton();
            radio_Console = new RadioButton();
            tabPage_4_Patches = new TabPage();
            tlp_4_Patches_Inner = new TableLayoutPanel();
            rtb_Patches_Log = new RichTextBox();
            rtb_4_Patches = new RichTextBox();
            chkListBox_Patches = new CheckedListBox();
            chk_Permutations = new CheckBox();
            tabPage_5_Apply = new TabPage();
            tlp_5_Apply = new TableLayoutPanel();
            darkLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            progressBar_Apply = new ProgressBar();
            rtb_Apply_Log = new RichTextBox();
            rtb_5_Apply = new RichTextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txt_OutputDir = new MetroSet_UI.Controls.MetroSetTextBox();
            chk_Unfakesign = new CheckBox();
            btn_OutputDir = new MetroSet_UI.Controls.MetroSetButton();
            tlp_Main.SuspendLayout();
            pnl_Main_Inner.SuspendLayout();
            tlp_Main_Inner.SuspendLayout();
            tlp_Main_Buttons.SuspendLayout();
            tabControl_Main.SuspendLayout();
            tabPage_1_Welcome.SuspendLayout();
            tlp_1_Welcome_Inner.SuspendLayout();
            tabPage_2_Updates.SuspendLayout();
            tlp_2_Updates_Inner.SuspendLayout();
            tabPage_3_Platform.SuspendLayout();
            tlp_3_Platform_Inner.SuspendLayout();
            tlp_3_Platform_GamePath.SuspendLayout();
            tlp_3_Platform_ExePath.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tabPage_4_Patches.SuspendLayout();
            tlp_4_Patches_Inner.SuspendLayout();
            tabPage_5_Apply.SuspendLayout();
            tlp_5_Apply.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_Main
            // 
            tlp_Main.ColumnCount = 2;
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.59647F));
            tlp_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.40353F));
            tlp_Main.Controls.Add(pnl_SideImage, 0, 0);
            tlp_Main.Controls.Add(pnl_Main_Inner, 1, 0);
            tlp_Main.Dock = DockStyle.Fill;
            tlp_Main.Location = new System.Drawing.Point(2, 0);
            tlp_Main.Margin = new Padding(0);
            tlp_Main.Name = "tlp_Main";
            tlp_Main.RowCount = 1;
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 84.79263F));
            tlp_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 15.20737F));
            tlp_Main.Size = new System.Drawing.Size(908, 489);
            tlp_Main.TabIndex = 3;
            // 
            // pnl_SideImage
            // 
            pnl_SideImage.BackgroundImage = (System.Drawing.Image)resources.GetObject("pnl_SideImage.BackgroundImage");
            pnl_SideImage.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_SideImage.Dock = DockStyle.Fill;
            pnl_SideImage.Location = new System.Drawing.Point(0, 0);
            pnl_SideImage.Margin = new Padding(0);
            pnl_SideImage.Name = "pnl_SideImage";
            pnl_SideImage.Size = new System.Drawing.Size(341, 489);
            pnl_SideImage.TabIndex = 0;
            // 
            // pnl_Main_Inner
            // 
            pnl_Main_Inner.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_Main_Inner.Controls.Add(tlp_Main_Inner);
            pnl_Main_Inner.Location = new System.Drawing.Point(344, 3);
            pnl_Main_Inner.Name = "pnl_Main_Inner";
            pnl_Main_Inner.Size = new System.Drawing.Size(561, 483);
            pnl_Main_Inner.TabIndex = 1;
            // 
            // tlp_Main_Inner
            // 
            tlp_Main_Inner.AutoScroll = true;
            tlp_Main_Inner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_Main_Inner.ColumnCount = 1;
            tlp_Main_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_Main_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_Main_Inner.Controls.Add(tlp_Main_Buttons, 0, 1);
            tlp_Main_Inner.Controls.Add(tabControl_Main, 0, 0);
            tlp_Main_Inner.Dock = DockStyle.Fill;
            tlp_Main_Inner.Location = new System.Drawing.Point(0, 0);
            tlp_Main_Inner.Margin = new Padding(0);
            tlp_Main_Inner.Name = "tlp_Main_Inner";
            tlp_Main_Inner.RowCount = 2;
            tlp_Main_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlp_Main_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_Main_Inner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_Main_Inner.Size = new System.Drawing.Size(561, 483);
            tlp_Main_Inner.TabIndex = 3;
            // 
            // tlp_Main_Buttons
            // 
            tlp_Main_Buttons.ColumnCount = 3;
            tlp_Main_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Main_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_Main_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 148F));
            tlp_Main_Buttons.Controls.Add(btn_Back, 0, 0);
            tlp_Main_Buttons.Controls.Add(btn_Action, 1, 0);
            tlp_Main_Buttons.Controls.Add(btn_Next, 2, 0);
            tlp_Main_Buttons.Dock = DockStyle.Fill;
            tlp_Main_Buttons.Location = new System.Drawing.Point(0, 434);
            tlp_Main_Buttons.Margin = new Padding(0);
            tlp_Main_Buttons.Name = "tlp_Main_Buttons";
            tlp_Main_Buttons.RowCount = 1;
            tlp_Main_Buttons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_Main_Buttons.Size = new System.Drawing.Size(561, 49);
            tlp_Main_Buttons.TabIndex = 3;
            // 
            // btn_Back
            // 
            btn_Back.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Back.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Back.DisabledForeColor = System.Drawing.Color.Gray;
            btn_Back.Dock = DockStyle.Fill;
            btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_Back.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Back.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Back.HoverTextColor = System.Drawing.Color.White;
            btn_Back.IsDerivedStyle = true;
            btn_Back.Location = new System.Drawing.Point(3, 3);
            btn_Back.Name = "btn_Back";
            btn_Back.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Back.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Back.NormalTextColor = System.Drawing.Color.White;
            btn_Back.Padding = new Padding(3);
            btn_Back.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Back.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Back.PressTextColor = System.Drawing.Color.White;
            btn_Back.Size = new System.Drawing.Size(200, 43);
            btn_Back.Style = MetroSet_UI.Enums.Style.Light;
            btn_Back.StyleManager = null;
            btn_Back.TabIndex = 5;
            btn_Back.Text = "< Back";
            btn_Back.ThemeAuthor = "Narwin";
            btn_Back.ThemeName = "MetroLite";
            btn_Back.Visible = false;
            btn_Back.Click += Back_Clicked;
            // 
            // btn_Action
            // 
            btn_Action.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Action.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Action.DisabledForeColor = System.Drawing.Color.Gray;
            btn_Action.Dock = DockStyle.Fill;
            btn_Action.Enabled = false;
            btn_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_Action.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Action.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Action.HoverTextColor = System.Drawing.Color.White;
            btn_Action.IsDerivedStyle = true;
            btn_Action.Location = new System.Drawing.Point(209, 3);
            btn_Action.Name = "btn_Action";
            btn_Action.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Action.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Action.NormalTextColor = System.Drawing.Color.White;
            btn_Action.Padding = new Padding(3);
            btn_Action.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Action.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Action.PressTextColor = System.Drawing.Color.White;
            btn_Action.Size = new System.Drawing.Size(200, 43);
            btn_Action.Style = MetroSet_UI.Enums.Style.Light;
            btn_Action.StyleManager = null;
            btn_Action.TabIndex = 4;
            btn_Action.Text = "Download";
            btn_Action.ThemeAuthor = "Narwin";
            btn_Action.ThemeName = "MetroLite";
            btn_Action.Visible = false;
            btn_Action.Click += Action_Clicked;
            // 
            // btn_Next
            // 
            btn_Next.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Next.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_Next.DisabledForeColor = System.Drawing.Color.Gray;
            btn_Next.Dock = DockStyle.Fill;
            btn_Next.Enabled = false;
            btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_Next.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Next.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_Next.HoverTextColor = System.Drawing.Color.White;
            btn_Next.IsDerivedStyle = true;
            btn_Next.Location = new System.Drawing.Point(415, 3);
            btn_Next.Name = "btn_Next";
            btn_Next.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Next.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_Next.NormalTextColor = System.Drawing.Color.White;
            btn_Next.Padding = new Padding(3);
            btn_Next.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Next.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_Next.PressTextColor = System.Drawing.Color.White;
            btn_Next.Size = new System.Drawing.Size(143, 43);
            btn_Next.Style = MetroSet_UI.Enums.Style.Light;
            btn_Next.StyleManager = null;
            btn_Next.TabIndex = 3;
            btn_Next.Text = "Next >";
            btn_Next.ThemeAuthor = "Narwin";
            btn_Next.ThemeName = "MetroLite";
            btn_Next.Click += Next_Clicked;
            // 
            // tabControl_Main
            // 
            tabControl_Main.Appearance = TabAppearance.FlatButtons;
            tabControl_Main.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            tabControl_Main.Controls.Add(tabPage_1_Welcome);
            tabControl_Main.Controls.Add(tabPage_2_Updates);
            tabControl_Main.Controls.Add(tabPage_3_Platform);
            tabControl_Main.Controls.Add(tabPage_4_Patches);
            tabControl_Main.Controls.Add(tabPage_5_Apply);
            tabControl_Main.Dock = DockStyle.Fill;
            tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            tabControl_Main.Location = new System.Drawing.Point(0, 0);
            tabControl_Main.Margin = new Padding(0);
            tabControl_Main.Name = "tabControl_Main";
            tabControl_Main.SelectedIndex = 0;
            tabControl_Main.SelectedTabColor = System.Drawing.Color.FromArgb(60, 63, 65);
            tabControl_Main.Size = new System.Drawing.Size(561, 434);
            tabControl_Main.TabColor = System.Drawing.Color.FromArgb(60, 63, 65);
            tabControl_Main.TabIndex = 4;
            tabControl_Main.SelectedIndexChanged += MainTab_Changed;
            // 
            // tabPage_1_Welcome
            // 
            tabPage_1_Welcome.Controls.Add(tlp_1_Welcome_Inner);
            tabPage_1_Welcome.Location = new System.Drawing.Point(4, 37);
            tabPage_1_Welcome.Margin = new Padding(0);
            tabPage_1_Welcome.Name = "tabPage_1_Welcome";
            tabPage_1_Welcome.Size = new System.Drawing.Size(553, 393);
            tabPage_1_Welcome.TabIndex = 0;
            tabPage_1_Welcome.Text = "Welcome";
            tabPage_1_Welcome.UseVisualStyleBackColor = true;
            // 
            // tlp_1_Welcome_Inner
            // 
            tlp_1_Welcome_Inner.AutoScroll = true;
            tlp_1_Welcome_Inner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_1_Welcome_Inner.ColumnCount = 2;
            tlp_1_Welcome_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_1_Welcome_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_1_Welcome_Inner.Controls.Add(lbl_Platform, 0, 1);
            tlp_1_Welcome_Inner.Controls.Add(lbl_Region, 0, 2);
            tlp_1_Welcome_Inner.Controls.Add(lbl_Game, 0, 3);
            tlp_1_Welcome_Inner.Controls.Add(comboBox_Game, 1, 3);
            tlp_1_Welcome_Inner.Controls.Add(comboBox_Region, 1, 2);
            tlp_1_Welcome_Inner.Controls.Add(comboBox_Platform, 1, 1);
            tlp_1_Welcome_Inner.Controls.Add(rtb_1_Welcome, 1, 0);
            tlp_1_Welcome_Inner.Dock = DockStyle.Fill;
            tlp_1_Welcome_Inner.Location = new System.Drawing.Point(0, 0);
            tlp_1_Welcome_Inner.Margin = new Padding(0);
            tlp_1_Welcome_Inner.Name = "tlp_1_Welcome_Inner";
            tlp_1_Welcome_Inner.RowCount = 4;
            tlp_1_Welcome_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_1_Welcome_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_1_Welcome_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_1_Welcome_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_1_Welcome_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_1_Welcome_Inner.Size = new System.Drawing.Size(553, 393);
            tlp_1_Welcome_Inner.TabIndex = 3;
            // 
            // lbl_Platform
            // 
            lbl_Platform.Anchor = AnchorStyles.Right;
            lbl_Platform.AutoSize = true;
            lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lbl_Platform.IsDerivedStyle = true;
            lbl_Platform.Location = new System.Drawing.Point(25, 257);
            lbl_Platform.Name = "lbl_Platform";
            lbl_Platform.Size = new System.Drawing.Size(82, 24);
            lbl_Platform.Style = MetroSet_UI.Enums.Style.Light;
            lbl_Platform.StyleManager = null;
            lbl_Platform.TabIndex = 3;
            lbl_Platform.Text = "Platform:";
            lbl_Platform.ThemeAuthor = "Narwin";
            lbl_Platform.ThemeName = "MetroLite";
            // 
            // lbl_Region
            // 
            lbl_Region.Anchor = AnchorStyles.Right;
            lbl_Region.AutoSize = true;
            lbl_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lbl_Region.IsDerivedStyle = true;
            lbl_Region.Location = new System.Drawing.Point(31, 306);
            lbl_Region.Name = "lbl_Region";
            lbl_Region.Size = new System.Drawing.Size(76, 24);
            lbl_Region.Style = MetroSet_UI.Enums.Style.Light;
            lbl_Region.StyleManager = null;
            lbl_Region.TabIndex = 4;
            lbl_Region.Text = "Region:";
            lbl_Region.ThemeAuthor = "Narwin";
            lbl_Region.ThemeName = "MetroLite";
            lbl_Region.Visible = false;
            // 
            // lbl_Game
            // 
            lbl_Game.Anchor = AnchorStyles.Right;
            lbl_Game.AutoSize = true;
            lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lbl_Game.IsDerivedStyle = true;
            lbl_Game.Location = new System.Drawing.Point(41, 356);
            lbl_Game.Name = "lbl_Game";
            lbl_Game.Size = new System.Drawing.Size(66, 24);
            lbl_Game.Style = MetroSet_UI.Enums.Style.Light;
            lbl_Game.StyleManager = null;
            lbl_Game.TabIndex = 5;
            lbl_Game.Text = "Game:";
            lbl_Game.ThemeAuthor = "Narwin";
            lbl_Game.ThemeName = "MetroLite";
            lbl_Game.Visible = false;
            // 
            // comboBox_Game
            // 
            comboBox_Game.AllowDrop = true;
            comboBox_Game.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Game.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Game.BackColor = System.Drawing.Color.Transparent;
            comboBox_Game.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            comboBox_Game.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Game.CausesValidation = false;
            comboBox_Game.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            comboBox_Game.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            comboBox_Game.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            comboBox_Game.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_Game.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            comboBox_Game.FormattingEnabled = true;
            comboBox_Game.IsDerivedStyle = true;
            comboBox_Game.ItemHeight = 20;
            comboBox_Game.Location = new System.Drawing.Point(125, 355);
            comboBox_Game.Margin = new Padding(15, 0, 15, 0);
            comboBox_Game.Name = "comboBox_Game";
            comboBox_Game.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            comboBox_Game.SelectedItemForeColor = System.Drawing.Color.White;
            comboBox_Game.Size = new System.Drawing.Size(413, 26);
            comboBox_Game.Style = MetroSet_UI.Enums.Style.Light;
            comboBox_Game.StyleManager = null;
            comboBox_Game.TabIndex = 6;
            comboBox_Game.ThemeAuthor = "Narwin";
            comboBox_Game.ThemeName = "MetroLite";
            comboBox_Game.Visible = false;
            comboBox_Game.SelectedIndexChanged += Game_Changed;
            // 
            // comboBox_Region
            // 
            comboBox_Region.AllowDrop = true;
            comboBox_Region.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Region.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Region.BackColor = System.Drawing.Color.Transparent;
            comboBox_Region.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            comboBox_Region.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Region.CausesValidation = false;
            comboBox_Region.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            comboBox_Region.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            comboBox_Region.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            comboBox_Region.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            comboBox_Region.FormattingEnabled = true;
            comboBox_Region.IsDerivedStyle = true;
            comboBox_Region.ItemHeight = 20;
            comboBox_Region.Items.AddRange(new object[] { "", "USA", "EUR", "JP" });
            comboBox_Region.Location = new System.Drawing.Point(125, 305);
            comboBox_Region.Margin = new Padding(15, 0, 15, 0);
            comboBox_Region.Name = "comboBox_Region";
            comboBox_Region.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            comboBox_Region.SelectedItemForeColor = System.Drawing.Color.White;
            comboBox_Region.Size = new System.Drawing.Size(413, 26);
            comboBox_Region.Style = MetroSet_UI.Enums.Style.Light;
            comboBox_Region.StyleManager = null;
            comboBox_Region.TabIndex = 7;
            comboBox_Region.ThemeAuthor = "Narwin";
            comboBox_Region.ThemeName = "MetroLite";
            comboBox_Region.Visible = false;
            comboBox_Region.SelectedIndexChanged += Region_Changed;
            // 
            // comboBox_Platform
            // 
            comboBox_Platform.AllowDrop = true;
            comboBox_Platform.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBox_Platform.ArrowColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Platform.BackColor = System.Drawing.Color.Transparent;
            comboBox_Platform.BackgroundColor = System.Drawing.Color.FromArgb(238, 238, 238);
            comboBox_Platform.BorderColor = System.Drawing.Color.FromArgb(150, 150, 150);
            comboBox_Platform.CausesValidation = false;
            comboBox_Platform.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            comboBox_Platform.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            comboBox_Platform.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            comboBox_Platform.DrawMode = DrawMode.OwnerDrawVariable;
            comboBox_Platform.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            comboBox_Platform.FormattingEnabled = true;
            comboBox_Platform.IsDerivedStyle = true;
            comboBox_Platform.ItemHeight = 20;
            comboBox_Platform.Items.AddRange(new object[] { "", "PlayStation 4", "PlayStation 3", "PlayStation 2", "PlayStation Vita", "PlayStation Portable", "Nintendo 3DS" });
            comboBox_Platform.Location = new System.Drawing.Point(125, 256);
            comboBox_Platform.Margin = new Padding(15, 0, 15, 0);
            comboBox_Platform.Name = "comboBox_Platform";
            comboBox_Platform.SelectedItemBackColor = System.Drawing.Color.FromArgb(65, 177, 225);
            comboBox_Platform.SelectedItemForeColor = System.Drawing.Color.White;
            comboBox_Platform.Size = new System.Drawing.Size(413, 26);
            comboBox_Platform.Style = MetroSet_UI.Enums.Style.Light;
            comboBox_Platform.StyleManager = null;
            comboBox_Platform.TabIndex = 8;
            comboBox_Platform.ThemeAuthor = "Narwin";
            comboBox_Platform.ThemeName = "MetroLite";
            comboBox_Platform.SelectedIndexChanged += Platform_Changed;
            // 
            // rtb_1_Welcome
            // 
            rtb_1_Welcome.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_1_Welcome.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            rtb_1_Welcome.BorderStyle = BorderStyle.None;
            rtb_1_Welcome.Cursor = Cursors.IBeam;
            rtb_1_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_1_Welcome.ForeColor = System.Drawing.Color.LightGray;
            rtb_1_Welcome.Location = new System.Drawing.Point(110, 0);
            rtb_1_Welcome.Margin = new Padding(0);
            rtb_1_Welcome.Name = "rtb_1_Welcome";
            rtb_1_Welcome.ReadOnly = true;
            rtb_1_Welcome.Size = new System.Drawing.Size(443, 245);
            rtb_1_Welcome.TabIndex = 1;
            rtb_1_Welcome.Text = "";
            // 
            // tabPage_2_Updates
            // 
            tabPage_2_Updates.Controls.Add(tlp_2_Updates_Inner);
            tabPage_2_Updates.Location = new System.Drawing.Point(4, 31);
            tabPage_2_Updates.Margin = new Padding(0);
            tabPage_2_Updates.Name = "tabPage_2_Updates";
            tabPage_2_Updates.Size = new System.Drawing.Size(553, 399);
            tabPage_2_Updates.TabIndex = 1;
            tabPage_2_Updates.Text = "Updates";
            tabPage_2_Updates.UseVisualStyleBackColor = true;
            // 
            // tlp_2_Updates_Inner
            // 
            tlp_2_Updates_Inner.AutoScroll = true;
            tlp_2_Updates_Inner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_2_Updates_Inner.ColumnCount = 2;
            tlp_2_Updates_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_2_Updates_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_2_Updates_Inner.Controls.Add(progressBar_Updates, 0, 2);
            tlp_2_Updates_Inner.Controls.Add(rtb_Updates_Log, 0, 1);
            tlp_2_Updates_Inner.Controls.Add(rtb_2_Updates, 1, 0);
            tlp_2_Updates_Inner.Dock = DockStyle.Fill;
            tlp_2_Updates_Inner.Location = new System.Drawing.Point(0, 0);
            tlp_2_Updates_Inner.Margin = new Padding(0);
            tlp_2_Updates_Inner.Name = "tlp_2_Updates_Inner";
            tlp_2_Updates_Inner.RowCount = 3;
            tlp_2_Updates_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_2_Updates_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlp_2_Updates_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_2_Updates_Inner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_2_Updates_Inner.Size = new System.Drawing.Size(553, 399);
            tlp_2_Updates_Inner.TabIndex = 4;
            // 
            // progressBar_Updates
            // 
            tlp_2_Updates_Inner.SetColumnSpan(progressBar_Updates, 2);
            progressBar_Updates.Dock = DockStyle.Fill;
            progressBar_Updates.Location = new System.Drawing.Point(3, 361);
            progressBar_Updates.Name = "progressBar_Updates";
            progressBar_Updates.Size = new System.Drawing.Size(547, 35);
            progressBar_Updates.TabIndex = 2;
            // 
            // rtb_Updates_Log
            // 
            rtb_Updates_Log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_Updates_Log.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            rtb_Updates_Log.BorderStyle = BorderStyle.None;
            tlp_2_Updates_Inner.SetColumnSpan(rtb_Updates_Log, 2);
            rtb_Updates_Log.Cursor = Cursors.IBeam;
            rtb_Updates_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_Updates_Log.ForeColor = System.Drawing.Color.LightGray;
            rtb_Updates_Log.HideSelection = false;
            rtb_Updates_Log.Location = new System.Drawing.Point(0, 199);
            rtb_Updates_Log.Margin = new Padding(0);
            rtb_Updates_Log.Name = "rtb_Updates_Log";
            rtb_Updates_Log.ReadOnly = true;
            rtb_Updates_Log.Size = new System.Drawing.Size(553, 159);
            rtb_Updates_Log.TabIndex = 3;
            rtb_Updates_Log.Text = "";
            // 
            // rtb_2_Updates
            // 
            rtb_2_Updates.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_2_Updates.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            rtb_2_Updates.BorderStyle = BorderStyle.None;
            rtb_2_Updates.Cursor = Cursors.IBeam;
            rtb_2_Updates.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_2_Updates.ForeColor = System.Drawing.Color.LightGray;
            rtb_2_Updates.Location = new System.Drawing.Point(110, 0);
            rtb_2_Updates.Margin = new Padding(0);
            rtb_2_Updates.Name = "rtb_2_Updates";
            rtb_2_Updates.ReadOnly = true;
            rtb_2_Updates.Size = new System.Drawing.Size(443, 199);
            rtb_2_Updates.TabIndex = 1;
            rtb_2_Updates.Text = "";
            // 
            // tabPage_3_Platform
            // 
            tabPage_3_Platform.Controls.Add(tlp_3_Platform_Inner);
            tabPage_3_Platform.Location = new System.Drawing.Point(4, 37);
            tabPage_3_Platform.Margin = new Padding(0);
            tabPage_3_Platform.Name = "tabPage_3_Platform";
            tabPage_3_Platform.Size = new System.Drawing.Size(553, 393);
            tabPage_3_Platform.TabIndex = 2;
            tabPage_3_Platform.Text = "Platform";
            tabPage_3_Platform.UseVisualStyleBackColor = true;
            // 
            // tlp_3_Platform_Inner
            // 
            tlp_3_Platform_Inner.AutoScroll = true;
            tlp_3_Platform_Inner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_3_Platform_Inner.ColumnCount = 2;
            tlp_3_Platform_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_3_Platform_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_3_Platform_Inner.Controls.Add(tlp_3_Platform_GamePath, 1, 3);
            tlp_3_Platform_Inner.Controls.Add(lbl_GamePath, 0, 3);
            tlp_3_Platform_Inner.Controls.Add(lbl_TargetPlatform, 0, 1);
            tlp_3_Platform_Inner.Controls.Add(rtb_3_Platform, 1, 0);
            tlp_3_Platform_Inner.Controls.Add(lbl_ExePath, 0, 2);
            tlp_3_Platform_Inner.Controls.Add(tlp_3_Platform_ExePath, 1, 2);
            tlp_3_Platform_Inner.Controls.Add(tableLayoutPanel2, 1, 1);
            tlp_3_Platform_Inner.Dock = DockStyle.Fill;
            tlp_3_Platform_Inner.Location = new System.Drawing.Point(0, 0);
            tlp_3_Platform_Inner.Margin = new Padding(0);
            tlp_3_Platform_Inner.Name = "tlp_3_Platform_Inner";
            tlp_3_Platform_Inner.RowCount = 4;
            tlp_3_Platform_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_3_Platform_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp_3_Platform_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp_3_Platform_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_3_Platform_Inner.Size = new System.Drawing.Size(553, 393);
            tlp_3_Platform_Inner.TabIndex = 3;
            // 
            // tlp_3_Platform_GamePath
            // 
            tlp_3_Platform_GamePath.ColumnCount = 2;
            tlp_3_Platform_GamePath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_3_Platform_GamePath.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlp_3_Platform_GamePath.Controls.Add(btn_GamePath, 0, 0);
            tlp_3_Platform_GamePath.Controls.Add(txt_GamePath, 0, 0);
            tlp_3_Platform_GamePath.Dock = DockStyle.Fill;
            tlp_3_Platform_GamePath.Location = new System.Drawing.Point(110, 312);
            tlp_3_Platform_GamePath.Margin = new Padding(0);
            tlp_3_Platform_GamePath.Name = "tlp_3_Platform_GamePath";
            tlp_3_Platform_GamePath.RowCount = 1;
            tlp_3_Platform_GamePath.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_3_Platform_GamePath.Size = new System.Drawing.Size(443, 81);
            tlp_3_Platform_GamePath.TabIndex = 14;
            tlp_3_Platform_GamePath.Visible = false;
            // 
            // btn_GamePath
            // 
            btn_GamePath.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_GamePath.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_GamePath.DisabledForeColor = System.Drawing.Color.Gray;
            btn_GamePath.Dock = DockStyle.Fill;
            btn_GamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_GamePath.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_GamePath.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_GamePath.HoverTextColor = System.Drawing.Color.White;
            btn_GamePath.IsDerivedStyle = true;
            btn_GamePath.Location = new System.Drawing.Point(365, 26);
            btn_GamePath.Margin = new Padding(10, 26, 10, 26);
            btn_GamePath.Name = "btn_GamePath";
            btn_GamePath.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_GamePath.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_GamePath.NormalTextColor = System.Drawing.Color.White;
            btn_GamePath.Padding = new Padding(5);
            btn_GamePath.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_GamePath.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_GamePath.PressTextColor = System.Drawing.Color.White;
            btn_GamePath.Size = new System.Drawing.Size(68, 29);
            btn_GamePath.Style = MetroSet_UI.Enums.Style.Light;
            btn_GamePath.StyleManager = null;
            btn_GamePath.TabIndex = 13;
            btn_GamePath.Text = "...";
            btn_GamePath.ThemeAuthor = "Narwin";
            btn_GamePath.ThemeName = "MetroLite";
            btn_GamePath.Click += PKGPath_Browse;
            // 
            // txt_GamePath
            // 
            txt_GamePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_GamePath.AutoCompleteCustomSource = null;
            txt_GamePath.AutoCompleteMode = AutoCompleteMode.None;
            txt_GamePath.AutoCompleteSource = AutoCompleteSource.None;
            txt_GamePath.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_GamePath.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_GamePath.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_GamePath.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_GamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_GamePath.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_GamePath.Image = null;
            txt_GamePath.IsDerivedStyle = true;
            txt_GamePath.Lines = null;
            txt_GamePath.Location = new System.Drawing.Point(15, 29);
            txt_GamePath.Margin = new Padding(15, 0, 15, 0);
            txt_GamePath.MaxLength = 32767;
            txt_GamePath.Multiline = false;
            txt_GamePath.Name = "txt_GamePath";
            txt_GamePath.ReadOnly = false;
            txt_GamePath.Size = new System.Drawing.Size(325, 22);
            txt_GamePath.Style = MetroSet_UI.Enums.Style.Light;
            txt_GamePath.StyleManager = null;
            txt_GamePath.TabIndex = 12;
            txt_GamePath.TextAlign = HorizontalAlignment.Left;
            txt_GamePath.ThemeAuthor = "Narwin";
            txt_GamePath.ThemeName = "MetroLite";
            txt_GamePath.UseSystemPasswordChar = false;
            txt_GamePath.WatermarkText = "";
            txt_GamePath.TextChanged += Path_TextChanged;
            // 
            // lbl_GamePath
            // 
            lbl_GamePath.AutoSize = true;
            lbl_GamePath.Dock = DockStyle.Fill;
            lbl_GamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            lbl_GamePath.IsDerivedStyle = true;
            lbl_GamePath.Location = new System.Drawing.Point(3, 312);
            lbl_GamePath.Name = "lbl_GamePath";
            lbl_GamePath.Size = new System.Drawing.Size(104, 81);
            lbl_GamePath.Style = MetroSet_UI.Enums.Style.Light;
            lbl_GamePath.StyleManager = null;
            lbl_GamePath.TabIndex = 13;
            lbl_GamePath.Text = "Base Game FPKG Path:";
            lbl_GamePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbl_GamePath.ThemeAuthor = "Narwin";
            lbl_GamePath.ThemeName = "MetroLite";
            lbl_GamePath.Visible = false;
            // 
            // lbl_TargetPlatform
            // 
            lbl_TargetPlatform.Anchor = AnchorStyles.Right;
            lbl_TargetPlatform.AutoSize = true;
            lbl_TargetPlatform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lbl_TargetPlatform.IsDerivedStyle = true;
            lbl_TargetPlatform.Location = new System.Drawing.Point(25, 201);
            lbl_TargetPlatform.Name = "lbl_TargetPlatform";
            lbl_TargetPlatform.Size = new System.Drawing.Size(82, 48);
            lbl_TargetPlatform.Style = MetroSet_UI.Enums.Style.Light;
            lbl_TargetPlatform.StyleManager = null;
            lbl_TargetPlatform.TabIndex = 3;
            lbl_TargetPlatform.Text = "Target Platform:";
            lbl_TargetPlatform.TextAlign = System.Drawing.ContentAlignment.TopRight;
            lbl_TargetPlatform.ThemeAuthor = "Narwin";
            lbl_TargetPlatform.ThemeName = "MetroLite";
            // 
            // rtb_3_Platform
            // 
            rtb_3_Platform.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_3_Platform.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            rtb_3_Platform.BorderStyle = BorderStyle.None;
            rtb_3_Platform.Cursor = Cursors.IBeam;
            rtb_3_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_3_Platform.ForeColor = System.Drawing.Color.LightGray;
            rtb_3_Platform.Location = new System.Drawing.Point(110, 0);
            rtb_3_Platform.Margin = new Padding(0);
            rtb_3_Platform.Name = "rtb_3_Platform";
            rtb_3_Platform.ReadOnly = true;
            rtb_3_Platform.Size = new System.Drawing.Size(443, 196);
            rtb_3_Platform.TabIndex = 1;
            rtb_3_Platform.Text = "";
            // 
            // lbl_ExePath
            // 
            lbl_ExePath.Anchor = AnchorStyles.Right;
            lbl_ExePath.AutoSize = true;
            lbl_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            lbl_ExePath.IsDerivedStyle = true;
            lbl_ExePath.Location = new System.Drawing.Point(16, 259);
            lbl_ExePath.Name = "lbl_ExePath";
            lbl_ExePath.Size = new System.Drawing.Size(91, 48);
            lbl_ExePath.Style = MetroSet_UI.Enums.Style.Light;
            lbl_ExePath.StyleManager = null;
            lbl_ExePath.TabIndex = 10;
            lbl_ExePath.Text = "Emulator Exe Path:";
            lbl_ExePath.TextAlign = System.Drawing.ContentAlignment.TopRight;
            lbl_ExePath.ThemeAuthor = "Narwin";
            lbl_ExePath.ThemeName = "MetroLite";
            lbl_ExePath.Visible = false;
            // 
            // tlp_3_Platform_ExePath
            // 
            tlp_3_Platform_ExePath.ColumnCount = 2;
            tlp_3_Platform_ExePath.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp_3_Platform_ExePath.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            tlp_3_Platform_ExePath.Controls.Add(btn_ExePath, 0, 0);
            tlp_3_Platform_ExePath.Controls.Add(txt_ExePath, 0, 0);
            tlp_3_Platform_ExePath.Dock = DockStyle.Fill;
            tlp_3_Platform_ExePath.Location = new System.Drawing.Point(110, 254);
            tlp_3_Platform_ExePath.Margin = new Padding(0);
            tlp_3_Platform_ExePath.Name = "tlp_3_Platform_ExePath";
            tlp_3_Platform_ExePath.RowCount = 1;
            tlp_3_Platform_ExePath.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_3_Platform_ExePath.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlp_3_Platform_ExePath.Size = new System.Drawing.Size(443, 58);
            tlp_3_Platform_ExePath.TabIndex = 11;
            tlp_3_Platform_ExePath.Visible = false;
            // 
            // btn_ExePath
            // 
            btn_ExePath.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_ExePath.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_ExePath.DisabledForeColor = System.Drawing.Color.Gray;
            btn_ExePath.Dock = DockStyle.Fill;
            btn_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_ExePath.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_ExePath.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_ExePath.HoverTextColor = System.Drawing.Color.White;
            btn_ExePath.IsDerivedStyle = true;
            btn_ExePath.Location = new System.Drawing.Point(365, 16);
            btn_ExePath.Margin = new Padding(10, 16, 10, 16);
            btn_ExePath.Name = "btn_ExePath";
            btn_ExePath.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_ExePath.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_ExePath.NormalTextColor = System.Drawing.Color.White;
            btn_ExePath.Padding = new Padding(5);
            btn_ExePath.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_ExePath.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_ExePath.PressTextColor = System.Drawing.Color.White;
            btn_ExePath.Size = new System.Drawing.Size(68, 26);
            btn_ExePath.Style = MetroSet_UI.Enums.Style.Light;
            btn_ExePath.StyleManager = null;
            btn_ExePath.TabIndex = 13;
            btn_ExePath.Text = "...";
            btn_ExePath.ThemeAuthor = "Narwin";
            btn_ExePath.ThemeName = "MetroLite";
            btn_ExePath.Click += ExePath_Browse;
            // 
            // txt_ExePath
            // 
            txt_ExePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_ExePath.AutoCompleteCustomSource = null;
            txt_ExePath.AutoCompleteMode = AutoCompleteMode.None;
            txt_ExePath.AutoCompleteSource = AutoCompleteSource.None;
            txt_ExePath.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_ExePath.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_ExePath.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_ExePath.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_ExePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_ExePath.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_ExePath.Image = null;
            txt_ExePath.IsDerivedStyle = true;
            txt_ExePath.Lines = null;
            txt_ExePath.Location = new System.Drawing.Point(15, 18);
            txt_ExePath.Margin = new Padding(15, 0, 15, 0);
            txt_ExePath.MaxLength = 32767;
            txt_ExePath.Multiline = false;
            txt_ExePath.Name = "txt_ExePath";
            txt_ExePath.ReadOnly = false;
            txt_ExePath.Size = new System.Drawing.Size(325, 22);
            txt_ExePath.Style = MetroSet_UI.Enums.Style.Light;
            txt_ExePath.StyleManager = null;
            txt_ExePath.TabIndex = 12;
            txt_ExePath.TextAlign = HorizontalAlignment.Left;
            txt_ExePath.ThemeAuthor = "Narwin";
            txt_ExePath.ThemeName = "MetroLite";
            txt_ExePath.UseSystemPasswordChar = false;
            txt_ExePath.WatermarkText = "";
            txt_ExePath.TextChanged += Path_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4382F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.5618F));
            tableLayoutPanel2.Controls.Add(radio_Emu, 1, 0);
            tableLayoutPanel2.Controls.Add(radio_Console, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(110, 196);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(443, 58);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // radio_Emu
            // 
            radio_Emu.AutoSize = true;
            radio_Emu.Dock = DockStyle.Left;
            radio_Emu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            radio_Emu.Location = new System.Drawing.Point(133, 3);
            radio_Emu.Name = "radio_Emu";
            radio_Emu.Size = new System.Drawing.Size(110, 52);
            radio_Emu.TabIndex = 1;
            radio_Emu.Text = "Emulator";
            radio_Emu.CheckedChanged += Checked_Changed;
            // 
            // radio_Console
            // 
            radio_Console.AutoSize = true;
            radio_Console.Checked = true;
            radio_Console.Dock = DockStyle.Right;
            radio_Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            radio_Console.Location = new System.Drawing.Point(21, 3);
            radio_Console.Name = "radio_Console";
            radio_Console.Size = new System.Drawing.Size(106, 52);
            radio_Console.TabIndex = 0;
            radio_Console.TabStop = true;
            radio_Console.Text = "Console";
            radio_Console.CheckedChanged += Checked_Changed;
            // 
            // tabPage_4_Patches
            // 
            tabPage_4_Patches.Controls.Add(tlp_4_Patches_Inner);
            tabPage_4_Patches.Location = new System.Drawing.Point(4, 31);
            tabPage_4_Patches.Margin = new Padding(0);
            tabPage_4_Patches.Name = "tabPage_4_Patches";
            tabPage_4_Patches.Size = new System.Drawing.Size(553, 399);
            tabPage_4_Patches.TabIndex = 3;
            tabPage_4_Patches.Text = "Patches";
            tabPage_4_Patches.UseVisualStyleBackColor = true;
            // 
            // tlp_4_Patches_Inner
            // 
            tlp_4_Patches_Inner.AutoScroll = true;
            tlp_4_Patches_Inner.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_4_Patches_Inner.ColumnCount = 2;
            tlp_4_Patches_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_4_Patches_Inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_4_Patches_Inner.Controls.Add(rtb_Patches_Log, 0, 2);
            tlp_4_Patches_Inner.Controls.Add(rtb_4_Patches, 1, 0);
            tlp_4_Patches_Inner.Controls.Add(chkListBox_Patches, 1, 1);
            tlp_4_Patches_Inner.Controls.Add(chk_Permutations, 0, 1);
            tlp_4_Patches_Inner.Dock = DockStyle.Fill;
            tlp_4_Patches_Inner.Location = new System.Drawing.Point(0, 0);
            tlp_4_Patches_Inner.Margin = new Padding(0);
            tlp_4_Patches_Inner.Name = "tlp_4_Patches_Inner";
            tlp_4_Patches_Inner.RowCount = 3;
            tlp_4_Patches_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_4_Patches_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_4_Patches_Inner.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_4_Patches_Inner.Size = new System.Drawing.Size(553, 399);
            tlp_4_Patches_Inner.TabIndex = 4;
            // 
            // rtb_Patches_Log
            // 
            rtb_Patches_Log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_Patches_Log.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            rtb_Patches_Log.BorderStyle = BorderStyle.None;
            tlp_4_Patches_Inner.SetColumnSpan(rtb_Patches_Log, 2);
            rtb_Patches_Log.Cursor = Cursors.IBeam;
            rtb_Patches_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            rtb_Patches_Log.ForeColor = System.Drawing.Color.LightGray;
            rtb_Patches_Log.Location = new System.Drawing.Point(0, 298);
            rtb_Patches_Log.Margin = new Padding(0);
            rtb_Patches_Log.Name = "rtb_Patches_Log";
            rtb_Patches_Log.ReadOnly = true;
            rtb_Patches_Log.Size = new System.Drawing.Size(553, 101);
            rtb_Patches_Log.TabIndex = 4;
            rtb_Patches_Log.Text = "";
            // 
            // rtb_4_Patches
            // 
            rtb_4_Patches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_4_Patches.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            rtb_4_Patches.BorderStyle = BorderStyle.None;
            rtb_4_Patches.Cursor = Cursors.IBeam;
            rtb_4_Patches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_4_Patches.ForeColor = System.Drawing.Color.LightGray;
            rtb_4_Patches.Location = new System.Drawing.Point(110, 0);
            rtb_4_Patches.Margin = new Padding(0);
            rtb_4_Patches.Name = "rtb_4_Patches";
            rtb_4_Patches.ReadOnly = true;
            rtb_4_Patches.Size = new System.Drawing.Size(443, 99);
            rtb_4_Patches.TabIndex = 1;
            rtb_4_Patches.Text = "";
            // 
            // chkListBox_Patches
            // 
            chkListBox_Patches.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            chkListBox_Patches.BorderStyle = BorderStyle.None;
            chkListBox_Patches.Dock = DockStyle.Fill;
            chkListBox_Patches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            chkListBox_Patches.ForeColor = System.Drawing.Color.Silver;
            chkListBox_Patches.FormattingEnabled = true;
            chkListBox_Patches.Location = new System.Drawing.Point(113, 102);
            chkListBox_Patches.Name = "chkListBox_Patches";
            chkListBox_Patches.Size = new System.Drawing.Size(437, 193);
            chkListBox_Patches.TabIndex = 5;
            chkListBox_Patches.SelectedIndexChanged += SelectedPatch_Changed;
            // 
            // chk_Permutations
            // 
            chk_Permutations.Anchor = AnchorStyles.Bottom;
            chk_Permutations.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            chk_Permutations.Location = new System.Drawing.Point(0, 248);
            chk_Permutations.Margin = new Padding(0);
            chk_Permutations.Name = "chk_Permutations";
            chk_Permutations.Size = new System.Drawing.Size(110, 50);
            chk_Permutations.TabIndex = 6;
            chk_Permutations.Text = "Generate All Combinations";
            chk_Permutations.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            chk_Permutations.UseVisualStyleBackColor = true;
            chk_Permutations.Visible = false;
            // 
            // tabPage_5_Apply
            // 
            tabPage_5_Apply.Controls.Add(tlp_5_Apply);
            tabPage_5_Apply.Location = new System.Drawing.Point(4, 31);
            tabPage_5_Apply.Margin = new Padding(0);
            tabPage_5_Apply.Name = "tabPage_5_Apply";
            tabPage_5_Apply.Size = new System.Drawing.Size(553, 399);
            tabPage_5_Apply.TabIndex = 4;
            tabPage_5_Apply.Text = "Apply";
            tabPage_5_Apply.UseVisualStyleBackColor = true;
            // 
            // tlp_5_Apply
            // 
            tlp_5_Apply.AutoScroll = true;
            tlp_5_Apply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_5_Apply.ColumnCount = 2;
            tlp_5_Apply.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp_5_Apply.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp_5_Apply.Controls.Add(darkLabel1, 0, 1);
            tlp_5_Apply.Controls.Add(progressBar_Apply, 0, 3);
            tlp_5_Apply.Controls.Add(rtb_Apply_Log, 0, 2);
            tlp_5_Apply.Controls.Add(rtb_5_Apply, 1, 0);
            tlp_5_Apply.Controls.Add(tableLayoutPanel1, 1, 1);
            tlp_5_Apply.Dock = DockStyle.Fill;
            tlp_5_Apply.Location = new System.Drawing.Point(0, 0);
            tlp_5_Apply.Margin = new Padding(0);
            tlp_5_Apply.Name = "tlp_5_Apply";
            tlp_5_Apply.RowCount = 4;
            tlp_5_Apply.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp_5_Apply.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp_5_Apply.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlp_5_Apply.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp_5_Apply.Size = new System.Drawing.Size(553, 399);
            tlp_5_Apply.TabIndex = 5;
            // 
            // darkLabel1
            // 
            darkLabel1.Dock = DockStyle.Fill;
            darkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            darkLabel1.IsDerivedStyle = true;
            darkLabel1.Location = new System.Drawing.Point(3, 99);
            darkLabel1.Name = "darkLabel1";
            darkLabel1.Size = new System.Drawing.Size(104, 79);
            darkLabel1.Style = MetroSet_UI.Enums.Style.Light;
            darkLabel1.StyleManager = null;
            darkLabel1.TabIndex = 14;
            darkLabel1.Text = "Output Folder:";
            darkLabel1.ThemeAuthor = "Narwin";
            darkLabel1.ThemeName = "MetroLite";
            // 
            // progressBar_Apply
            // 
            tlp_5_Apply.SetColumnSpan(progressBar_Apply, 2);
            progressBar_Apply.Dock = DockStyle.Fill;
            progressBar_Apply.Location = new System.Drawing.Point(3, 360);
            progressBar_Apply.Name = "progressBar_Apply";
            progressBar_Apply.Size = new System.Drawing.Size(547, 36);
            progressBar_Apply.TabIndex = 2;
            // 
            // rtb_Apply_Log
            // 
            rtb_Apply_Log.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_Apply_Log.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            rtb_Apply_Log.BorderStyle = BorderStyle.None;
            tlp_5_Apply.SetColumnSpan(rtb_Apply_Log, 2);
            rtb_Apply_Log.Cursor = Cursors.IBeam;
            rtb_Apply_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_Apply_Log.ForeColor = System.Drawing.Color.LightGray;
            rtb_Apply_Log.Location = new System.Drawing.Point(0, 178);
            rtb_Apply_Log.Margin = new Padding(0);
            rtb_Apply_Log.Name = "rtb_Apply_Log";
            rtb_Apply_Log.ReadOnly = true;
            rtb_Apply_Log.Size = new System.Drawing.Size(553, 179);
            rtb_Apply_Log.TabIndex = 3;
            rtb_Apply_Log.Text = "";
            // 
            // rtb_5_Apply
            // 
            rtb_5_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb_5_Apply.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            rtb_5_Apply.BorderStyle = BorderStyle.None;
            rtb_5_Apply.Cursor = Cursors.IBeam;
            rtb_5_Apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rtb_5_Apply.ForeColor = System.Drawing.Color.LightGray;
            rtb_5_Apply.Location = new System.Drawing.Point(110, 0);
            rtb_5_Apply.Margin = new Padding(0);
            rtb_5_Apply.Name = "rtb_5_Apply";
            rtb_5_Apply.ReadOnly = true;
            rtb_5_Apply.Size = new System.Drawing.Size(443, 99);
            rtb_5_Apply.TabIndex = 1;
            rtb_5_Apply.Text = "";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 62F));
            tableLayoutPanel1.Controls.Add(txt_OutputDir, 0, 0);
            tableLayoutPanel1.Controls.Add(chk_Unfakesign, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_OutputDir, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(110, 99);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.Size = new System.Drawing.Size(443, 79);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // txt_OutputDir
            // 
            txt_OutputDir.AutoCompleteCustomSource = null;
            txt_OutputDir.AutoCompleteMode = AutoCompleteMode.None;
            txt_OutputDir.AutoCompleteSource = AutoCompleteSource.None;
            txt_OutputDir.BorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_OutputDir.DisabledBackColor = System.Drawing.Color.FromArgb(204, 204, 204);
            txt_OutputDir.DisabledBorderColor = System.Drawing.Color.FromArgb(155, 155, 155);
            txt_OutputDir.DisabledForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            txt_OutputDir.Dock = DockStyle.Fill;
            txt_OutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            txt_OutputDir.HoverColor = System.Drawing.Color.FromArgb(102, 102, 102);
            txt_OutputDir.Image = null;
            txt_OutputDir.IsDerivedStyle = true;
            txt_OutputDir.Lines = null;
            txt_OutputDir.Location = new System.Drawing.Point(15, 0);
            txt_OutputDir.Margin = new Padding(15, 0, 15, 0);
            txt_OutputDir.MaxLength = 32767;
            txt_OutputDir.Multiline = false;
            txt_OutputDir.Name = "txt_OutputDir";
            txt_OutputDir.ReadOnly = false;
            txt_OutputDir.Size = new System.Drawing.Size(351, 40);
            txt_OutputDir.Style = MetroSet_UI.Enums.Style.Light;
            txt_OutputDir.StyleManager = null;
            txt_OutputDir.TabIndex = 12;
            txt_OutputDir.Text = ".\\Output";
            txt_OutputDir.TextAlign = HorizontalAlignment.Left;
            txt_OutputDir.ThemeAuthor = "Narwin";
            txt_OutputDir.ThemeName = "MetroLite";
            txt_OutputDir.UseSystemPasswordChar = false;
            txt_OutputDir.WatermarkText = "";
            // 
            // chk_Unfakesign
            // 
            chk_Unfakesign.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chk_Unfakesign.AutoSize = true;
            chk_Unfakesign.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            chk_Unfakesign.Checked = true;
            chk_Unfakesign.CheckState = CheckState.Checked;
            chk_Unfakesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            chk_Unfakesign.Location = new System.Drawing.Point(216, 40);
            chk_Unfakesign.Margin = new Padding(0);
            chk_Unfakesign.Name = "chk_Unfakesign";
            chk_Unfakesign.Size = new System.Drawing.Size(165, 38);
            chk_Unfakesign.TabIndex = 14;
            chk_Unfakesign.Text = "Un-fakesign the EBOOT";
            // 
            // btn_OutputDir
            // 
            btn_OutputDir.DisabledBackColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_OutputDir.DisabledBorderColor = System.Drawing.Color.FromArgb(120, 65, 177, 225);
            btn_OutputDir.DisabledForeColor = System.Drawing.Color.Gray;
            btn_OutputDir.Dock = DockStyle.Fill;
            btn_OutputDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            btn_OutputDir.HoverBorderColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_OutputDir.HoverColor = System.Drawing.Color.FromArgb(95, 207, 255);
            btn_OutputDir.HoverTextColor = System.Drawing.Color.White;
            btn_OutputDir.IsDerivedStyle = true;
            btn_OutputDir.Location = new System.Drawing.Point(381, 8);
            btn_OutputDir.Margin = new Padding(0, 8, 0, 8);
            btn_OutputDir.Name = "btn_OutputDir";
            btn_OutputDir.NormalBorderColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_OutputDir.NormalColor = System.Drawing.Color.FromArgb(65, 177, 225);
            btn_OutputDir.NormalTextColor = System.Drawing.Color.White;
            btn_OutputDir.Padding = new Padding(5);
            btn_OutputDir.PressBorderColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_OutputDir.PressColor = System.Drawing.Color.FromArgb(35, 147, 195);
            btn_OutputDir.PressTextColor = System.Drawing.Color.White;
            btn_OutputDir.Size = new System.Drawing.Size(62, 24);
            btn_OutputDir.Style = MetroSet_UI.Enums.Style.Light;
            btn_OutputDir.StyleManager = null;
            btn_OutputDir.TabIndex = 13;
            btn_OutputDir.Text = "...";
            btn_OutputDir.ThemeAuthor = "Narwin";
            btn_OutputDir.ThemeName = "MetroLite";
            btn_OutputDir.Click += OutputDir_Click;
            // 
            // WizardForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            ClientSize = new System.Drawing.Size(912, 491);
            Controls.Add(tlp_Main);
            DropShadowEffect = false;
            FormBorderStyle = FormBorderStyle.Sizable;
            HeaderHeight = -40;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(930, 538);
            Name = "WizardForm";
            Opacity = 0.99D;
            Padding = new Padding(2, 0, 2, 2);
            ShowHeader = true;
            ShowLeftRect = false;
            SizeGripStyle = SizeGripStyle.Hide;
            Style = MetroSet_UI.Enums.Style.Dark;
            Text = "PersonaPatcher";
            ThemeName = "MetroDark";
            tlp_Main.ResumeLayout(false);
            pnl_Main_Inner.ResumeLayout(false);
            tlp_Main_Inner.ResumeLayout(false);
            tlp_Main_Buttons.ResumeLayout(false);
            tabControl_Main.ResumeLayout(false);
            tabPage_1_Welcome.ResumeLayout(false);
            tlp_1_Welcome_Inner.ResumeLayout(false);
            tlp_1_Welcome_Inner.PerformLayout();
            tabPage_2_Updates.ResumeLayout(false);
            tlp_2_Updates_Inner.ResumeLayout(false);
            tabPage_3_Platform.ResumeLayout(false);
            tlp_3_Platform_Inner.ResumeLayout(false);
            tlp_3_Platform_Inner.PerformLayout();
            tlp_3_Platform_GamePath.ResumeLayout(false);
            tlp_3_Platform_ExePath.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tabPage_4_Patches.ResumeLayout(false);
            tlp_4_Patches_Inner.ResumeLayout(false);
            tabPage_5_Apply.ResumeLayout(false);
            tlp_5_Apply.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private Panel pnl_SideImage;
        private Panel pnl_Main_Inner;
        private TableLayoutPanel tlp_Main_Inner;
        private TableLayoutPanel tlp_Main_Buttons;
        private MetroSet_UI.Controls.MetroSetButton btn_Back;
        private MetroSet_UI.Controls.MetroSetButton btn_Action;
        private MetroSet_UI.Controls.MetroSetButton btn_Next;
        private ShrineFox.IO.TabControl tabControl_Main;
        private TabPage tabPage_1_Welcome;
        private TabPage tabPage_2_Updates;
        private TabPage tabPage_3_Platform;
        private TabPage tabPage_4_Patches;
        private TableLayoutPanel tlp_1_Welcome_Inner;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Platform;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Region;
        private MetroSet_UI.Controls.MetroSetLabel lbl_Game;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Game;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Region;
        private MetroSet_UI.Controls.MetroSetComboBox comboBox_Platform;
        private RichTextBox rtb_1_Welcome;
        private TableLayoutPanel tlp_3_Platform_Inner;
        private MetroSet_UI.Controls.MetroSetLabel lbl_TargetPlatform;
        private RichTextBox rtb_3_Platform;
        private MetroSet_UI.Controls.MetroSetLabel lbl_ExePath;
        private TableLayoutPanel tlp_3_Platform_ExePath;
        private MetroSet_UI.Controls.MetroSetButton btn_ExePath;
        private MetroSet_UI.Controls.MetroSetTextBox txt_ExePath;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton radio_Emu;
        private RadioButton radio_Console;
        private TableLayoutPanel tlp_2_Updates_Inner;
        private RichTextBox rtb_2_Updates;
        private RichTextBox rtb_Updates_Log;
        private ProgressBar progressBar_Updates;
        private TableLayoutPanel tlp_4_Patches_Inner;
        private RichTextBox rtb_4_Patches;
        private RichTextBox rtb_Patches_Log;
        private CheckedListBox chkListBox_Patches;
        private TabPage tabPage_5_Apply;
        private TableLayoutPanel tlp_5_Apply;
        private ProgressBar progressBar_Apply;
        private RichTextBox rtb_Apply_Log;
        private RichTextBox rtb_5_Apply;
        private MetroSet_UI.Controls.MetroSetLabel lbl_GamePath;
        private TableLayoutPanel tlp_3_Platform_GamePath;
        private MetroSet_UI.Controls.MetroSetButton btn_GamePath;
        private MetroSet_UI.Controls.MetroSetTextBox txt_GamePath;
        private CheckBox chk_Permutations;
        private CheckBox chk_Unfakesign;
        private TableLayoutPanel tableLayoutPanel1;
        private MetroSet_UI.Controls.MetroSetButton btn_OutputDir;
        private MetroSet_UI.Controls.MetroSetTextBox txt_OutputDir;
        private MetroSet_UI.Controls.MetroSetLabel darkLabel1;
    }
}

