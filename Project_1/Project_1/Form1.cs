﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            buttonSonraki.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbl_Doğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lbl_Yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
       

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            buttonSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbl_Doğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lbl_Yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            buttonSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbl_Doğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lbl_Yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            buttonSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                Lbl_Doğru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                Lbl_Yanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        int soruno = 0, dogru = 0, yanlis = 0;
        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            buttonSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruno++;
            Lbl_Soru.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ? ";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923";
            }
            if (soruno == 2)
                {
                    richTextBox1.Text = "Hangisi Ege Bölgesinde bulunmaz ? ";
                    BtnA.Text = "Aydın";
                    BtnB.Text = "İzmir";
                    BtnC.Text = "Manisa";
                    BtnD.Text = "Antalya";
                    label4.Text = "Antalya";
            }
            if (soruno == 3)
                {
                    richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir  ? ";
                    BtnA.Text = "Sait Faik";
                    BtnB.Text = "Cemal Süreya";
                    BtnC.Text = "Atilla İlhan";
                    BtnD.Text = "Reşat Nuri";
                    label4.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir  ? ";
                buttonSonraki.Text = "Sonuçlar ->";
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                buttonSonraki.Enabled = false;
                MessageBox.Show("dogru : "+dogru 
                    +"\n"+" Yanlış : "+yanlis);

            }

        }
    }
    }

