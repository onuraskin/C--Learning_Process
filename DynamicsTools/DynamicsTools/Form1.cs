using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicsTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            /*Point loc = new Point(20,10);
            btn.Location = loc;
            btn.Name = "Button 1";
            btn.Text = "Click";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 50;
            this.Controls.Add(btn);*/

            Label lbl = new Label();
            Point loc2 = new Point(250,15);
            lbl.Location = loc2;
            lbl.Text = "Hi Dude :/";
            lbl.BackColor = Color.Yellow;
            lbl.Height = 150;
            lbl.Width = 200;
            this.Controls.Add(lbl);
            lbl.AutoSize = true;

           
            
            
            for (int i = 1; i <= 5; i++)
            {
                TextBox texs = new TextBox();
                Point loc3 = new Point(300,i*50);
                texs.Location = loc3;
                texs.Name = "Textbox" + i;
                texs.Text = ("Textbox ---->" + "[" + i + "]").ToString();
                texs.BackColor = Color.Green;
                texs.Height = 150;
                texs.Width = 150;
                this.Controls.Add(texs);
                




            }
        }
    }
}
