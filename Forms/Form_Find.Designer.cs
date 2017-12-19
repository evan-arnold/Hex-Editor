namespace SHex.Forms
{
    partial class Form_Find
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
            this.RadioButton_Text = new System.Windows.Forms.RadioButton();
            this.TextBox_Text = new System.Windows.Forms.TextBox();
            this.CheckBox_Case = new System.Windows.Forms.CheckBox();
            this.RadioButton_Hex = new System.Windows.Forms.RadioButton();
            this.HexBox_Hex = new SHex.HexBox();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Find = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RadioButton_Text
            // 
            this.RadioButton_Text.AutoSize = true;
            this.RadioButton_Text.Checked = true;
            this.RadioButton_Text.Location = new System.Drawing.Point(12, 9);
            this.RadioButton_Text.Name = "RadioButton_Text";
            this.RadioButton_Text.Size = new System.Drawing.Size(49, 17);
            this.RadioButton_Text.TabIndex = 0;
            this.RadioButton_Text.TabStop = true;
            this.RadioButton_Text.Text = "Text:";
            this.RadioButton_Text.UseVisualStyleBackColor = true;
            // 
            // TextBox_Text
            // 
            this.TextBox_Text.Location = new System.Drawing.Point(12, 32);
            this.TextBox_Text.Name = "TextBox_Text";
            this.TextBox_Text.Size = new System.Drawing.Size(470, 20);
            this.TextBox_Text.TabIndex = 1;
            // 
            // CheckBox_Case
            // 
            this.CheckBox_Case.AutoSize = true;
            this.CheckBox_Case.Location = new System.Drawing.Point(399, 10);
            this.CheckBox_Case.Name = "CheckBox_Case";
            this.CheckBox_Case.Size = new System.Drawing.Size(83, 17);
            this.CheckBox_Case.TabIndex = 2;
            this.CheckBox_Case.Text = "Match Case";
            this.CheckBox_Case.UseVisualStyleBackColor = true;
            // 
            // RadioButton_Hex
            // 
            this.RadioButton_Hex.AutoSize = true;
            this.RadioButton_Hex.Location = new System.Drawing.Point(12, 58);
            this.RadioButton_Hex.Name = "RadioButton_Hex";
            this.RadioButton_Hex.Size = new System.Drawing.Size(47, 17);
            this.RadioButton_Hex.TabIndex = 3;
            this.RadioButton_Hex.Text = "Hex:";
            this.RadioButton_Hex.UseVisualStyleBackColor = true;
            // 
            // HexBox_Hex
            // 
            this.HexBox_Hex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HexBox_Hex.Location = new System.Drawing.Point(12, 81);
            this.HexBox_Hex.Name = "HexBox_Hex";
            this.HexBox_Hex.ShadowSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(60)))), ((int)(((byte)(188)))), ((int)(((byte)(255)))));
            this.HexBox_Hex.Size = new System.Drawing.Size(470, 132);
            this.HexBox_Hex.TabIndex = 4;
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(250, 219);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(232, 23);
            this.Button_Cancel.TabIndex = 5;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            // 
            // Button_Find
            // 
            this.Button_Find.Location = new System.Drawing.Point(12, 219);
            this.Button_Find.Name = "Button_Find";
            this.Button_Find.Size = new System.Drawing.Size(232, 23);
            this.Button_Find.TabIndex = 6;
            this.Button_Find.Text = "Find";
            this.Button_Find.UseVisualStyleBackColor = true;
            this.Button_Find.Click += new System.EventHandler(this.Button_Find_Click);
            // 
            // Form_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 247);
            this.Controls.Add(this.Button_Find);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.HexBox_Hex);
            this.Controls.Add(this.RadioButton_Hex);
            this.Controls.Add(this.CheckBox_Case);
            this.Controls.Add(this.TextBox_Text);
            this.Controls.Add(this.RadioButton_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Find";
            this.Text = "SHex - Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadioButton_Text;
        private System.Windows.Forms.TextBox TextBox_Text;
        private System.Windows.Forms.CheckBox CheckBox_Case;
        private System.Windows.Forms.RadioButton RadioButton_Hex;
        private HexBox HexBox_Hex;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Find;
    }
}