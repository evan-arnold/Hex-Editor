using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHex.Forms
{
    public partial class Form_Options : Form
    {
        #region Variables & Initilization
        Color Background = Color.Black, Foreground = Color.White, InfoText = Color.Gray, 
            HighlightBack = Color.Gray, HighlightFore = Color.White;
        public Form_Options()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        private void ApplyChanges()
        {
            Variables.InfoVisible = CheckBox_InfoVisible.Checked;
            Variables.StringsVisible =  CheckBox_StringsVisible.Checked;

            Variables.Background = Background;
            Variables.Foreground = Foreground;
            Variables.InfoText = InfoText;

            Variables.HighlightBack = HighlightBack;
            Variables.HighlightFore = HighlightFore;
        }
        #endregion

        #region Events
        private void Button_ApplyChanges_Click(object sender, EventArgs e)
        {
            ApplyChanges();
            this.Hide();
        }
        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Button_ChangeColor_Click(object sender, EventArgs e)
        {
            if (ComboBox_Items.Text == "")
                return;

            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                if (ComboBox_Items.Text == "Background")
                    Background = colorDialog.Color;

                if (ComboBox_Items.Text == "Foreground")
                    Foreground = colorDialog.Color;

                if (ComboBox_Items.Text == "Info Text")
                    InfoText = colorDialog.Color;

                if (ComboBox_Items.Text == "Highlight Background")
                    HighlightBack = colorDialog.Color;

                if (ComboBox_Items.Text == "Highlight Foreground")
                    HighlightFore = colorDialog.Color;
            }
        }
        #endregion
    }
}
