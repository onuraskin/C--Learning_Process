using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İfElseExamps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tutar, indirim;
            int kitapadet = Convert.ToInt16(textBox1.Text);
            if (kitapadet >= 0 && kitapadet >= 20)
            {
                tutar = kitapadet * 10;
                indirim = (tutar * 20) / 100;
                tutar = tutar - indirim;
                label2.Text = "İndirim : % 20 ";
                label3.Text = " Tutar : " + tutar;
            }
            if (kitapadet >= 21 && kitapadet >= 40)
            {
                tutar = kitapadet * 10;
                indirim = (tutar * 40) / 100;
                tutar = tutar - indirim;
                label2.Text = "İndirim : % 40 ";
                label3.Text = " Tutar : " + tutar;
            }
            if (kitapadet >= 41)
            {
                tutar = kitapadet * 10;
                indirim = (tutar * 50) / 100;
                tutar = tutar - indirim;
                label2.Text = "İndirim : % 50 ";
                label3.Text = " Tutar : " + tutar;
            }
        }
    }
}

