using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace sky
{
        partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(798, 438);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
    }


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
                ee.Clear(Color.FromArgb(255, 255, 255));
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
            ee.Clear(Color.FromArgb(255, 255, 255));
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }


}

