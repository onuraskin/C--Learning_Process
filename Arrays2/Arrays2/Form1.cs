using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] workers = { "Ali", "Veli", "Mehmet", "Aişe", "Şanzıments" };
            for (int i = 0; i < workers.Length; i++)
            {
                listBox1.Items.Add(workers[i]);
            }
        }
    }
}
