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
    public partial class F2Greeting : Form
    {
        string TextGreet;

        public F2Greeting(string name, int weight, int height, int age, int sex)
        {
            InitializeComponent();
            BasicInformation information = new BasicInformation(name, weight, height, age, sex);
            TextGreet = information.Greeting(name);
            lbGreeting.Text = TextGreet;
            lbName.Text = name;
            lbWeight.Text = weight.ToString();
            lbHeight.Text = height.ToString();
            lbAge.Text = age.ToString();
            if (sex == 1)
            {
                lbSex.Text = "Laki-laki";
            }
            else if (sex == 2)
            {
                lbSex.Text = "Perempuan";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            string name;
            int weight;
            int height;
            int age;
            int sex;

            name = lbName.Text;
            weight = Convert.ToInt32(lbWeight.Text);
            height = Convert.ToInt32(lbHeight.Text);
            age = Convert.ToInt32(lbAge.Text);
            if (lbSex.Text == "Laki-laki")
            {
                sex = 1;
            }
            else
            {
                sex = 2;
            }

            F3PilihAksi f3PilihAksi = new F3PilihAksi(name, weight, height, age, sex);
            f3PilihAksi.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
