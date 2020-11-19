using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DortIslem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi1.Text);
            double sayi2 = double.Parse(txtsayi2.Text);
            MessageBox.Show("sonuc :"+ (sayi1 + sayi2));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi1.Text);
            double sayi2 = double.Parse(txtsayi2.Text);
            MessageBox.Show("sonuc :" + (sayi1 - sayi2));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi1.Text);
            double sayi2 = double.Parse(txtsayi2.Text);
            MessageBox.Show("sonuc :" + (sayi1 / sayi2));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double sayi1 = double.Parse(txtsayi1.Text);
            double sayi2 = double.Parse(txtsayi2.Text);
            MessageBox.Show("sonuc :" + (sayi1 * sayi2));
        }
    }
}
