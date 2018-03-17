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
        Bitmap grayScaledPhoto;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            matrixBox.Enabled = false;
            kBox.Text = "2";
            matrixBox.Text = "F&S";
        }

        private void grayScaleFilter()
        {
            Color color;
            double c;
            grayScaledPhoto = (Bitmap)originalPhoto.Clone();

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    c = 0.3 * color.R + 0.6 * color.G + 0.1 * color.B;

                    grayScaledPhoto.SetPixel(x, y, Color.FromArgb((int)c, (int)c, (int)c));
                }
            }

            pictureBox.Image = grayScaledPhoto;
        }

        private Bitmap randomFilter(int k)
        {
            Color color;
            int c;
            double c2;
            Bitmap tmp = (Bitmap)grayScaledPhoto.Clone();

            Random r = new Random();
            int [] m= new int[k - 1];

            for (int x = 0; x < grayScaledPhoto.Width; x++)
            {
                for (int y = 0; y < grayScaledPhoto.Height; y++)
                {
                    color = grayScaledPhoto.GetPixel(x, y);

                    c = color.R;

                    for (int i = 0; i < k - 1; i++)
                    {
                        double tmp1 = i * 255.0 / (k - 1), tmp2 = (i + 1) * 255.0 / (k - 1);
                        m[(int)i] = r.Next((int)tmp1, (int)tmp2 + 1);
                    }

                    for (int i = 0; i < k - 1; i++)
                    {
                        if (c < m[i])
                        {
                            c2 = i * 255.0 / (k - 1);
                            tmp.SetPixel(x, y, Color.FromArgb((int)c2, (int)c2, (int)c2));
                            break;
                        }
                    }

                    if (c >= m[k - 2])
                    {
                        c2 = 255.0;
                        tmp.SetPixel(x, y, Color.FromArgb((int)c2, (int)c2, (int)c2));
                    }
                }
            }

            return tmp;
        }

        private void FandS(int k)
        {
            double[,] matrix = {
                        {  0, 0, 3 },
                        {  0, 0, 7 },
                        {  0, 7, 1 }
                     }; 

            pictureBox1.Image = errorDifusionFilter(matrix, 1, 1, 16, k);
        }

        private void B(int k)
        {
            double[,] matrix = {
                        {  0, 0, 2 },
                        {  0, 0, 4 },
                        {  0, 0, 8 },
                        {  0, 8, 4 },
                        {  0, 4, 2 },
                     }; 

            pictureBox1.Image = errorDifusionFilter(matrix, 2, 1, 32, k);
        }

        private void St(int k)
        {
            double[,] matrix = {
                        {  0, 0, 0, 2, 1 },
                        {  0, 0, 0, 4, 2 },
                        {  0, 0, 0, 8, 4 },
                        {  0, 0, 8, 4, 2 },
                        {  0, 0, 4, 2, 1 },
                     };

            pictureBox1.Image = errorDifusionFilter(matrix, 2, 2, 42, k);
        }

        private void Sr(int k)
        {
            double[,] matrix = {
                        {  0, 0, 0, 2, 0 },
                        {  0, 0, 0, 4, 2 },
                        {  0, 0, 0, 5, 3 },
                        {  0, 0, 5, 4, 2 },
                        {  0, 0, 3, 2, 0 },
                     };

            pictureBox1.Image = errorDifusionFilter(matrix, 2, 2, 32, k);
        }

        private void A(int k)
        {
            double[,] matrix = {
                        {  0, 0, 0, 0, 0 },
                        {  0, 0, 0, 1, 0 },
                        {  0, 0, 0, 1, 1 },
                        {  0, 0, 1, 1, 0 },
                        {  0, 0, 1, 0, 0 },
                     };

            pictureBox1.Image = errorDifusionFilter(matrix, 2, 2, 8, k);
        }

        private Bitmap errorDifusionFilter(double[,] matrix, int f_x, int f_y, int div, int k)
        {
            Color color;
            double c, c2, error = 0;
            Bitmap tmp = (Bitmap)grayScaledPhoto.Clone();
            int[] m = new int[k];

            for(int i = 0; i < k; i++)
            {
                m[i] = (int)((i + 1) * 255.0 / k);
            }

            for (int x = 0; x < grayScaledPhoto.Width; x++)
            {
                for (int y = 0; y < grayScaledPhoto.Height; y++)
                {
                    color = tmp.GetPixel(x, y);

                    c = color.R;

                    for (int i = 0; i < k; i++)
                    {
                        if (c < m[i])
                        {
                            c2 = i * 255.0 / (k - 1);
                            error = c - c2;
                            tmp.SetPixel(x, y, Color.FromArgb((int)c2, (int)c2, (int)c2));
                            break;
                        }
                    }

                    for (int i = -f_x; i <= f_x; ++i)
                    {
                        for (int j = -f_y; j <= f_y; ++j)
                        {
                            if ((x + i) >= 0 && (x + i) < grayScaledPhoto.Width && (y + j) >= 0 && (y + j) < grayScaledPhoto.Height)
                            {
                                Color clr = tmp.GetPixel(x + i, y + j);

                                int check = clr.R + (int)(error * matrix[i + f_x, j + f_y] / div);

                                if (check > 255) check = 255;
                                else
                                {
                                    if (check < 0) check = 0;
                                }

                                tmp.SetPixel(x + i, y + j, Color.FromArgb(check, check, check));
                            }
                        }
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
            matrixBox.Enabled = false;
        }

        private void error_CheckedChanged(object sender, EventArgs e)
        {
            matrixBox.Enabled = true;
        }

        private void loadFilter_Click(object sender, EventArgs e)
        {
            int k;
            k = Int32.Parse(kBox.Text);

            if (random.Checked)
            {
                pictureBox1.Image = randomFilter(k);
            }
            if(error.Checked)
            {
                if (matrixBox.Text == "F&S") FandS(k);
                if (matrixBox.Text == "B") B(k);
                if (matrixBox.Text == "St") St(k);
                if (matrixBox.Text == "Sr") Sr(k);
                if (matrixBox.Text == "A") A(k);
            }
        }
    }
}
