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
    public partial class F4Swimming : Form
    {
        int time;
        string when;
        string name2;
        int weight2;
        int height2;
        int age2;
        int sex2;

        public F4Swimming(string name, int weight, int height, int age, int sex)
        {
            InitializeComponent();
            name2 = name;
            weight2 = weight;
            height2 = height;
            age2 = age;
            sex2 = sex;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            time = Convert.ToInt32(tbTime.Text);
            when = tbWhen.Text;

            F5HasilSwimming f5HasilSwimming = new F5HasilSwimming(name2, weight2, 
                height2, age2, sex2, time, when);
            f5HasilSwimming.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
