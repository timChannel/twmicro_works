using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pysslaformer
{
    public partial class SizeDialog : Form
    {
        public SizeDialog()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Info.Width = Convert.ToInt32(numericUpDown1.Value);
            Info.Height = Convert.ToInt32(numericUpDown2.Value);
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
