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
    public partial class F3PilihAksi : Form
    {
        string name2;
        int weight2;
        int height2;
        int age2;
        int sex2;

        public F3PilihAksi(string name, int weight, int height, int age, int sex)
        {
            InitializeComponent();
            name2 = name;
            weight2 = weight;
            height2 = height;
            age2 = age;
            sex2 = sex;
        }

        private void btHKR_Click(object sender, EventArgs e)
        {
            this.Hide();
            F4Rekomendasi f4Rekomendasi = new F4Rekomendasi(name2, weight2, height2, age2, sex2);
            f4Rekomendasi.ShowDialog();
        }

        private void btCJ_Click(object sender, EventArgs e)
        {
            this.Hide();
            F4Jogging f4Jogging = new F4Jogging(name2, weight2, height2, age2, sex2);
            f4Jogging.ShowDialog();
        }

        private void btCS_Click(object sender, EventArgs e)
        {
            this.Hide();
            F4Swimming f4Swimming = new F4Swimming(name2, weight2, height2, age2, sex2);
            f4Swimming.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
