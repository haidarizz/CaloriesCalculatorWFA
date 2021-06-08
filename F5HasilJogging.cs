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
    public partial class F5HasilJogging : Form
    {
        double bmi;
        double velo;
        double CaloriesBurned;
        double hours;
        string name2;

        public F5HasilJogging(string name, int weight, int height, int age, int sex, 
            int time, string when, double distance)
        {
            InitializeComponent();

            name2 = name;

            BasicInformation information = new BasicInformation(name, weight, height, age, sex);
            bmi = information.CalculateBMI(weight, height);

            Jogging jogging = new Jogging(when, time, distance);
            hours = time / 60;
            velo = jogging.CalculateVelocity(distance, hours);
            CaloriesBurned = jogging.CalculateCaloriesBurned(bmi, distance, velo);
            lbActivity.Text =  jogging.ShowActivity(name, velo);
            lbRecommendation.Text = jogging.ShowRecommendation(CaloriesBurned);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            F6Thanks f6Thanks = new F6Thanks(name2);
            f6Thanks.ShowDialog();
        }
    }
}
