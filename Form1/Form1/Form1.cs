﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Drawing2D;
using Microsoft.Win32;
using Form1.Properties;

namespace Form1
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Rectangle rect;
        private int matches;
        private int players;
        private int enemys;
        public  bool IsEven(int a)
        {
            return (a % 2) == 0;
        }
        private void Reset() 
        {
           matches = 25;
           players = 0;
           enemys = 0;
            textBox2.Text = "25";
            textBox1.Text = "0";
        }
        private void drawmatch()
        {
            Bitmap image = new Bitmap(@"H:\Match.png");
            Graphics x = this.CreateGraphics();
            x.Clear(Color.Transparent);
            for (int i = 0; i < matches; i++)
            {
                rect = new Rectangle(0 + i * 15, 50, image.Width, image.Height);
                x.DrawImage(image, rect);
            }
        }
        private void DrawImageRect(PaintEventArgs e)
        {

            // Create image.
            Image newImage = Properties.Resources.matchIMG;
            // Create rectangle for displaying image.
            Rectangle destRect = new Rectangle(400, 300, 100, 150);
           // e.Graphics.DrawRectangle(Pens.Black, destRect);
            // Draw image to screen.
            e.Graphics.DrawImage(newImage, destRect);
        }
        public Form1()
        {
            InitializeComponent();
          //  image = Properties.Resources.matchIMG;
          // rect = new Rectangle(400, 300, image.Width, image.Height);
        }
       /* private void Form_paint(object sender, PaintEventArgs e) 
        {
            Graphics g = e.Graphics;
            g.DrawImage(image, rect);
        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1 matchs taken");
            matches--;
            players++;
            textBox2.Text = matches.ToString();
            textBox1.Text = players.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2 matchs taken");
            matches = matches - 2;
            players = players + 2;
            textBox2.Text = matches.ToString();
            textBox1.Text = players.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3 matchs taken");
            matches = matches - 3;
            players = players + 3;
            textBox2.Text = matches.ToString();
            textBox1.Text = players.ToString();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /* Bitmap image = new Bitmap(@"H:\Match.png");
             Graphics x = this.CreateGraphics();
             x.Clear(Color.Transparent);
             for (int i = 0; i < matches; i++)
             {
                 rect = new Rectangle(0+i*15, 50, image.Width, image.Height);
                 x.DrawImage(image, rect);
             }*/
            drawmatch();
            if (matches < 3) button3.Enabled = false;
            if (matches < 2) button2.Enabled = false;
            if (matches < 1) button1.Enabled = false;
            if (matches <= 0) {
                if (IsEven(players) == true)
                {
                    MessageBox.Show("You won!");
                }
                else {
                    MessageBox.Show("You lose");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            drawmatch();
            button3.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
        }
    }
}
