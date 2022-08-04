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
            this.tlp_Main = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar_Main = new System.Windows.Forms.ProgressBar();
            this.tabControl_Main = new ShrineFox.IO.TabControl();
            this.tabPage_1_Welcome = new System.Windows.Forms.TabPage();
            this.tlp_1_Welcome = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_1_Welcome = new System.Windows.Forms.Panel();
            this.pnl_1_Welcome_Inner = new System.Windows.Forms.Panel();
            this.tlp_1_Welcome_Inner = new System.Windows.Forms.TableLayoutPanel();
            this.rtb_1_Welcome = new ShrineFox.IO.SFRichTextBox();
            this.btn_Next = new DarkUI.Controls.DarkButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_Platform = new DarkUI.Controls.DarkLabel();
            this.lbl_Region = new DarkUI.Controls.DarkLabel();
            this.lbl_Game = new DarkUI.Controls.DarkLabel();
            this.comboBox_Game = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Region = new DarkUI.Controls.DarkComboBox();
            this.comboBox_Platform = new DarkUI.Controls.DarkComboBox();
            this.tlp_Main.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_1_Welcome.SuspendLayout();
            this.tlp_1_Welcome.SuspendLayout();
            this.pnl_1_Welcome_Inner.SuspendLayout();
            this.tlp_1_Welcome_Inner.SuspendLayout();
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
            this.progressBar_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.progressBar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_Main.ForeColor = System.Drawing.Color.LawnGreen;
            this.progressBar_Main.Location = new System.Drawing.Point(0, 470);
            this.progressBar_Main.Margin = new System.Windows.Forms.Padding(0);
            this.progressBar_Main.Name = "progressBar_Main";
            this.progressBar_Main.Size = new System.Drawing.Size(921, 25);
            this.progressBar_Main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Main.TabIndex = 0;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Main.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Controls.Add(this.tabPage_1_Welcome);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.ForeColor = System.Drawing.Color.Silver;
            this.tabControl_Main.Location = new System.Drawing.Point(3, 3);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.Size = new System.Drawing.Size(915, 464);
            this.tabControl_Main.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_1_Welcome
            // 
            this.tabPage_1_Welcome.Controls.Add(this.tlp_1_Welcome);
            this.tabPage_1_Welcome.Location = new System.Drawing.Point(4, 27);
            this.tabPage_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_1_Welcome.Name = "tabPage_1_Welcome";
            this.tabPage_1_Welcome.Size = new System.Drawing.Size(907, 433);
            this.tabPage_1_Welcome.TabIndex = 0;
            this.tabPage_1_Welcome.Text = "tabPage1";
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
            this.pnl_1_Welcome.Size = new System.Drawing.Size(335, 427);
            this.pnl_1_Welcome.TabIndex = 0;
            // 
            // pnl_1_Welcome_Inner
            // 
            this.pnl_1_Welcome_Inner.Controls.Add(this.tlp_1_Welcome_Inner);
            this.pnl_1_Welcome_Inner.Location = new System.Drawing.Point(344, 3);
            this.pnl_1_Welcome_Inner.Name = "pnl_1_Welcome_Inner";
            this.pnl_1_Welcome_Inner.Size = new System.Drawing.Size(560, 427);
            this.pnl_1_Welcome_Inner.TabIndex = 1;
            // 
            // tlp_1_Welcome_Inner
            // 
            this.tlp_1_Welcome_Inner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_1_Welcome_Inner.AutoScroll = true;
            this.tlp_1_Welcome_Inner.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlp_1_Welcome_Inner.ColumnCount = 2;
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.46428F));
            this.tlp_1_Welcome_Inner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.53571F));
            this.tlp_1_Welcome_Inner.Controls.Add(this.btn_Next, 1, 4);
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Platform, 0, 1);
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Region, 0, 2);
            this.tlp_1_Welcome_Inner.Controls.Add(this.lbl_Game, 0, 3);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Game, 1, 3);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Region, 1, 2);
            this.tlp_1_Welcome_Inner.Controls.Add(this.comboBox_Platform, 1, 1);
            this.tlp_1_Welcome_Inner.Controls.Add(this.rtb_1_Welcome, 1, 0);
            this.tlp_1_Welcome_Inner.Location = new System.Drawing.Point(0, 0);
            this.tlp_1_Welcome_Inner.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_1_Welcome_Inner.Name = "tlp_1_Welcome_Inner";
            this.tlp_1_Welcome_Inner.RowCount = 5;
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_1_Welcome_Inner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp_1_Welcome_Inner.Size = new System.Drawing.Size(563, 427);
            this.tlp_1_Welcome_Inner.TabIndex = 2;
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
            this.rtb_1_Welcome.Location = new System.Drawing.Point(109, 0);
            this.rtb_1_Welcome.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_1_Welcome.Name = "rtb_1_Welcome";
            this.rtb_1_Welcome.ReadOnly = true;
            this.rtb_1_Welcome.Size = new System.Drawing.Size(454, 234);
            this.rtb_1_Welcome.TabIndex = 1;
            this.rtb_1_Welcome.Text = "";
            // 
            // btn_Next
            // 
            this.btn_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Next.Enabled = false;
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Next.Location = new System.Drawing.Point(438, 375);
            this.btn_Next.Margin = new System.Windows.Forms.Padding(15);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Next.Size = new System.Drawing.Size(110, 37);
            this.btn_Next.TabIndex = 2;
            this.btn_Next.Text = "Next >";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(907, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Platform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Platform.Location = new System.Drawing.Point(24, 243);
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
            this.lbl_Region.Location = new System.Drawing.Point(30, 285);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(76, 24);
            this.lbl_Region.TabIndex = 4;
            this.lbl_Region.Text = "Region:";
            // 
            // lbl_Game
            // 
            this.lbl_Game.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbl_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_Game.Location = new System.Drawing.Point(40, 327);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(66, 24);
            this.lbl_Game.TabIndex = 5;
            this.lbl_Game.Text = "Game:";
            // 
            // comboBox_Game
            // 
            this.comboBox_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Game.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Game.Enabled = false;
            this.comboBox_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Game.FormattingEnabled = true;
            this.comboBox_Game.Location = new System.Drawing.Point(112, 327);
            this.comboBox_Game.Name = "comboBox_Game";
            this.comboBox_Game.Size = new System.Drawing.Size(448, 29);
            this.comboBox_Game.TabIndex = 6;
            this.comboBox_Game.SelectedIndexChanged += new System.EventHandler(this.Game_Changed);
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Region.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_Region.Enabled = false;
            this.comboBox_Region.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Items.AddRange(new object[] {
            "",
            "USA",
            "EUR"});
            this.comboBox_Region.Location = new System.Drawing.Point(112, 285);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(448, 29);
            this.comboBox_Region.TabIndex = 7;
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
            this.comboBox_Platform.Location = new System.Drawing.Point(112, 243);
            this.comboBox_Platform.Name = "comboBox_Platform";
            this.comboBox_Platform.Size = new System.Drawing.Size(448, 29);
            this.comboBox_Platform.TabIndex = 8;
            this.comboBox_Platform.SelectedIndexChanged += new System.EventHandler(this.Platform_Changed);
            // 
            // WizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 493);
            this.Controls.Add(this.tlp_Main);
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
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Main;
        private ProgressBar progressBar_Main;
        private ShrineFox.IO.TabControl tabControl_Main;
        private TabPage tabPage_1_Welcome;
        private TabPage tabPage2;
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
    }
}

