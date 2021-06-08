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
    public partial class F4Rekomendasi : Form
    {
        int freq;
        string name2;
        int weight2;
        int height2;
        int age2;
        int sex2;

        public F4Rekomendasi(string name, int weight, int height, int age, int sex)
        {
            InitializeComponent();
            
            name2 = name;
            weight2 = weight;
            height2 = height;
            age2 = age;
            sex2 = sex;

        }
        private void InputFreq()
        {
            freq = Convert.ToInt32(tbFreq.Text);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            InputFreq();
            F5HasilRekomendasi f5HasilRekomendasi = new F5HasilRekomendasi(name2, weight2, height2, age2, sex2, freq);
            f5HasilRekomendasi.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
