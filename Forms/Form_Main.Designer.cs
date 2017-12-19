namespace SHex
{
    partial class Form_Main
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
            this.StatusStrip_Bottom = new System.Windows.Forms.StatusStrip();
            this.StatusStrip_Bottom_Label_LnCol = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Bottom_Label_Blank = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Bottom_Label_Bit = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip_Bottom_Label_Value = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.ToolStrip_Top_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_File_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_File_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Cut = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Seperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Top_Edit_CopyHex = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_PasteHex = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Seperator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Top_Edit_Find = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_FindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Goto = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Edit_Seperator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip_Top_Edit_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Options_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip_Top_Options_Apply = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top_Size = new System.Windows.Forms.ToolStripTextBox();
            this.BitControl_Hidden = new Be.HexEditor.BitControl();
            this.HexBox_Main = new SHex.HexBox();
            this.ToolStrip_Top_Edit_FindStrings = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip_Bottom.SuspendLayout();
            this.MenuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip_Bottom
            // 
            this.StatusStrip_Bottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStrip_Bottom_Label_LnCol,
            this.StatusStrip_Bottom_Label_Blank,
            this.StatusStrip_Bottom_Label_Bit,
            this.StatusStrip_Bottom_Label_Value});
            this.StatusStrip_Bottom.Location = new System.Drawing.Point(0, 449);
            this.StatusStrip_Bottom.Name = "StatusStrip_Bottom";
            this.StatusStrip_Bottom.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.StatusStrip_Bottom.Size = new System.Drawing.Size(644, 22);
            this.StatusStrip_Bottom.TabIndex = 0;
            // 
            // StatusStrip_Bottom_Label_LnCol
            // 
            this.StatusStrip_Bottom_Label_LnCol.BackColor = System.Drawing.SystemColors.Control;
            this.StatusStrip_Bottom_Label_LnCol.ForeColor = System.Drawing.Color.Black;
            this.StatusStrip_Bottom_Label_LnCol.Name = "StatusStrip_Bottom_Label_LnCol";
            this.StatusStrip_Bottom_Label_LnCol.Size = new System.Drawing.Size(99, 17);
            this.StatusStrip_Bottom_Label_LnCol.Text = "Line: 0 Column: 0";
            // 
            // StatusStrip_Bottom_Label_Blank
            // 
            this.StatusStrip_Bottom_Label_Blank.Name = "StatusStrip_Bottom_Label_Blank";
            this.StatusStrip_Bottom_Label_Blank.Size = new System.Drawing.Size(451, 17);
            this.StatusStrip_Bottom_Label_Blank.Spring = true;
            // 
            // StatusStrip_Bottom_Label_Bit
            // 
            this.StatusStrip_Bottom_Label_Bit.Name = "StatusStrip_Bottom_Label_Bit";
            this.StatusStrip_Bottom_Label_Bit.Size = new System.Drawing.Size(33, 17);
            this.StatusStrip_Bottom_Label_Bit.Text = "Bit: 0";
            // 
            // StatusStrip_Bottom_Label_Value
            // 
            this.StatusStrip_Bottom_Label_Value.Name = "StatusStrip_Bottom_Label_Value";
            this.StatusStrip_Bottom_Label_Value.Size = new System.Drawing.Size(48, 17);
            this.StatusStrip_Bottom_Label_Value.Text = "Value: 0";
            // 
            // MenuStrip_Top
            // 
            this.MenuStrip_Top.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Top_File,
            this.ToolStrip_Top_Edit,
            this.ToolStrip_Top_Options,
            this.MenuStrip_Top_Size});
            this.MenuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Top.Name = "MenuStrip_Top";
            this.MenuStrip_Top.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStrip_Top.Size = new System.Drawing.Size(644, 24);
            this.MenuStrip_Top.TabIndex = 1;
            this.MenuStrip_Top.Text = "ToolStrip_Top";
            // 
            // ToolStrip_Top_File
            // 
            this.ToolStrip_Top_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Top_File_Open,
            this.ToolStrip_Top_File_Save,
            this.ToolStrip_Top_File_Close});
            this.ToolStrip_Top_File.Name = "ToolStrip_Top_File";
            this.ToolStrip_Top_File.Size = new System.Drawing.Size(37, 20);
            this.ToolStrip_Top_File.Text = "File";
            // 
            // ToolStrip_Top_File_Open
            // 
            this.ToolStrip_Top_File_Open.Name = "ToolStrip_Top_File_Open";
            this.ToolStrip_Top_File_Open.Size = new System.Drawing.Size(103, 22);
            this.ToolStrip_Top_File_Open.Text = "Open";
            this.ToolStrip_Top_File_Open.Click += new System.EventHandler(this.ToolStrip_Top_File_Open_Click);
            // 
            // ToolStrip_Top_File_Save
            // 
            this.ToolStrip_Top_File_Save.Name = "ToolStrip_Top_File_Save";
            this.ToolStrip_Top_File_Save.Size = new System.Drawing.Size(103, 22);
            this.ToolStrip_Top_File_Save.Text = "Save";
            this.ToolStrip_Top_File_Save.Click += new System.EventHandler(this.ToolStrip_Top_File_Save_Click);
            // 
            // ToolStrip_Top_File_Close
            // 
            this.ToolStrip_Top_File_Close.Name = "ToolStrip_Top_File_Close";
            this.ToolStrip_Top_File_Close.Size = new System.Drawing.Size(103, 22);
            this.ToolStrip_Top_File_Close.Text = "Close";
            this.ToolStrip_Top_File_Close.Click += new System.EventHandler(this.ToolStrip_Top_File_Close_Click);
            // 
            // ToolStrip_Top_Edit
            // 
            this.ToolStrip_Top_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Top_Edit_Cut,
            this.ToolStrip_Top_Edit_Copy,
            this.ToolStrip_Top_Edit_Paste,
            this.ToolStrip_Top_Edit_Seperator1,
            this.ToolStrip_Top_Edit_CopyHex,
            this.ToolStrip_Top_Edit_PasteHex,
            this.ToolStrip_Top_Edit_Seperator2,
            this.ToolStrip_Top_Edit_Find,
            this.ToolStrip_Top_Edit_FindNext,
            this.ToolStrip_Top_Edit_Goto,
            this.ToolStrip_Top_Edit_FindStrings,
            this.ToolStrip_Top_Edit_Seperator3,
            this.ToolStrip_Top_Edit_SelectAll});
            this.ToolStrip_Top_Edit.Name = "ToolStrip_Top_Edit";
            this.ToolStrip_Top_Edit.Size = new System.Drawing.Size(39, 20);
            this.ToolStrip_Top_Edit.Text = "Edit";
            // 
            // ToolStrip_Top_Edit_Cut
            // 
            this.ToolStrip_Top_Edit_Cut.Name = "ToolStrip_Top_Edit_Cut";
            this.ToolStrip_Top_Edit_Cut.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_Cut.Text = "Cut";
            this.ToolStrip_Top_Edit_Cut.Click += new System.EventHandler(this.ToolStrip_Top_Edit_Cut_Click);
            // 
            // ToolStrip_Top_Edit_Copy
            // 
            this.ToolStrip_Top_Edit_Copy.Name = "ToolStrip_Top_Edit_Copy";
            this.ToolStrip_Top_Edit_Copy.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_Copy.Text = "Copy";
            this.ToolStrip_Top_Edit_Copy.Click += new System.EventHandler(this.ToolStrip_Top_Edit_Copy_Click);
            // 
            // ToolStrip_Top_Edit_Paste
            // 
            this.ToolStrip_Top_Edit_Paste.Name = "ToolStrip_Top_Edit_Paste";
            this.ToolStrip_Top_Edit_Paste.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_Paste.Text = "Paste";
            this.ToolStrip_Top_Edit_Paste.Click += new System.EventHandler(this.ToolStrip_Top_Edit_Paste_Click);
            // 
            // ToolStrip_Top_Edit_Seperator1
            // 
            this.ToolStrip_Top_Edit_Seperator1.Name = "ToolStrip_Top_Edit_Seperator1";
            this.ToolStrip_Top_Edit_Seperator1.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStrip_Top_Edit_CopyHex
            // 
            this.ToolStrip_Top_Edit_CopyHex.Name = "ToolStrip_Top_Edit_CopyHex";
            this.ToolStrip_Top_Edit_CopyHex.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_CopyHex.Text = "Copy Hex";
            this.ToolStrip_Top_Edit_CopyHex.Click += new System.EventHandler(this.ToolStrip_Top_Edit_CopyHex_Click);
            // 
            // ToolStrip_Top_Edit_PasteHex
            // 
            this.ToolStrip_Top_Edit_PasteHex.Name = "ToolStrip_Top_Edit_PasteHex";
            this.ToolStrip_Top_Edit_PasteHex.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_PasteHex.Text = "Paste Hex";
            this.ToolStrip_Top_Edit_PasteHex.Click += new System.EventHandler(this.ToolStrip_Top_Edit_PasteHex_Click);
            // 
            // ToolStrip_Top_Edit_Seperator2
            // 
            this.ToolStrip_Top_Edit_Seperator2.Name = "ToolStrip_Top_Edit_Seperator2";
            this.ToolStrip_Top_Edit_Seperator2.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStrip_Top_Edit_Find
            // 
            this.ToolStrip_Top_Edit_Find.Name = "ToolStrip_Top_Edit_Find";
            this.ToolStrip_Top_Edit_Find.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_Find.Text = "Find";
            this.ToolStrip_Top_Edit_Find.Click += new System.EventHandler(this.ToolStrip_Top_Edit_Find_Click);
            // 
            // ToolStrip_Top_Edit_FindNext
            // 
            this.ToolStrip_Top_Edit_FindNext.Name = "ToolStrip_Top_Edit_FindNext";
            this.ToolStrip_Top_Edit_FindNext.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_FindNext.Text = "Find Next";
            // 
            // ToolStrip_Top_Edit_Goto
            // 
            this.ToolStrip_Top_Edit_Goto.Name = "ToolStrip_Top_Edit_Goto";
            this.ToolStrip_Top_Edit_Goto.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_Goto.Text = "Goto";
            // 
            // ToolStrip_Top_Edit_Seperator3
            // 
            this.ToolStrip_Top_Edit_Seperator3.Name = "ToolStrip_Top_Edit_Seperator3";
            this.ToolStrip_Top_Edit_Seperator3.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStrip_Top_Edit_SelectAll
            // 
            this.ToolStrip_Top_Edit_SelectAll.Name = "ToolStrip_Top_Edit_SelectAll";
            this.ToolStrip_Top_Edit_SelectAll.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_SelectAll.Text = "Select All";
            this.ToolStrip_Top_Edit_SelectAll.Click += new System.EventHandler(this.ToolStrip_Top_Edit_SelectAll_Click);
            // 
            // ToolStrip_Top_Options
            // 
            this.ToolStrip_Top_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStrip_Top_Options_Open,
            this.ToolStrip_Top_Options_Apply});
            this.ToolStrip_Top_Options.Name = "ToolStrip_Top_Options";
            this.ToolStrip_Top_Options.Size = new System.Drawing.Size(61, 20);
            this.ToolStrip_Top_Options.Text = "Options";
            // 
            // ToolStrip_Top_Options_Open
            // 
            this.ToolStrip_Top_Options_Open.Name = "ToolStrip_Top_Options_Open";
            this.ToolStrip_Top_Options_Open.Size = new System.Drawing.Size(154, 22);
            this.ToolStrip_Top_Options_Open.Text = "Open Menu";
            this.ToolStrip_Top_Options_Open.Click += new System.EventHandler(this.ToolStrip_Top_Options_Open_Click);
            // 
            // ToolStrip_Top_Options_Apply
            // 
            this.ToolStrip_Top_Options_Apply.Name = "ToolStrip_Top_Options_Apply";
            this.ToolStrip_Top_Options_Apply.Size = new System.Drawing.Size(154, 22);
            this.ToolStrip_Top_Options_Apply.Text = "Apply Changes";
            this.ToolStrip_Top_Options_Apply.Click += new System.EventHandler(this.ToolStrip_Top_Options_Apply_Click);
            // 
            // MenuStrip_Top_Size
            // 
            this.MenuStrip_Top_Size.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuStrip_Top_Size.BackColor = System.Drawing.SystemColors.Control;
            this.MenuStrip_Top_Size.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MenuStrip_Top_Size.Enabled = false;
            this.MenuStrip_Top_Size.ForeColor = System.Drawing.Color.Black;
            this.MenuStrip_Top_Size.Name = "MenuStrip_Top_Size";
            this.MenuStrip_Top_Size.ReadOnly = true;
            this.MenuStrip_Top_Size.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MenuStrip_Top_Size.Size = new System.Drawing.Size(450, 20);
            this.MenuStrip_Top_Size.Text = "Size: 0";
            // 
            // BitControl_Hidden
            // 
            this.BitControl_Hidden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BitControl_Hidden.Enabled = false;
            this.BitControl_Hidden.Location = new System.Drawing.Point(297, 459);
            this.BitControl_Hidden.Name = "BitControl_Hidden";
            this.BitControl_Hidden.Size = new System.Drawing.Size(0, 0);
            this.BitControl_Hidden.TabIndex = 3;
            this.BitControl_Hidden.Visible = false;
            // 
            // HexBox_Main
            // 
            this.HexBox_Main.AccessibleName = "";
            this.HexBox_Main.BackColor = System.Drawing.Color.Black;
            this.HexBox_Main.BackColorDisabled = System.Drawing.Color.Black;
            this.HexBox_Main.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HexBox_Main.ColumnInfoVisible = true;
            this.HexBox_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexBox_Main.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HexBox_Main.ForeColor = System.Drawing.Color.White;
            this.HexBox_Main.HexCasing = SHex.HexCasing.Lower;
            this.HexBox_Main.LineInfoVisible = true;
            this.HexBox_Main.Location = new System.Drawing.Point(0, 24);
            this.HexBox_Main.Name = "HexBox_Main";
            this.HexBox_Main.SelectionBackColor = System.Drawing.Color.Gray;
            this.HexBox_Main.ShadowSelectionColor = System.Drawing.Color.Gray;
            this.HexBox_Main.Size = new System.Drawing.Size(644, 425);
            this.HexBox_Main.StringViewVisible = true;
            this.HexBox_Main.TabIndex = 2;
            this.HexBox_Main.VScrollBarVisible = true;
            this.HexBox_Main.SelectionStartChanged += new System.EventHandler(this.HexBox_Main_SelectionStartChanged);
            this.HexBox_Main.SelectionLengthChanged += new System.EventHandler(this.HexBox_Main_SelectionLengthChanged);
            this.HexBox_Main.CurrentLineChanged += new System.EventHandler(this.HexBox_Main_CurrentLineChanged);
            this.HexBox_Main.CurrentPositionInLineChanged += new System.EventHandler(this.HexBox_Main_CurrentPositionInLineChanged);
            this.HexBox_Main.Copied += new System.EventHandler(this.HexBox_Main_Copied);
            this.HexBox_Main.CopiedHex += new System.EventHandler(this.HexBox_Main_CopiedHex);
            // 
            // ToolStrip_Top_Edit_FindStrings
            // 
            this.ToolStrip_Top_Edit_FindStrings.Name = "ToolStrip_Top_Edit_FindStrings";
            this.ToolStrip_Top_Edit_FindStrings.Size = new System.Drawing.Size(152, 22);
            this.ToolStrip_Top_Edit_FindStrings.Text = "Strings";
            this.ToolStrip_Top_Edit_FindStrings.Click += new System.EventHandler(this.ToolStrip_Top_Edit_FindStrings_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(644, 471);
            this.Controls.Add(this.BitControl_Hidden);
            this.Controls.Add(this.HexBox_Main);
            this.Controls.Add(this.StatusStrip_Bottom);
            this.Controls.Add(this.MenuStrip_Top);
            this.MainMenuStrip = this.MenuStrip_Top;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "SHex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.StatusStrip_Bottom.ResumeLayout(false);
            this.StatusStrip_Bottom.PerformLayout();
            this.MenuStrip_Top.ResumeLayout(false);
            this.MenuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip_Bottom;
        private System.Windows.Forms.MenuStrip MenuStrip_Top;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_File_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_File_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_File_Close;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_Cut;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_Copy;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_Paste;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Top_Edit_Seperator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_CopyHex;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_PasteHex;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Top_Edit_Seperator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_Find;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_FindNext;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_Goto;
        private System.Windows.Forms.ToolStripSeparator ToolStrip_Top_Edit_Seperator3;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_SelectAll;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_Label_LnCol;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Options;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Options_Apply;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Options_Open;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_Label_Blank;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_Label_Bit;
        private System.Windows.Forms.ToolStripStatusLabel StatusStrip_Bottom_Label_Value;
        private System.Windows.Forms.ToolStripTextBox MenuStrip_Top_Size;
        private Be.HexEditor.BitControl BitControl_Hidden;
        private HexBox HexBox_Main;
        private System.Windows.Forms.ToolStripMenuItem ToolStrip_Top_Edit_FindStrings;


    }
}

