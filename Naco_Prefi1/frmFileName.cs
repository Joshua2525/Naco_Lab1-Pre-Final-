using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naco_Prefi1
{
    public partial class FrmFileName : Form
    {
        public static string SetFileName { get; internal set; }

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            SetFileName = txtFileName + ".txt";
            Close();
        }
    }
}
