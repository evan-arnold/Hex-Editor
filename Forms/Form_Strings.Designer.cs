namespace SHex.Forms
{
    partial class Form_Strings
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
            this.ListView_Strings = new System.Windows.Forms.ListView();
            this.ComlumnHeader_StringNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ComlumnHeader_String = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListView_Strings
            // 
            this.ListView_Strings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ComlumnHeader_StringNumber,
            this.ComlumnHeader_String});
            this.ListView_Strings.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListView_Strings.Location = new System.Drawing.Point(0, 0);
            this.ListView_Strings.Name = "ListView_Strings";
            this.ListView_Strings.Size = new System.Drawing.Size(627, 222);
            this.ListView_Strings.TabIndex = 0;
            this.ListView_Strings.UseCompatibleStateImageBehavior = false;
            this.ListView_Strings.View = System.Windows.Forms.View.Details;
            // 
            // ComlumnHeader_StringNumber
            // 
            this.ComlumnHeader_StringNumber.Text = "#";
            // 
            // ComlumnHeader_String
            // 
            this.ComlumnHeader_String.Text = "String";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 180);
            this.textBox1.TabIndex = 1;
            // 
            // Form_Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ListView_Strings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Strings";
            this.Text = "SHex - Strings";
            this.Load += new System.EventHandler(this.Form_Strings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ListView_Strings;
        private System.Windows.Forms.ColumnHeader ComlumnHeader_StringNumber;
        private System.Windows.Forms.ColumnHeader ComlumnHeader_String;
        private System.Windows.Forms.TextBox textBox1;


    }
}