using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oparators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(textBox1.Text);
            if (number>10 && number%2==0 )
            {
                label1.Text = "10 dan büyük ve çift";
            }
            else
            {
                label1.Text = "10dan büyük değil yada çift değil";
            }
        }

    }
}
