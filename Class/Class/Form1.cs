using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            araba wolkswogen = new araba();
            wolkswogen.renk = "Mavi";
            wolkswogen.hız = 200;
            wolkswogen.fiyat = 74;
            wolkswogen.motorgüc = 1245.56;
            wolkswogen.durum = 's';
            wolkswogen.YIL = -2015;
            wolkswogen.Markasi = "audi";
            wolkswogen.muayene = 2017;
            wolkswogen.plaka = "35 HJA 04";
            wolkswogen.sahip = "Zübeyde Turgut ";
           
            label1.Text = wolkswogen.renk;
            label2.Text = Convert.ToString(wolkswogen.hız);  
            label3.Text = Convert.ToString(wolkswogen.fiyat); 
            label4.Text = Convert.ToString(wolkswogen.motorgüc); 
            label5.Text = Convert.ToString(wolkswogen.durum);
            label7.Text = Convert.ToString(wolkswogen.YIL);
            label8.Text = wolkswogen.Markasi.ToString();
            label9.Text = wolkswogen.muayene.ToString();
            label10.Text = wolkswogen.plaka;
            label11.Text = wolkswogen.sahip;
            pictureBox1.BackColor = Color.CadetBlue;



        }
    }
}
