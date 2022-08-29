using DarkUI.Forms;

namespace PersonaPatchGen
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
            this.tlp_PQ1_Names = new System.Windows.Forms.TableLayoutPanel();
            this.txt_P4HERO_First = new DarkUI.Controls.DarkTextBox();
            this.lbl_P3HERO_First = new DarkUI.Controls.DarkLabel();
            this.lbl_P4HERO_First = new DarkUI.Controls.DarkLabel();
            this.txt_P3HERO_First = new DarkUI.Controls.DarkTextBox();
            this.tlp_PQ2_Names = new System.Windows.Forms.TableLayoutPanel();
            this.txt_P3PHERO_First = new DarkUI.Controls.DarkTextBox();
            this.lbl_P5HERO_First = new DarkUI.Controls.DarkLabel();
            this.lbl_P3PHERO = new DarkUI.Controls.DarkLabel();
            this.txt_P5HERO_First = new DarkUI.Controls.DarkTextBox();
            this.groupBox_PQ2Names = new System.Windows.Forms.GroupBox();
            this.lbl_P3HERO_Last = new DarkUI.Controls.DarkLabel();
            this.txt_P3HERO_Last = new DarkUI.Controls.DarkTextBox();
            this.lbl_P4HERO_Last = new DarkUI.Controls.DarkLabel();
            this.txt_P4HERO_Last = new DarkUI.Controls.DarkTextBox();
            this.lbl_P3PHERO_Last = new DarkUI.Controls.DarkLabel();
            this.txt_P3PHERO_Last = new DarkUI.Controls.DarkTextBox();
            this.lbl_P5HERO_Last = new DarkUI.Controls.DarkLabel();
            this.txt_P5HERO_Last = new DarkUI.Controls.DarkTextBox();
            this.tlp_PQNames_Main.SuspendLayout();
            this.groupBox_PQNames.SuspendLayout();
            this.tlp_PQ1_Names.SuspendLayout();
            this.tlp_PQ2_Names.SuspendLayout();
            this.groupBox_PQ2Names.SuspendLayout();
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
            this.tlp_PQNames_Main.Size = new System.Drawing.Size(614, 331);
            this.tlp_PQNames_Main.TabIndex = 0;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Confirm.Location = new System.Drawing.Point(310, 284);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Padding = new System.Windows.Forms.Padding(5);
            this.btn_Confirm.Size = new System.Drawing.Size(301, 44);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm Names";
            this.btn_Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // groupBox_PQNames
            // 
            this.groupBox_PQNames.Controls.Add(this.tlp_PQ1_Names);
            this.groupBox_PQNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PQNames.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_PQNames.Location = new System.Drawing.Point(3, 3);
            this.groupBox_PQNames.Name = "groupBox_PQNames";
            this.groupBox_PQNames.Size = new System.Drawing.Size(301, 275);
            this.groupBox_PQNames.TabIndex = 1;
            this.groupBox_PQNames.TabStop = false;
            this.groupBox_PQNames.Text = "Persona Q1+2";
            // 
            // tlp_PQ1_Names
            // 
            this.tlp_PQ1_Names.ColumnCount = 2;
            this.tlp_PQ1_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlp_PQ1_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P4HERO_Last, 0, 3);
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P3HERO_First, 0, 0);
            this.tlp_PQ1_Names.Controls.Add(this.txt_P3HERO_First, 1, 0);
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P4HERO_First, 0, 2);
            this.tlp_PQ1_Names.Controls.Add(this.txt_P4HERO_First, 1, 2);
            this.tlp_PQ1_Names.Controls.Add(this.lbl_P3HERO_Last, 0, 1);
            this.tlp_PQ1_Names.Controls.Add(this.txt_P3HERO_Last, 1, 1);
            this.tlp_PQ1_Names.Controls.Add(this.txt_P4HERO_Last, 1, 3);
            this.tlp_PQ1_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PQ1_Names.Location = new System.Drawing.Point(3, 18);
            this.tlp_PQ1_Names.Name = "tlp_PQ1_Names";
            this.tlp_PQ1_Names.RowCount = 4;
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ1_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ1_Names.Size = new System.Drawing.Size(295, 254);
            this.tlp_PQ1_Names.TabIndex = 0;
            // 
            // txt_P4HERO_First
            // 
            this.txt_P4HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P4HERO_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P4HERO_First.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P4HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P4HERO_First.Location = new System.Drawing.Point(85, 146);
            this.txt_P4HERO_First.MaxLength = 14;
            this.txt_P4HERO_First.Name = "txt_P4HERO_First";
            this.txt_P4HERO_First.Size = new System.Drawing.Size(207, 22);
            this.txt_P4HERO_First.TabIndex = 3;
            this.txt_P4HERO_First.Text = "Yu";
            // 
            // lbl_P3HERO_First
            // 
            this.lbl_P3HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3HERO_First.AutoSize = true;
            this.lbl_P3HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3HERO_First.Location = new System.Drawing.Point(3, 23);
            this.lbl_P3HERO_First.Name = "lbl_P3HERO_First";
            this.lbl_P3HERO_First.Size = new System.Drawing.Size(76, 16);
            this.lbl_P3HERO_First.TabIndex = 0;
            this.lbl_P3HERO_First.Text = "P3 First:";
            this.lbl_P3HERO_First.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_P4HERO_First
            // 
            this.lbl_P4HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P4HERO_First.AutoSize = true;
            this.lbl_P4HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P4HERO_First.Location = new System.Drawing.Point(3, 149);
            this.lbl_P4HERO_First.Name = "lbl_P4HERO_First";
            this.lbl_P4HERO_First.Size = new System.Drawing.Size(76, 16);
            this.lbl_P4HERO_First.TabIndex = 1;
            this.lbl_P4HERO_First.Text = "P4 First:";
            this.lbl_P4HERO_First.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P3HERO_First
            // 
            this.txt_P3HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3HERO_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3HERO_First.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3HERO_First.Location = new System.Drawing.Point(85, 20);
            this.txt_P3HERO_First.MaxLength = 14;
            this.txt_P3HERO_First.Name = "txt_P3HERO_First";
            this.txt_P3HERO_First.Size = new System.Drawing.Size(207, 22);
            this.txt_P3HERO_First.TabIndex = 2;
            this.txt_P3HERO_First.Text = "Makoto";
            // 
            // tlp_PQ2_Names
            // 
            this.tlp_PQ2_Names.ColumnCount = 2;
            this.tlp_PQ2_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlp_PQ2_Names.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P5HERO_Last, 0, 3);
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P3PHERO, 0, 0);
            this.tlp_PQ2_Names.Controls.Add(this.txt_P3PHERO_First, 1, 0);
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P5HERO_First, 0, 2);
            this.tlp_PQ2_Names.Controls.Add(this.txt_P5HERO_First, 1, 2);
            this.tlp_PQ2_Names.Controls.Add(this.lbl_P3PHERO_Last, 0, 1);
            this.tlp_PQ2_Names.Controls.Add(this.txt_P3PHERO_Last, 1, 1);
            this.tlp_PQ2_Names.Controls.Add(this.txt_P5HERO_Last, 1, 3);
            this.tlp_PQ2_Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_PQ2_Names.Location = new System.Drawing.Point(3, 18);
            this.tlp_PQ2_Names.Name = "tlp_PQ2_Names";
            this.tlp_PQ2_Names.RowCount = 4;
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ2_Names.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_PQ2_Names.Size = new System.Drawing.Size(295, 254);
            this.tlp_PQ2_Names.TabIndex = 1;
            // 
            // txt_P3PHERO_First
            // 
            this.txt_P3PHERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3PHERO_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3PHERO_First.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3PHERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3PHERO_First.Location = new System.Drawing.Point(85, 20);
            this.txt_P3PHERO_First.MaxLength = 14;
            this.txt_P3PHERO_First.Name = "txt_P3PHERO_First";
            this.txt_P3PHERO_First.Size = new System.Drawing.Size(207, 22);
            this.txt_P3PHERO_First.TabIndex = 2;
            this.txt_P3PHERO_First.Text = "Kotone";
            // 
            // lbl_P5HERO_First
            // 
            this.lbl_P5HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P5HERO_First.AutoSize = true;
            this.lbl_P5HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P5HERO_First.Location = new System.Drawing.Point(3, 149);
            this.lbl_P5HERO_First.Name = "lbl_P5HERO_First";
            this.lbl_P5HERO_First.Size = new System.Drawing.Size(76, 16);
            this.lbl_P5HERO_First.TabIndex = 1;
            this.lbl_P5HERO_First.Text = "P5 First:";
            this.lbl_P5HERO_First.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_P3PHERO
            // 
            this.lbl_P3PHERO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3PHERO.AutoSize = true;
            this.lbl_P3PHERO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3PHERO.Location = new System.Drawing.Point(3, 23);
            this.lbl_P3PHERO.Name = "lbl_P3PHERO";
            this.lbl_P3PHERO.Size = new System.Drawing.Size(76, 16);
            this.lbl_P3PHERO.TabIndex = 0;
            this.lbl_P3PHERO.Text = "P3P First:";
            this.lbl_P3PHERO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P5HERO_First
            // 
            this.txt_P5HERO_First.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P5HERO_First.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P5HERO_First.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P5HERO_First.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P5HERO_First.Location = new System.Drawing.Point(85, 146);
            this.txt_P5HERO_First.MaxLength = 14;
            this.txt_P5HERO_First.Name = "txt_P5HERO_First";
            this.txt_P5HERO_First.Size = new System.Drawing.Size(207, 22);
            this.txt_P5HERO_First.TabIndex = 3;
            this.txt_P5HERO_First.Text = "Ren";
            // 
            // groupBox_PQ2Names
            // 
            this.groupBox_PQ2Names.Controls.Add(this.tlp_PQ2_Names);
            this.groupBox_PQ2Names.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_PQ2Names.ForeColor = System.Drawing.Color.Silver;
            this.groupBox_PQ2Names.Location = new System.Drawing.Point(310, 3);
            this.groupBox_PQ2Names.Name = "groupBox_PQ2Names";
            this.groupBox_PQ2Names.Size = new System.Drawing.Size(301, 275);
            this.groupBox_PQ2Names.TabIndex = 2;
            this.groupBox_PQ2Names.TabStop = false;
            this.groupBox_PQ2Names.Text = "Persona Q2";
            // 
            // lbl_P3HERO_Last
            // 
            this.lbl_P3HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3HERO_Last.AutoSize = true;
            this.lbl_P3HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3HERO_Last.Location = new System.Drawing.Point(3, 86);
            this.lbl_P3HERO_Last.Name = "lbl_P3HERO_Last";
            this.lbl_P3HERO_Last.Size = new System.Drawing.Size(76, 16);
            this.lbl_P3HERO_Last.TabIndex = 4;
            this.lbl_P3HERO_Last.Text = "P3 Last:";
            this.lbl_P3HERO_Last.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P3HERO_Last
            // 
            this.txt_P3HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3HERO_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3HERO_Last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3HERO_Last.Location = new System.Drawing.Point(85, 83);
            this.txt_P3HERO_Last.MaxLength = 14;
            this.txt_P3HERO_Last.Name = "txt_P3HERO_Last";
            this.txt_P3HERO_Last.Size = new System.Drawing.Size(207, 22);
            this.txt_P3HERO_Last.TabIndex = 5;
            this.txt_P3HERO_Last.Text = "Yuki";
            // 
            // lbl_P4HERO_Last
            // 
            this.lbl_P4HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P4HERO_Last.AutoSize = true;
            this.lbl_P4HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P4HERO_Last.Location = new System.Drawing.Point(3, 213);
            this.lbl_P4HERO_Last.Name = "lbl_P4HERO_Last";
            this.lbl_P4HERO_Last.Size = new System.Drawing.Size(76, 16);
            this.lbl_P4HERO_Last.TabIndex = 6;
            this.lbl_P4HERO_Last.Text = "P4 Last:";
            this.lbl_P4HERO_Last.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P4HERO_Last
            // 
            this.txt_P4HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P4HERO_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P4HERO_Last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P4HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P4HERO_Last.Location = new System.Drawing.Point(85, 210);
            this.txt_P4HERO_Last.MaxLength = 14;
            this.txt_P4HERO_Last.Name = "txt_P4HERO_Last";
            this.txt_P4HERO_Last.Size = new System.Drawing.Size(207, 22);
            this.txt_P4HERO_Last.TabIndex = 7;
            this.txt_P4HERO_Last.Text = "Narukami";
            // 
            // lbl_P3PHERO_Last
            // 
            this.lbl_P3PHERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P3PHERO_Last.AutoSize = true;
            this.lbl_P3PHERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P3PHERO_Last.Location = new System.Drawing.Point(3, 86);
            this.lbl_P3PHERO_Last.Name = "lbl_P3PHERO_Last";
            this.lbl_P3PHERO_Last.Size = new System.Drawing.Size(76, 16);
            this.lbl_P3PHERO_Last.TabIndex = 4;
            this.lbl_P3PHERO_Last.Text = "P3P Last:";
            this.lbl_P3PHERO_Last.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P3PHERO_Last
            // 
            this.txt_P3PHERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P3PHERO_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P3PHERO_Last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P3PHERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P3PHERO_Last.Location = new System.Drawing.Point(85, 83);
            this.txt_P3PHERO_Last.MaxLength = 14;
            this.txt_P3PHERO_Last.Name = "txt_P3PHERO_Last";
            this.txt_P3PHERO_Last.Size = new System.Drawing.Size(207, 22);
            this.txt_P3PHERO_Last.TabIndex = 5;
            this.txt_P3PHERO_Last.Text = "Shiomi";
            // 
            // lbl_P5HERO_Last
            // 
            this.lbl_P5HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_P5HERO_Last.AutoSize = true;
            this.lbl_P5HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.lbl_P5HERO_Last.Location = new System.Drawing.Point(3, 213);
            this.lbl_P5HERO_Last.Name = "lbl_P5HERO_Last";
            this.lbl_P5HERO_Last.Size = new System.Drawing.Size(76, 16);
            this.lbl_P5HERO_Last.TabIndex = 6;
            this.lbl_P5HERO_Last.Text = "P5 Last:";
            this.lbl_P5HERO_Last.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_P5HERO_Last
            // 
            this.txt_P5HERO_Last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_P5HERO_Last.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txt_P5HERO_Last.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_P5HERO_Last.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txt_P5HERO_Last.Location = new System.Drawing.Point(85, 210);
            this.txt_P5HERO_Last.MaxLength = 14;
            this.txt_P5HERO_Last.Name = "txt_P5HERO_Last";
            this.txt_P5HERO_Last.Size = new System.Drawing.Size(207, 22);
            this.txt_P5HERO_Last.TabIndex = 7;
            this.txt_P5HERO_Last.Text = "Amamiya";
            // 
            // PQNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.tlp_PQNames_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PQNameForm";
            this.Text = "Set Leader Names...";
            this.tlp_PQNames_Main.ResumeLayout(false);
            this.groupBox_PQNames.ResumeLayout(false);
            this.tlp_PQ1_Names.ResumeLayout(false);
            this.tlp_PQ1_Names.PerformLayout();
            this.tlp_PQ2_Names.ResumeLayout(false);
            this.tlp_PQ2_Names.PerformLayout();
            this.groupBox_PQ2Names.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_PQNames_Main;
        private DarkUI.Controls.DarkButton btn_Confirm;
        private System.Windows.Forms.GroupBox groupBox_PQNames;
        private System.Windows.Forms.TableLayoutPanel tlp_PQ1_Names;
        private DarkUI.Controls.DarkLabel lbl_P3HERO_First;
        private DarkUI.Controls.DarkLabel lbl_P4HERO_First;
        private DarkUI.Controls.DarkTextBox txt_P3HERO_First;
        private DarkUI.Controls.DarkTextBox txt_P4HERO_First;
        private System.Windows.Forms.GroupBox groupBox_PQ2Names;
        private System.Windows.Forms.TableLayoutPanel tlp_PQ2_Names;
        private DarkUI.Controls.DarkTextBox txt_P5HERO_First;
        private DarkUI.Controls.DarkLabel lbl_P3PHERO;
        private DarkUI.Controls.DarkLabel lbl_P5HERO_First;
        private DarkUI.Controls.DarkTextBox txt_P3PHERO_First;
        private DarkUI.Controls.DarkLabel lbl_P3HERO_Last;
        private DarkUI.Controls.DarkTextBox txt_P3HERO_Last;
        private DarkUI.Controls.DarkLabel lbl_P4HERO_Last;
        private DarkUI.Controls.DarkTextBox txt_P4HERO_Last;
        private DarkUI.Controls.DarkLabel lbl_P3PHERO_Last;
        private DarkUI.Controls.DarkTextBox txt_P3PHERO_Last;
        private DarkUI.Controls.DarkLabel lbl_P5HERO_Last;
        private DarkUI.Controls.DarkTextBox txt_P5HERO_Last;
    }
}