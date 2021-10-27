using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Methods2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int kare()
        {
            int x = Convert.ToInt32(textBox1.Text);
            
            return x*x;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(kare());
        }
    }
}
