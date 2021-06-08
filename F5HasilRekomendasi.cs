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
    public partial class F5HasilRekomendasi : Form
    {
        double bmi;
        double bmr;
        double CaloriesNeeded;
        string name2;

        public F5HasilRekomendasi(string name, int weight, int height, int age, int sex, int freq)
        {
            InitializeComponent();

            name2 = name;

            BasicInformation information = new BasicInformation(name, weight, height, age, sex);
            bmi = information.CalculateBMI(weight, height);
            bmr = information.CalculateBMR(weight, height, age, sex);
            CaloriesNeeded = information.CalculateCaloriesNeeded(bmr, freq);

            lbShowBMI.Text = information.ShowBMI(bmi);
            lbShowBMR.Text = information.ShowBMR(bmr, CaloriesNeeded);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            F6Thanks f6Thanks = new F6Thanks(name2);
            f6Thanks.ShowDialog();
        }
    }
}
