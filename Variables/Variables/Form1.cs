using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                String isim = textBox1.Text;
                String soyad = textBox1.Text;
                String yas = maskedTextBox1.Text;
                String tc = maskedTextBox2.Text;
                listBox1.Items.Add("İsim : " + isim + " Soyad : " + soyad + " Yaş : " + yas + " TC : " + tc);

            }
           
        }
    }
}
