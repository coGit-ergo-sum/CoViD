using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vi.Tools.Extensions.Random;

namespace CoViD.GUI.Butta
{
    public partial class frmCircle: Form
    {

        static Pen red = new Pen(Color.Red);
        static Pen black = new Pen(Color.Black);

        //static Pen black = new Pen(Color.Black);

        static Brush rBrush = (Brush)Brushes.Red;
        static Brush bBrush = (Brush)Brushes.Black;
        static Brush wBrush = (Brush)Brushes.White;
        static Brush gBrush = (Brush)Brushes.Gray;
        static SolidBrush bkgbrush = new SolidBrush(Color.FromArgb(255, (byte)32, (byte)32, (byte)32));

        private Color Grey74 = Color.FromArgb(74, 74, 74);

        private Color Grey32 = Color.FromArgb(32, 32, 32);


        private Color ColorAxis = Color.FromArgb(74, 74, 74);

        //static Pen Axis = new Pen(ColorAxis);
        float Radius;
        private int Border = 5;

        public static Graphics Graphics; // 
        public frmCircle()
        {
            InitializeComponent();

            //frmCircle.Graphics = pictureBox1.CreateGraphics();
        }

        private void frmCircle_Load(object sender, EventArgs e)
        {
            //this.Radius =
            //pictureBox1.Left = 10;
            //pictureBox1.Width = this.Width - 20;
            //pictureBox1.Height = pictureBox1.Width;
            //pictureBox1.Top = this.Height - (pictureBox1.Height + 10);

            //panel1.Height = pictureBox1.Top - 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmCircle.Graphics.FillEllipse(bkgbrush, 2, 2, pictureBox1.Width - 4, pictureBox1.Height - 4);

                
            
                int diameter = (2 * Border);
                //frmCircle.Graphics.FillEllipse(bBrush, Border, Border, pictureBox1.Width - diameter, pictureBox1.Height - diameter);

                diameter -= 2;
                //frmCircle.Graphics.DrawRectangle(new Pen(Color.FromArgb(74, 74, 74)), Border - 1, Border - 1, pictureBox1.Width - diameter, pictureBox1.Height - diameter);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                //var r = rnd.Next(0, 


            }
        }
    }
}
