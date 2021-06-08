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
    public partial class F6Thanks : Form
    {
        public F6Thanks(string name)
        {
            InitializeComponent();
            lbThanks.Text = "Terima Kasih" + "\n" + name + "!";

            Bitmap qr;
            textBox1.Text = QRManager.GenerateInfo(name, "Terima kasih", out qr);
            pbQR.BackgroundImage = qr;
        }
    }
}
