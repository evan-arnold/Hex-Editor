using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHex.Forms
{
    public partial class Form_Strings : Form
    {
        string HexBoxText;

        public Form_Strings()
        {
            InitializeComponent();
        }

        private void Form_Strings_Load(object sender, EventArgs e)
        {
            StreamReader streamReader = new StreamReader(Variables.FilePath);
            string lol = streamReader.ReadToEnd();
            textBox1.Text = lol;
            streamReader.Close();
        }
    }
}
