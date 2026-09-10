using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sky
{
    

    public partial class Form1 : Form
    {
        private Image i; Bitmap b;int maxstar = 400; int value = 0; int value2 = 0; int xx = 0; int yy = 0; Graphics ee;int[] starx = new int[400]; int[] stary = new int[400];int maxx = 0;int maxy = 0;int halfx=0;int halfy = 0;int ax = 0;int ay=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == 0)
            {

                int v = value & 1;

                ee = Graphics.FromImage(b);
                Pen a = new Pen(Color.FromArgb(0, 0, 0));
                Pen c = new Pen(Color.FromArgb(0, 0, 255));
                SolidBrush rBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
                ee.Clear(Color.FromArgb(0, 0, 255));
                for (int i = 0; i < maxstar; i++)
                {
                    ee.FillRectangle(rBrush,new Rectangle(starx[i]-ax-e.X, stary[i]-ay-e.Y,4,4));
                }
                
                a.Dispose();
                c.Dispose();
                ee.Dispose();
                rBrush.Dispose();
                pictureBox1.Refresh();





            }



        }



        private void Form1_Load_1(object sender, EventArgs e)
        {
            Random r = new Random();
            maxx= pictureBox1.Width*4; maxy = pictureBox1.Height*4;
            halfx= pictureBox1.Width/8; halfy= pictureBox1.Height/8;
            ax= pictureBox1.Width/4;ay= pictureBox1.Height/4;
            for (int i = 0; i < maxstar; i++)
            {
                starx[i] = r.Next(maxx);
                stary[i] = r.Next(maxy);
            
            }
            
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = b;
            int v = value & 1;

            ee = Graphics.FromImage(b);
            Pen a = new Pen(Color.FromArgb(0, 0, 0));
            Pen c = new Pen(Color.FromArgb(0, 0, 255));
            SolidBrush rBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
            ee.Clear(Color.FromArgb(0, 0, 255));
            for (int i = 0; i < maxstar; i++)
            {
                ee.FillRectangle(rBrush, new Rectangle(starx[i] - ax, stary[i] - ay, 4, 4));
            }
            
            a.Dispose();
            c.Dispose();
            ee.Dispose();
            rBrush.Dispose();
            pictureBox1.Refresh();

        }
    }


}

