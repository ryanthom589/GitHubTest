using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            SolidBrush drawBrush = new SolidBrush(Color.Red);
            g.DrawString("Hello \nHow are you?", drawFont, drawBrush, 150, 150);

            g.TranslateTransform(150 , 150);

            g.RotateTransform(90);

            g.DrawString("Hello", drawFont, drawBrush, new Rectangle());

            g.ResetTransform();
            //test


        }
    }
}
