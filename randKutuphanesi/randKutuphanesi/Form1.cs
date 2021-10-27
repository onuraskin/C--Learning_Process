using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace randKutuphanesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random x = new Random();
            int sayi;
            sayi = x.Next(1,6);//ilk değer geçerli sonu kapsamıyor 1-10 aralığı
            int sayi2 = x.Next(1,6);
            int sayi3 = x.Next(1,6);
            label1.Text = sayi.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            textBox1.Text = sayi.ToString();
            textBox1.Text = sayi2.ToString();
            textBox1.Text = sayi2.ToString();
            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }


        }
    }
}
