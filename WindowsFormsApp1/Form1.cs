using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Location sets
        int pl1;
        int pl2;
        int pl3;
        Point pt1 = new Point(12,12);
        Point pt2 = new Point(12,93);
        Point pt3 = new Point(12,174);
        Point pt4 = new Point(12,255);
        Point pt5 = new Point(12,336);
        Point pt6 = new Point(12,417);
        Point pt7 = new Point(93,12);
        Point pt8 = new Point(93,93);
        Point pt9 = new Point(93,174);
        Point pt10 = new Point(93,255);
        Point pt11 = new Point(93,336);
        Point pt12 = new Point(93,417);
        Point pt13 = new Point(174,12);
        Point pt14 = new Point(174,93);
        Point pt15 = new Point(174,174);
        Point pt16 = new Point(174,255);
        Point pt17 = new Point(174,336);
        Point pt18 = new Point(174,417);
        Point pt19 = new Point(255,12);
        Point pt20 = new Point(255,93);
        Point pt21 = new Point(255,174);
        Point pt22 = new Point(255,336);
        Point pt23 = new Point(255,417);
        Point pt24 = new Point(336,12);
        Point pt25 = new Point(336,93);
        Point pt26 = new Point(336,174);
        Point pt27 = new Point(336,255);
        Point pt28 = new Point(336,336);
        Point pt29 = new Point(336,417);
        Point pt30 = new Point(417, 12);
        Point pt31 = new Point(417, 93);
        Point pt32 = new Point(417, 147);
        Point pt33 = new Point(417, 255);
        Point pt34 = new Point(417, 336);
        Point pt35 = new Point(417, 417);

        //point couter
        int point;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            point = point + 1000;
            Random r1 = new Random();
            int p1 = r1.Next(1, 35);
            if (p1 == 1)
            {
                pictureBox1.Location = pt1;
            }
            if (p1 == 2)
            {
                pictureBox1.Location = pt2;
            }
            if (p1 == 3)
            {
                pictureBox1.Location = pt3;
            }
            if (p1 == 4)
            {
                pictureBox1.Location = pt4;
            }
            if (p1 == 5)
            {
                pictureBox1.Location = pt5;
            }
            if (p1 == 6)
            {
                pictureBox1.Location = pt6;
            }
            if (p1 == 7)
            {
                pictureBox1.Location = pt7;
            }
            if (p1 == 8)
            {
                pictureBox1.Location = pt8;
            }
            if (p1 == 9)
            {
                pictureBox1.Location = pt9;
            }
            if (p1 == 10)
            {
                pictureBox1.Location = pt10;
            }
            if (p1 == 11)
            {
                pictureBox1.Location = pt11;
            }
            if (p1 == 12)
            {
                pictureBox1.Location = pt12;
            }
            if (p1 == 13)
            {
                pictureBox1.Location = pt13;
            }
            if (p1 == 14)
            {
                pictureBox1.Location = pt14;
            }
            if (p1 == 15)
            {
                pictureBox1.Location = pt15;
            }
            if (p1 == 16)
            {
                pictureBox1.Location = pt16;
            }
            if (p1 == 17)
            {
                pictureBox1.Location = pt17;
            }
            if (p1 == 18)
            {
                pictureBox1.Location = pt18;
            }
            if (p1 == 19)
            {
                pictureBox1.Location = pt19;
            }
            if (p1 == 20)
            {
                pictureBox1.Location = pt20;
            }
            if (p1 == 21)
            {
                pictureBox1.Location = pt21;
            }
            if (p1 == 22)
            {
                pictureBox1.Location = pt22;
            }
            if (p1 == 23)
            {
                pictureBox1.Location = pt23;
            }
            if (p1 == 24)
            {
                pictureBox1.Location = pt24;
            }
            if (p1 == 25)
            {
                pictureBox1.Location = pt25;
            }
            if (p1 == 26)
            {
                pictureBox1.Location = pt26;
            }
            if (p1 == 27)
            {
                pictureBox1.Location = pt27;
            }
            if (p1 == 28)
            {
                pictureBox1.Location = pt28;
            }
            if (p1 == 29)
            {
                pictureBox1.Location = pt29;
            }
            if (p1 == 30)
            {
                pictureBox1.Location = pt30;
            }
            if (p1 == 31)
            {
                pictureBox1.Location = pt31;
            }
            if (p1 == 32)
            {
                pictureBox1.Location = pt32;
            }
            if (p1 == 33)
            {
                pictureBox1.Location = pt33;
            }
            if (p1 == 34)
            {
                pictureBox1.Location = pt34;
            }
            if (p1 == 35)
            {
                pictureBox1.Location = pt35;
            }

        }
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
