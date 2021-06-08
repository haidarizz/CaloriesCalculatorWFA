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
    public partial class F1InputData : Form
    {
        User newUser;

        public F1InputData()
        {
            InitializeComponent();
        }

        private void TambahData()
        {
            if (tbName.Text != "" && tbHeight.Text != "" && tbHeight.Text != "" && tbAge.Text != "")
            {
                if (tbSex.Text == "1" || tbSex.Text == "2")
                {
                    using (var db = new UserModel())
                    {
                        var rand = new Random();
                        newUser = new User
                        {
                            Id = rand.Next(100000000),
                            Name = tbName.Text,
                            Weight = Convert.ToInt32(tbWeight.Text),
                            Height = Convert.ToInt32(tbHeight.Text),
                            Age = Convert.ToInt32(tbAge.Text),
                            Sex = Convert.ToInt32(tbSex.Text),
                        };
                        db.Users.Add(newUser);
                        db.SaveChanges();
                        MessageBox.Show("Data Anda telah tersimpan");
                    }
                }
                else
                {
                    MessageBox.Show("Ketik 1 atau 2 untuk jenis kelamin!");
                }
            }
            else
            {
                MessageBox.Show("Isilah dengan lengkap data diri Anda!");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TambahData();
            this.Hide();
            try
            {
                F2Greeting f2Greeting = new F2Greeting(tbName.Text, Convert.ToInt32(tbWeight.Text),
                    Convert.ToInt32(tbHeight.Text), Convert.ToInt32(tbAge.Text), Convert.ToInt32(tbSex.Text));
                f2Greeting.ShowDialog();
            }
            catch (Exception)
            {

                MessageBox.Show("Pastikan anda mengisi tipe data yang benar");
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
