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
    public partial class F4Jogging : Form
    {
        int time;
        string when;
        double distance;
        string name2;
        int weight2;
        int height2;
        int age2;
        int sex2;

        public F4Jogging(string name, int weight, int height, int age, int sex)
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
            distance = (Convert.ToInt32(tbDistance.Text))/1000;

            F5HasilJogging f5HasilJogging = new F5HasilJogging(name2, weight2, height2, 
                age2, sex2, time, when, distance);
            f5HasilJogging.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
