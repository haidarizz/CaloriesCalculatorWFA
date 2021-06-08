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
    public partial class F5HasilSwimming : Form
    {
        double bmi;
        double CaloriesBurned;
        string name2;

        public F5HasilSwimming(string name, int weight, int height, int age, int sex, int time, string when)
        {
            InitializeComponent();

            name2 = name;

            BasicInformation information = new BasicInformation(name, weight, height, age, sex);
            bmi = information.CalculateBMI(weight, height);

            Swimming swimming = new Swimming(when, time);
            CaloriesBurned = swimming.CalculateCaloriesBurned(bmi, time);
            lbActivity.Text = swimming.ShowActivity(name);
            lbRecommendation.Text = swimming.ShowRecommendation(CaloriesBurned);

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            F6Thanks f6Thanks = new F6Thanks(name2);
            f6Thanks.ShowDialog();
        }
    }
}
