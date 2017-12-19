namespace SHex.Forms
{
    partial class Form_Options
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
            this.Label_Colours = new System.Windows.Forms.Label();
            this.ComboBox_Items = new System.Windows.Forms.ComboBox();
            this.Button_ChangeColor = new System.Windows.Forms.Button();
            this.CheckBox_InfoVisible = new System.Windows.Forms.CheckBox();
            this.CheckBox_StringsVisible = new System.Windows.Forms.CheckBox();
            this.Button_ApplyChanges = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Colours
            // 
            this.Label_Colours.AutoSize = true;
            this.Label_Colours.Location = new System.Drawing.Point(7, 10);
            this.Label_Colours.Name = "Label_Colours";
            this.Label_Colours.Size = new System.Drawing.Size(45, 13);
            this.Label_Colours.TabIndex = 0;
            this.Label_Colours.Text = "Colours:";
            // 
            // ComboBox_Items
            // 
            this.ComboBox_Items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_Items.FormattingEnabled = true;
            this.ComboBox_Items.Items.AddRange(new object[] {
            "Background",
            "Foreground",
            "Info Text",
            "Highlight Background",
            "Highlight Foreground"});
            this.ComboBox_Items.Location = new System.Drawing.Point(54, 6);
            this.ComboBox_Items.Name = "ComboBox_Items";
            this.ComboBox_Items.Size = new System.Drawing.Size(191, 21);
            this.ComboBox_Items.TabIndex = 1;
            // 
            // Button_ChangeColor
            // 
            this.Button_ChangeColor.Location = new System.Drawing.Point(251, 5);
            this.Button_ChangeColor.Name = "Button_ChangeColor";
            this.Button_ChangeColor.Size = new System.Drawing.Size(63, 23);
            this.Button_ChangeColor.TabIndex = 2;
            this.Button_ChangeColor.Text = "Change";
            this.Button_ChangeColor.UseVisualStyleBackColor = true;
            this.Button_ChangeColor.Click += new System.EventHandler(this.Button_ChangeColor_Click);
            // 
            // CheckBox_InfoVisible
            // 
            this.CheckBox_InfoVisible.AutoSize = true;
            this.CheckBox_InfoVisible.Checked = true;
            this.CheckBox_InfoVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_InfoVisible.Location = new System.Drawing.Point(10, 33);
            this.CheckBox_InfoVisible.Name = "CheckBox_InfoVisible";
            this.CheckBox_InfoVisible.Size = new System.Drawing.Size(116, 17);
            this.CheckBox_InfoVisible.TabIndex = 3;
            this.CheckBox_InfoVisible.Text = "Information Visisble";
            this.CheckBox_InfoVisible.UseVisualStyleBackColor = true;
            // 
            // CheckBox_StringsVisible
            // 
            this.CheckBox_StringsVisible.AutoSize = true;
            this.CheckBox_StringsVisible.Checked = true;
            this.CheckBox_StringsVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_StringsVisible.Location = new System.Drawing.Point(223, 33);
            this.CheckBox_StringsVisible.Name = "CheckBox_StringsVisible";
            this.CheckBox_StringsVisible.Size = new System.Drawing.Size(91, 17);
            this.CheckBox_StringsVisible.TabIndex = 4;
            this.CheckBox_StringsVisible.Text = "Strings Visible";
            this.CheckBox_StringsVisible.UseVisualStyleBackColor = true;
            // 
            // Button_ApplyChanges
            // 
            this.Button_ApplyChanges.Location = new System.Drawing.Point(10, 56);
            this.Button_ApplyChanges.Name = "Button_ApplyChanges";
            this.Button_ApplyChanges.Size = new System.Drawing.Size(148, 23);
            this.Button_ApplyChanges.TabIndex = 5;
            this.Button_ApplyChanges.Text = "Apply";
            this.Button_ApplyChanges.UseVisualStyleBackColor = true;
            this.Button_ApplyChanges.Click += new System.EventHandler(this.Button_ApplyChanges_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(164, 56);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(150, 23);
            this.Button_Cancel.TabIndex = 6;
            this.Button_Cancel.Text = "Close";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Form_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 84);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_ApplyChanges);
            this.Controls.Add(this.CheckBox_StringsVisible);
            this.Controls.Add(this.CheckBox_InfoVisible);
            this.Controls.Add(this.Button_ChangeColor);
            this.Controls.Add(this.ComboBox_Items);
            this.Controls.Add(this.Label_Colours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Options";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "SHex - Options";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Colours;
        private System.Windows.Forms.ComboBox ComboBox_Items;
        private System.Windows.Forms.Button Button_ChangeColor;
        private System.Windows.Forms.CheckBox CheckBox_InfoVisible;
        private System.Windows.Forms.CheckBox CheckBox_StringsVisible;
        private System.Windows.Forms.Button Button_ApplyChanges;
        private System.Windows.Forms.Button Button_Cancel;
    }
}