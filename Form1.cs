using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_uygörn5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, toplam, fark, çarpım, bölme;
            sayi1 = Convert.ToInt32(textsayi1.Text);
            sayi2 = Convert.ToInt32(textsayi2.Text);
            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2;
            çarpım = sayi1 * sayi2;
            bölme = sayi1 / sayi2;

            texttoplam.Text = toplam.ToString();
            textfark.Text = fark.ToString();
            textçarpım.Text = çarpım.ToString();
            textbölme.Text = bölme.ToString("0.00");

            MessageBox.Show("Toplam:" + toplam + "\n"+
                                "Fark:" + fark + "\n"+
                                "çarpım:" + çarpım + "\n"+
                                "bölme:" + bölme + "\n"
                );
        }
    }
}
