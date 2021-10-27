using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] peoples = {"Ali", "Veli", "Şaban", "Ramazan", "Necmi", "Kürşat", };
            foreach (string p in peoples)
            {
                listBox1.Items.Add(p);
            }
            int[] numbers = { 75, 56, 74, 55, 67, 88 };
            foreach (int x in numbers)
            {
                    listBox1.Items.Add(x);
            }
            }
        }
    }

