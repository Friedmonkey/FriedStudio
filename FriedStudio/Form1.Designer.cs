
namespace ScuffedScri
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnCompile = new System.Windows.Forms.Button();
            this.txtbxName = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bttnDarkMode = new System.Windows.Forms.Button();
            this.bttnLightMode = new System.Windows.Forms.Button();
            this.cmbxTarget = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bttnButton = new System.Windows.Forms.Button();
            this.chkbxCheckbox = new System.Windows.Forms.CheckBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtbxTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabctrlPages = new System.Windows.Forms.TabControl();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.txtbxProgram = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabDesigner = new System.Windows.Forms.TabPage();
            this.txtbxDesigner = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabForm = new System.Windows.Forms.TabPage();
            this.txtbxUserCode = new FastColoredTextBoxNS.FastColoredTextBox();
            this.tabFormDesign = new System.Windows.Forms.TabPage();
            this.panTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picbxVisibleIcon = new System.Windows.Forms.PictureBox();
            this.lblVisibleTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataProperties = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.bttnAddClick = new System.Windows.Forms.Button();
            this.bttnDlete = new System.Windows.Forms.Button();
            this.txtbxNameSpace = new System.Windows.Forms.TextBox();
            this.reForm = new ScuffedScri.ResizableControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabctrlPages.SuspendLayout();
            this.tabProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxProgram)).BeginInit();
            this.tabDesigner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxDesigner)).BeginInit();
            this.tabForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUserCode)).BeginInit();
            this.tabFormDesign.SuspendLayout();
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVisibleIcon)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttnCompile
            // 
            this.bttnCompile.Location = new System.Drawing.Point(162, 8);
            this.bttnCompile.Margin = new System.Windows.Forms.Padding(2);
            this.bttnCompile.Name = "bttnCompile";
            this.bttnCompile.Size = new System.Drawing.Size(60, 25);
            this.bttnCompile.TabIndex = 1;
            this.bttnCompile.Text = "Compile";
            this.bttnCompile.UseVisualStyleBackColor = true;
            this.bttnCompile.Click += new System.EventHandler(this.bttnCompile_Click);
            // 
            // txtbxName
            // 
            this.txtbxName.Location = new System.Drawing.Point(11, 11);
            this.txtbxName.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxName.Name = "txtbxName";
            this.txtbxName.Size = new System.Drawing.Size(76, 20);
            this.txtbxName.TabIndex = 2;
            this.txtbxName.Text = "MyProject";
            this.txtbxName.TextChanged += new System.EventHandler(this.txtbxName_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(107, 13);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "start";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bttnDarkMode
            // 
            this.bttnDarkMode.Location = new System.Drawing.Point(388, 8);
            this.bttnDarkMode.Margin = new System.Windows.Forms.Padding(2);
            this.bttnDarkMode.Name = "bttnDarkMode";
            this.bttnDarkMode.Size = new System.Drawing.Size(68, 25);
            this.bttnDarkMode.TabIndex = 6;
            this.bttnDarkMode.Text = "Dark mode";
            this.bttnDarkMode.UseVisualStyleBackColor = true;
            this.bttnDarkMode.Click += new System.EventHandler(this.bttnDarkMode_Click);
            // 
            // bttnLightMode
            // 
            this.bttnLightMode.Location = new System.Drawing.Point(315, 8);
            this.bttnLightMode.Margin = new System.Windows.Forms.Padding(2);
            this.bttnLightMode.Name = "bttnLightMode";
            this.bttnLightMode.Size = new System.Drawing.Size(69, 25);
            this.bttnLightMode.TabIndex = 7;
            this.bttnLightMode.Text = "Light mode";
            this.bttnLightMode.UseVisualStyleBackColor = true;
            this.bttnLightMode.Click += new System.EventHandler(this.bttnLightMode_Click);
            // 
            // cmbxTarget
            // 
            this.cmbxTarget.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTarget.FormattingEnabled = true;
            this.cmbxTarget.Items.AddRange(new object[] {
            "exe.exe",
            "winexe.exe",
            "library.dll"});
            this.cmbxTarget.Location = new System.Drawing.Point(504, 12);
            this.cmbxTarget.Name = "cmbxTarget";
            this.cmbxTarget.Size = new System.Drawing.Size(66, 21);
            this.cmbxTarget.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "target:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(588, 326);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bttnButton);
            this.flowLayoutPanel1.Controls.Add(this.chkbxCheckbox);
            this.flowLayoutPanel1.Controls.Add(this.lblLabel);
            this.flowLayoutPanel1.Controls.Add(this.txtbxTextbox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(52, 320);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // bttnButton
            // 
            this.bttnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnButton.Location = new System.Drawing.Point(3, 3);
            this.bttnButton.MinimumSize = new System.Drawing.Size(10, 20);
            this.bttnButton.Name = "bttnButton";
            this.bttnButton.Size = new System.Drawing.Size(56, 20);
            this.bttnButton.TabIndex = 0;
            this.bttnButton.Text = "Button";
            this.bttnButton.UseVisualStyleBackColor = true;
            this.bttnButton.Click += new System.EventHandler(this.bttnButton_Click);
            // 
            // chkbxCheckbox
            // 
            this.chkbxCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkbxCheckbox.AutoSize = true;
            this.chkbxCheckbox.Location = new System.Drawing.Point(3, 29);
            this.chkbxCheckbox.Name = "chkbxCheckbox";
            this.chkbxCheckbox.Size = new System.Drawing.Size(56, 17);
            this.chkbxCheckbox.TabIndex = 2;
            this.chkbxCheckbox.Text = "check";
            this.chkbxCheckbox.UseVisualStyleBackColor = true;
            this.chkbxCheckbox.CheckedChanged += new System.EventHandler(this.chkbxCheckbox_CheckedChanged);
            // 
            // lblLabel
            // 
            this.lblLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabel.AutoSize = true;
            this.lblLabel.Location = new System.Drawing.Point(3, 49);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(56, 13);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.Text = "Label";
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            // 
            // txtbxTextbox
            // 
            this.txtbxTextbox.Location = new System.Drawing.Point(3, 65);
            this.txtbxTextbox.Name = "txtbxTextbox";
            this.txtbxTextbox.Size = new System.Drawing.Size(56, 20);
            this.txtbxTextbox.TabIndex = 3;
            this.txtbxTextbox.Click += new System.EventHandler(this.txtbxTextbox_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tabctrlPages, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(61, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(405, 320);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tabctrlPages
            // 
            this.tabctrlPages.Controls.Add(this.tabProgram);
            this.tabctrlPages.Controls.Add(this.tabDesigner);
            this.tabctrlPages.Controls.Add(this.tabForm);
            this.tabctrlPages.Controls.Add(this.tabFormDesign);
            this.tabctrlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlPages.Location = new System.Drawing.Point(3, 3);
            this.tabctrlPages.Name = "tabctrlPages";
            this.tabctrlPages.SelectedIndex = 0;
            this.tabctrlPages.Size = new System.Drawing.Size(399, 282);
            this.tabctrlPages.TabIndex = 10;
            this.tabctrlPages.Click += new System.EventHandler(this.tabctrlPages_Click);
            // 
            // tabProgram
            // 
            this.tabProgram.Controls.Add(this.txtbxProgram);
            this.tabProgram.Location = new System.Drawing.Point(4, 22);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(391, 256);
            this.tabProgram.TabIndex = 0;
            this.tabProgram.Text = "Program.cs";
            this.tabProgram.UseVisualStyleBackColor = true;
            // 
            // txtbxProgram
            // 
            this.txtbxProgram.AutoCompleteBrackets = true;
            this.txtbxProgram.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtbxProgram.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtbxProgram.AutoScrollMinSize = new System.Drawing.Size(555, 248);
            this.txtbxProgram.BackBrush = null;
            this.txtbxProgram.BackColor = System.Drawing.Color.Silver;
            this.txtbxProgram.BookmarkColor = System.Drawing.Color.Teal;
            this.txtbxProgram.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtbxProgram.CharHeight = 14;
            this.txtbxProgram.CharWidth = 8;
            this.txtbxProgram.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxProgram.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtbxProgram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxProgram.Hotkeys = resources.GetString("txtbxProgram.Hotkeys");
            this.txtbxProgram.IsReplaceMode = false;
            this.txtbxProgram.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtbxProgram.LeftBracket = '(';
            this.txtbxProgram.LeftBracket2 = '{';
            this.txtbxProgram.Location = new System.Drawing.Point(3, 3);
            this.txtbxProgram.Name = "txtbxProgram";
            this.txtbxProgram.Paddings = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtbxProgram.RightBracket = ')';
            this.txtbxProgram.RightBracket2 = '}';
            this.txtbxProgram.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtbxProgram.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtbxProgram.ServiceColors")));
            this.txtbxProgram.Size = new System.Drawing.Size(385, 250);
            this.txtbxProgram.TabIndex = 5;
            this.txtbxProgram.Text = resources.GetString("txtbxProgram.Text");
            this.txtbxProgram.Zoom = 100;
            // 
            // tabDesigner
            // 
            this.tabDesigner.Controls.Add(this.txtbxDesigner);
            this.tabDesigner.Location = new System.Drawing.Point(4, 22);
            this.tabDesigner.Name = "tabDesigner";
            this.tabDesigner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDesigner.Size = new System.Drawing.Size(391, 256);
            this.tabDesigner.TabIndex = 1;
            this.tabDesigner.Text = "Form [Designer]";
            this.tabDesigner.UseVisualStyleBackColor = true;
            // 
            // txtbxDesigner
            // 
            this.txtbxDesigner.AutoCompleteBrackets = true;
            this.txtbxDesigner.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtbxDesigner.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtbxDesigner.AutoScrollMinSize = new System.Drawing.Size(731, 612);
            this.txtbxDesigner.BackBrush = null;
            this.txtbxDesigner.BackColor = System.Drawing.Color.Silver;
            this.txtbxDesigner.BookmarkColor = System.Drawing.Color.Teal;
            this.txtbxDesigner.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtbxDesigner.CharHeight = 14;
            this.txtbxDesigner.CharWidth = 8;
            this.txtbxDesigner.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxDesigner.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtbxDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxDesigner.Hotkeys = resources.GetString("txtbxDesigner.Hotkeys");
            this.txtbxDesigner.IsReplaceMode = false;
            this.txtbxDesigner.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtbxDesigner.LeftBracket = '(';
            this.txtbxDesigner.LeftBracket2 = '{';
            this.txtbxDesigner.Location = new System.Drawing.Point(3, 3);
            this.txtbxDesigner.Name = "txtbxDesigner";
            this.txtbxDesigner.Paddings = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtbxDesigner.RightBracket = ')';
            this.txtbxDesigner.RightBracket2 = '}';
            this.txtbxDesigner.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtbxDesigner.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtbxDesigner.ServiceColors")));
            this.txtbxDesigner.Size = new System.Drawing.Size(385, 250);
            this.txtbxDesigner.TabIndex = 6;
            this.txtbxDesigner.Text = resources.GetString("txtbxDesigner.Text");
            this.txtbxDesigner.Zoom = 100;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txtbxUserCode);
            this.tabForm.Location = new System.Drawing.Point(4, 22);
            this.tabForm.Name = "tabForm";
            this.tabForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabForm.Size = new System.Drawing.Size(391, 256);
            this.tabForm.TabIndex = 2;
            this.tabForm.Text = "Form.cs";
            this.tabForm.UseVisualStyleBackColor = true;
            // 
            // txtbxUserCode
            // 
            this.txtbxUserCode.AutoCompleteBrackets = true;
            this.txtbxUserCode.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.txtbxUserCode.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;]+);\r\n^\\s*(case|default)\\s*[^:]" +
    "*(?<range>:)\\s*(?<range>[^;]+);\r\n";
            this.txtbxUserCode.AutoScrollMinSize = new System.Drawing.Size(331, 262);
            this.txtbxUserCode.BackBrush = null;
            this.txtbxUserCode.BackColor = System.Drawing.Color.Silver;
            this.txtbxUserCode.BookmarkColor = System.Drawing.Color.Teal;
            this.txtbxUserCode.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.txtbxUserCode.CharHeight = 14;
            this.txtbxUserCode.CharWidth = 8;
            this.txtbxUserCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbxUserCode.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.txtbxUserCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbxUserCode.Hotkeys = resources.GetString("txtbxUserCode.Hotkeys");
            this.txtbxUserCode.IsReplaceMode = false;
            this.txtbxUserCode.Language = FastColoredTextBoxNS.Language.CSharp;
            this.txtbxUserCode.LeftBracket = '(';
            this.txtbxUserCode.LeftBracket2 = '{';
            this.txtbxUserCode.Location = new System.Drawing.Point(3, 3);
            this.txtbxUserCode.Name = "txtbxUserCode";
            this.txtbxUserCode.Paddings = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.txtbxUserCode.RightBracket = ')';
            this.txtbxUserCode.RightBracket2 = '}';
            this.txtbxUserCode.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.txtbxUserCode.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtbxUserCode.ServiceColors")));
            this.txtbxUserCode.Size = new System.Drawing.Size(385, 250);
            this.txtbxUserCode.TabIndex = 6;
            this.txtbxUserCode.Text = resources.GetString("txtbxUserCode.Text");
            this.txtbxUserCode.Zoom = 100;
            // 
            // tabFormDesign
            // 
            this.tabFormDesign.BackColor = System.Drawing.Color.DimGray;
            this.tabFormDesign.Controls.Add(this.panTop);
            this.tabFormDesign.Controls.Add(this.reForm);
            this.tabFormDesign.Location = new System.Drawing.Point(4, 22);
            this.tabFormDesign.Name = "tabFormDesign";
            this.tabFormDesign.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormDesign.Size = new System.Drawing.Size(391, 256);
            this.tabFormDesign.TabIndex = 3;
            this.tabFormDesign.Text = "Form [Design]";
            this.tabFormDesign.Click += new System.EventHandler(this.tabFormDesign_Click);
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panTop.Controls.Add(this.pictureBox1);
            this.panTop.Controls.Add(this.picbxVisibleIcon);
            this.panTop.Controls.Add(this.lblVisibleTitle);
            this.panTop.Location = new System.Drawing.Point(16, 10);
            this.panTop.Margin = new System.Windows.Forms.Padding(2);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(225, 27);
            this.panTop.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(107, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // picbxVisibleIcon
            // 
            this.picbxVisibleIcon.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picbxVisibleIcon.Image = ((System.Drawing.Image)(resources.GetObject("picbxVisibleIcon.Image")));
            this.picbxVisibleIcon.Location = new System.Drawing.Point(9, 6);
            this.picbxVisibleIcon.Margin = new System.Windows.Forms.Padding(2);
            this.picbxVisibleIcon.Name = "picbxVisibleIcon";
            this.picbxVisibleIcon.Size = new System.Drawing.Size(15, 17);
            this.picbxVisibleIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbxVisibleIcon.TabIndex = 1;
            this.picbxVisibleIcon.TabStop = false;
            // 
            // lblVisibleTitle
            // 
            this.lblVisibleTitle.AutoSize = true;
            this.lblVisibleTitle.Location = new System.Drawing.Point(27, 9);
            this.lblVisibleTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVisibleTitle.Name = "lblVisibleTitle";
            this.lblVisibleTitle.Size = new System.Drawing.Size(54, 13);
            this.lblVisibleTitle.TabIndex = 0;
            this.lblVisibleTitle.Text = "MyProject";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataProperties, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(472, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(113, 320);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // dataProperties
            // 
            this.dataProperties.AllowUserToAddRows = false;
            this.dataProperties.AllowUserToDeleteRows = false;
            this.dataProperties.AllowUserToResizeColumns = false;
            this.dataProperties.AllowUserToResizeRows = false;
            this.dataProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProperties.Location = new System.Drawing.Point(3, 115);
            this.dataProperties.MultiSelect = false;
            this.dataProperties.Name = "dataProperties";
            this.dataProperties.RowHeadersVisible = false;
            this.dataProperties.Size = new System.Drawing.Size(107, 202);
            this.dataProperties.TabIndex = 0;
            this.dataProperties.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataProperties_CellEndEdit);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.bttnAddClick, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.bttnDlete, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(107, 106);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // bttnAddClick
            // 
            this.bttnAddClick.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnAddClick.Location = new System.Drawing.Point(3, 38);
            this.bttnAddClick.Name = "bttnAddClick";
            this.bttnAddClick.Size = new System.Drawing.Size(101, 29);
            this.bttnAddClick.TabIndex = 2;
            this.bttnAddClick.Text = "Add Click";
            this.bttnAddClick.UseVisualStyleBackColor = true;
            this.bttnAddClick.Click += new System.EventHandler(this.bttnAddClick_Click);
            // 
            // bttnDlete
            // 
            this.bttnDlete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bttnDlete.Location = new System.Drawing.Point(3, 3);
            this.bttnDlete.Name = "bttnDlete";
            this.bttnDlete.Size = new System.Drawing.Size(101, 29);
            this.bttnDlete.TabIndex = 1;
            this.bttnDlete.Text = "Delete Control";
            this.bttnDlete.UseVisualStyleBackColor = true;
            this.bttnDlete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // txtbxNameSpace
            // 
            this.txtbxNameSpace.Location = new System.Drawing.Point(229, 11);
            this.txtbxNameSpace.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxNameSpace.Name = "txtbxNameSpace";
            this.txtbxNameSpace.Size = new System.Drawing.Size(76, 20);
            this.txtbxNameSpace.TabIndex = 13;
            this.txtbxNameSpace.Text = "NameSpacer";
            // 
            // reForm
            // 
            this.reForm.AllowAll = false;
            this.reForm.AllowBottom = true;
            this.reForm.AllowBottomLeft = false;
            this.reForm.AllowBottomRight = true;
            this.reForm.AllowLeft = false;
            this.reForm.AllowMove = false;
            this.reForm.AllowRight = true;
            this.reForm.AllowTop = false;
            this.reForm.AllowTopLeft = false;
            this.reForm.AllowTopRight = false;
            this.reForm.BackColor = System.Drawing.Color.Transparent;
            this.reForm.ControlType = ScuffedScri.ResizableControl.fakeControlType.Empty;
            this.reForm.FakeEnabled = true;
            this.reForm.Location = new System.Drawing.Point(7, 27);
            this.reForm.Margin = new System.Windows.Forms.Padding(4);
            this.reForm.MinimalHeight = 175;
            this.reForm.MinimalWidth = 250;
            this.reForm.Name = "reForm";
            this.reForm.Padding = new System.Windows.Forms.Padding(10);
            this.reForm.Size = new System.Drawing.Size(244, 155);
            this.reForm.TabIndex = 2;
            this.reForm.SizeChanged += new System.EventHandler(this.reForm_SizeChanged);
            this.reForm.Click += new System.EventHandler(this.ClickControl);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtbxNameSpace);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxTarget);
            this.Controls.Add(this.bttnLightMode);
            this.Controls.Add(this.bttnDarkMode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtbxName);
            this.Controls.Add(this.bttnCompile);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FriedStudio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tabctrlPages.ResumeLayout(false);
            this.tabProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxProgram)).EndInit();
            this.tabDesigner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxDesigner)).EndInit();
            this.tabForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtbxUserCode)).EndInit();
            this.tabFormDesign.ResumeLayout(false);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbxVisibleIcon)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProperties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bttnCompile;
        private System.Windows.Forms.TextBox txtbxName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bttnDarkMode;
        private System.Windows.Forms.Button bttnLightMode;
        private System.Windows.Forms.ComboBox cmbxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bttnButton;
        private System.Windows.Forms.CheckBox chkbxCheckbox;
        private System.Windows.Forms.Label lblLabel;
        //private ResizableControl resizableControl1;
        //private ResizableControl reForm;
        private System.Windows.Forms.TextBox txtbxNameSpace;
        private System.Windows.Forms.TabControl tabctrlPages;
        private System.Windows.Forms.TabPage tabProgram;
        private FastColoredTextBoxNS.FastColoredTextBox txtbxProgram;
        private System.Windows.Forms.TabPage tabDesigner;
        private FastColoredTextBoxNS.FastColoredTextBox txtbxDesigner;
        private System.Windows.Forms.TabPage tabForm;
        private FastColoredTextBoxNS.FastColoredTextBox txtbxUserCode;
        private System.Windows.Forms.TabPage tabFormDesign;
        private ResizableControl reForm;
        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.PictureBox picbxVisibleIcon;
        private System.Windows.Forms.Label lblVisibleTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataProperties;
        private System.Windows.Forms.Button bttnDlete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button bttnAddClick;
        private System.Windows.Forms.TextBox txtbxTextbox;
    }
}

