using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Net_Form
{
    public partial class Form_Graphics : Form
    {
        public Form_Graphics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get bitmap of the image
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            int i;
            Color c;

            //// Get color values for first line
            //for (i = 0; i < bmp.Width; i++)
            //{
            //    c = bmp.GetPixel(i, 0); // Get pixel at coordiate i,0
            //    Console.WriteLine("At coordinate " + i + ",0 " +
            //    " Color: Red=" + c.R + " Green=" + c.G + " Blue=" + c.B);
            //}

            // Set colors of first vertical line to a gradient of Green
            for (i = 0; i < bmp.Height; i++)
            {
                // FromArgb takes Red, Green, Blue
                // Scale green from 0-255 depending on position in height
                c = Color.FromArgb(0, i * 255 / bmp.Height, 0);
                bmp.SetPixel(0, i, c);
                bmp.SetPixel(1, i, c);
                bmp.SetPixel(2, i, c);
                bmp.SetPixel(33, i, c);
            }
            // For our changes to take effect, we must set the image property
            pictureBox1.Image = bmp;

        }
    }
}
