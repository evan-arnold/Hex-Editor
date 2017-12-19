using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHex
{
    public class Methods
    {
        public static void ErrorMessage(string Body)
        {
            MessageBox.Show(Body, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
