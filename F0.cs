using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCWFA
{
    public partial class F0 : Form
    {
        public F0()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1InputData inputData = new F1InputData();
            inputData.ShowDialog();
        }
    }
}
