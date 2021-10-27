using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variable_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
        int kasa;
        private void button1_Click(object sender, EventArgs e)
        {
            int misir, toplam,bilet,su,cay;
            misir = Convert.ToInt16(TxtMisir.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            su = Convert.ToInt16(TxtSu.Text);
            cay = Convert.ToInt16(TxtCay.Text);
            toplam = misir * 4 + su * 1 + cay * 2+ bilet * 8;
            txtToplam.Text = toplam.ToString()+ "TL ";
            kasa = kasa + toplam;
            txtKasa.Text = kasa.ToString()+"TL ";
        }
    }
}
