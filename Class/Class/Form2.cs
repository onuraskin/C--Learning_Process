using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            araba Bmw = new araba();
            Bmw.renk = "Black";
            Bmw.fiyat = 24;
            Bmw.durum = 'i';
            Bmw.motorgüc =2234.56;
            Bmw.hız = 290;
            label1.Text = Bmw.renk;
            label2.Text = Bmw.fiyat.ToString();
            label3.Text = Bmw.durum.ToString();
            label4.Text = Bmw.motorgüc.ToString();
            label5.Text = Bmw.hız.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
