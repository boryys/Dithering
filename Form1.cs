using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dithering
{
    public partial class Form1 : Form
    {
        Bitmap originalPhoto;
        
        public Form1()
        {
            InitializeComponent();
            matrix.Enabled = false;
            kBox.Text = "2";
            matrix.Text = "F&S";
        }

        private void grayScaleFilter()
        {
            Color color;
            double c;

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = 0.3 * color.R + 0.6 * color.G + 0.1 * color.B;

                    originalPhoto.SetPixel(x, y, Color.FromArgb((int)c, (int)c, (int)c));
                }
            }

            pictureBox.Image = originalPhoto;
        }

        private Bitmap randomFilter(int k)
        {
            Bitmap btm;

            if (k == 2) btm = random2();
            else
            {
                if (k == 4) btm = random4();
                else
                {
                    if (k == 8) btm = random8();
                    else btm = random16();
                }
            }

            return btm;
        }

        private Bitmap random2()
        {
            Color color;
            double c;
            Bitmap tmp = (Bitmap)originalPhoto.Clone();

            Random r = new Random();
            double b = 0, w = 255;

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = (color.R + color.G + color.B) / 3;

                    int th = r.Next(0, 256);

                    if (c > th)
                    {
                        tmp.SetPixel(x, y, Color.FromArgb((int)w, (int)w, (int)w));
                    }
                    else
                    {
                        tmp.SetPixel(x, y, Color.FromArgb((int)b, (int)b, (int)b));
                    }
                }
            }

            return tmp;
        }

        private Bitmap random4()
        {
            Color color;
            double c;
            Bitmap tmp = (Bitmap)originalPhoto.Clone();

            Random r = new Random();
            double b = 0, w = 255;

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = (color.R + color.G + color.B) / 3;

                    int th1 = r.Next(0, 256);
                    int th2 = r.Next(0, th1 + 1);
                    int th3 = r.Next(th1, 256);

                    if (c > th1)
                    {
                        if (c > th3) tmp.SetPixel(x, y, Color.FromArgb((int)w, (int)w, (int)w));
                        else tmp.SetPixel(x, y, Color.FromArgb((int)(w * 2 / 3), (int)(w * 2 / 3), (int)(w * 2 / 3)));
                    }
                    else
                    {
                        if (c > th2) tmp.SetPixel(x, y, Color.FromArgb((int)(w / 3), (int)(w / 3), (int)(w / 3)));
                        else tmp.SetPixel(x, y, Color.FromArgb((int)b, (int)b, (int)b));
                    }
                }
            }

            return tmp;
        }

        private Bitmap random8()
        {
            Color color;
            double c;
            Bitmap tmp = (Bitmap)originalPhoto.Clone();

            Random r = new Random();
            double b = 0, w = 255;

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = (color.R + color.G + color.B) / 3;

                    int th1 = r.Next(0, 256);
                    int th2 = r.Next(0, th1 + 1);
                    int th3 = r.Next(th1, 256);
                    int th21 = r.Next(0, th2 + 1);
                    int th22 = r.Next(th2, th1 + 1);
                    int th31 = r.Next(th1, th3 + 1);
                    int th32 = r.Next(th3, 256);

                    if (c > th1)
                    {
                        if (c > th3)
                        {
                            if (c > th32) tmp.SetPixel(x, y, Color.FromArgb((int)w, (int)w, (int)w));
                            else tmp.SetPixel(x, y, Color.FromArgb((int)(w * 6 / 7), (int)(w * 6 / 7), (int)(w * 6 / 7)));
                        }
                        else
                        {
                            if(c > th31) tmp.SetPixel(x, y, Color.FromArgb((int)(w * 5 / 7), (int)(w * 5 / 7), (int)(w * 5 / 7)));
                            else tmp.SetPixel(x, y, Color.FromArgb((int)(w * 4 / 7), (int)(w * 4 / 7), (int)(w * 4 / 7)));
                        }
                    }
                    else
                    {
                        if (c > th2)
                        {
                            if (c > th22) tmp.SetPixel(x, y, Color.FromArgb((int)(w * 3 / 7), (int)(w * 3 / 7), (int)(w * 3 / 7)));
                            else tmp.SetPixel(x, y, Color.FromArgb((int)(w * 2 / 7), (int)(w * 2 / 7), (int)(w * 2 / 7)));
                        }
                        else
                        {
                            if (c > th21) tmp.SetPixel(x, y, Color.FromArgb((int)(w / 7), (int)(w / 7), (int)(w / 7)));
                            else tmp.SetPixel(x, y, Color.FromArgb((int)b, (int)b, (int)b));
                        }
                    }
                }
            }

            return tmp;
        }

        private Bitmap random16()
        {
            Color color;
            double c;
            Bitmap tmp = (Bitmap)originalPhoto.Clone();

            Random r = new Random();
            double b = 0, w = 255;

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = (color.R + color.G + color.B) / 3;

                    int th1 = r.Next(0, 256);
                    int th2 = r.Next(0, th1 + 1);
                    int th3 = r.Next(th1, 256);

                    if (c > th1)
                    {
                        if (c > th3) tmp.SetPixel(x, y, Color.FromArgb((int)w, (int)w, (int)w));
                        else tmp.SetPixel(x, y, Color.FromArgb((int)(w * 2 / 3), (int)(w * 2 / 3), (int)(w * 2 / 3)));
                    }
                    else
                    {
                        if (c > th2) tmp.SetPixel(x, y, Color.FromArgb((int)(w / 3), (int)(w / 3), (int)(w / 3)));
                        else tmp.SetPixel(x, y, Color.FromArgb((int)b, (int)b, (int)b));
                    }
                }
            }

            return tmp;
        }

        private void loadImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    originalPhoto = new Bitmap(dlg.FileName);

                    grayScaleFilter();

                    pictureBox1.Image = null;
                }
            }
        }

        private void random_CheckedChanged(object sender, EventArgs e)
        {
            matrix.Enabled = false;
        }

        private void error_CheckedChanged(object sender, EventArgs e)
        {
            matrix.Enabled = true;
        }

        private void loadFilter_Click(object sender, EventArgs e)
        {
            if(random.Checked)
            {
                int k;
                k = Int32.Parse(kBox.Text);
                pictureBox1.Image = randomFilter(k);
            }
        }
    }
}
