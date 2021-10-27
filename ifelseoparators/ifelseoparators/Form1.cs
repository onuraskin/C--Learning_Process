using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifelseoparators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, s3, ort;
            s1 = Convert.ToDouble(textBox1.Text);
            s2 = Convert.ToDouble(textBox2.Text);
            s3 = Convert.ToDouble(textBox3.Text);
            ort = (s1 + s2 + s3) / 3;
            if (checkBox1.Checked!=true && ort>=50)
            {
                label4.Text = ("Ders Başarılı . ! \n"+"Ortalama : "+ort.ToString());
            }
            else
            {
                label4.Text = ("Kaldı Devamsızlık yada 50 altı ortalama ");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
