using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = { 1,2,3,4,5,6,7,8,9,10};
            label1.Text = " ";
            for (int i = 0; i < numbers.Length; i++)
            {
                
                label1.Text += numbers[i].ToString();
            }
        }
    }
}
