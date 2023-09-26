using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace verituru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textSayi1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int not1, not2;
            double sonuc;

            not1 = Convert.ToInt32(textSayi1.Text);
            not2 = Convert.ToInt32(txtSayi2.Text);

            sonuc = (not1 + not2) / 2;

            lblSonuc.Text = sonuc.ToString();

        }
    }
}
