using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

                sayac++;
                label1.Text = sayac.ToString();
            if (sayac %2==0 ) {
                
                this.BackColor = Color.PeachPuff;
            }
            if (sayac%5==0)
            {
                this.BackColor = Color.LightCyan;

            }
            if (sayac % 7 == 0)
            {
                this.BackColor = Color.LightCyan;

            }
            if (sayac % 11 == 0)
            {
                this.BackColor = Color.LightCyan;

            }
        }
    }

}
