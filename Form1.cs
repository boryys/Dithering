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
            sizeKBox.Enabled = false;
            uniform.Checked = true;
            label1.Text = "ORIGINAL PHOTO";
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
                    pictureBox.Image = originalPhoto;
                    label1.Text = "ORIGINAL PHOTO";

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

        private void grayPhoto_Click(object sender, EventArgs e)
        {
            pictureBox.Image = grayScaledPhoto;
            label1.Text = "GRAYSCALED PHOTO";
        }

        private void originalButton_Click(object sender, EventArgs e)
        {
            pictureBox.Image = originalPhoto;
            label1.Text = "ORIGINAL PHOTO";
        }

        private void uniform_CheckedChanged(object sender, EventArgs e)
        {
            krBox.Enabled = true;
            kgBox.Enabled = true;
            kbBox.Enabled = true;
            sizeKBox.Enabled = false;
        }

        private void medianCut_CheckedChanged(object sender, EventArgs e)
        {
            krBox.Enabled = false;
            kgBox.Enabled = false;
            kbBox.Enabled = false;
            sizeKBox.Enabled = true;
        }

        private void loadQuantization_Click(object sender, EventArgs e)
        {
            if (uniform.Checked)
            {
                int kr, kg, kb;
                kr = Int32.Parse(krBox.Text);
                kg = Int32.Parse(kgBox.Text);
                kb = Int32.Parse(kbBox.Text);

                pictureBox1.Image = uniformFilter(kr, kg, kb);
            }
            if (medianCut.Checked)
            {
                int k;
                k = Int32.Parse(sizeKBox.Text);
                pictureBox1.Image = medianCutFilter(k);
            }
        }

        private Bitmap uniformFilter(int kr, int kg, int kb)
        {
            Bitmap tmp = (Bitmap)originalPhoto.Clone();
            Color color;
            int newR = 256, newG = 256, newB = 256;
            int[] matrixR = new int[kr];
            int[] matrixG = new int[kg];
            int[] matrixB = new int[kb];

            for (int i = 0; i < kr; i++)
                matrixR[i] = (int)((i + 1) * 255.0 / kr);

            for (int i = 0; i < kg; i++)
                matrixG[i] = (int)((i + 1) * 255.0 / kg);

            for (int i = 0; i < kb; i++)
                matrixB[i] = (int)((i + 1) * 255.0 / kb);

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    color = originalPhoto.GetPixel(x, y);

                    for (int i = 0; i < kr; i++)
                    {
                        if(color.R <= matrixR[i])
                        {
                            newR = (int)(matrixR[i] - 255.0 / (2 * kr));
                            break;
                        }
                    }

                    for (int i = 0; i < kg; i++)
                    {
                        if (color.G <= matrixG[i])
                        {
                            newG = (int)(matrixG[i] - 255.0 / (2 * kg));
                            break;
                        }
                    }

                    for (int i = 0; i < kb; i++)
                    {
                        if (color.B <= matrixB[i])
                        {
                            newB = (int)(matrixB[i] - 255.0 / (2 * kb));
                            break;
                        }
                    }

                    tmp.SetPixel(x, y, Color.FromArgb(newR, newG, newB));
                }
            }

            return tmp;
        }

        private Bitmap medianCutFilter(int k)
        {
            Bitmap tmp = (Bitmap)originalPhoto.Clone();
            List<Color> list = new List<Color>();
            List<Color>[] arr = new List<Color>[2];
            List<List<Color>> tmpList;
            List<List<Color>> FinalList = new List<List<Color>>();
            Cube [] cubeArr = new Cube[k];

            double numOfInerations = Math.Log(k, 2);

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    Color color = tmp.GetPixel(x, y);

                    list.Add(color);
                }
            }

            FinalList.Add(list);

            for(int i = 0; i < numOfInerations; i++)
            {
                tmpList = new List<List<Color>>(FinalList);
                FinalList.Clear();

                for(int j = 0; j < tmpList.Count(); j++)
                {
                    arr = medianCutFunction(tmpList.ElementAt(j));

                    FinalList.Add(arr[0]);
                    FinalList.Add(arr[1]);
                }
            }

            for(int i = 0; i < k; i++)
            {
                cubeArr[i].minR = FinalList.ElementAt(i).Min(c => c.R);
                cubeArr[i].maxR = FinalList.ElementAt(i).Max(c => c.R);
                cubeArr[i].minG = FinalList.ElementAt(i).Min(c => c.G);
                cubeArr[i].maxG = FinalList.ElementAt(i).Max(c => c.G);
                cubeArr[i].minB = FinalList.ElementAt(i).Min(c => c.B);
                cubeArr[i].maxB = FinalList.ElementAt(i).Max(c => c.B);
                cubeArr[i].average = Color.FromArgb((int)FinalList.ElementAt(i).Average(c => c.R), 
                                                    (int)FinalList.ElementAt(i).Average(c => c.G), 
                                                    (int)FinalList.ElementAt(i).Average(c => c.B));
            }

            for (int x = 0; x < originalPhoto.Width; x++)
            {
                for (int y = 0; y < originalPhoto.Height; y++)
                {
                    Color color = tmp.GetPixel(x, y);
                    
                    for(int i = 0; i < k; i++)
                    {
                        if(color.R >= cubeArr[i].minR && color.R <= cubeArr[i].maxR &&
                           color.G >= cubeArr[i].minG && color.G <= cubeArr[i].maxG &&
                           color.B >= cubeArr[i].minB && color.B <= cubeArr[i].maxB)
                        {
                            tmp.SetPixel(x, y, cubeArr[i].average);
                            break;
                        }
                    }
                }
            }

            return tmp;
        }

        private List<Color>[] medianCutFunction(List<Color> list)
        {
            int minR, maxR, minG, maxG, minB, maxB;
            List<Color> SortedList = new List<Color>();
            List<Color>[] finalList = new List<Color>[2];

            finalList[0] = new List<Color>();
            finalList[1] = new List<Color>();

            minR = list.Min(c => c.R);
            maxR = list.Max(c => c.R);
            minG = list.Min(c => c.G);
            maxG = list.Max(c => c.G);
            minB = list.Min(c => c.B);
            maxB = list.Max(c => c.B);

            int sizeR = maxR - minR;
            int sizeG = maxG - minG;
            int sizeB = maxB - minB;

            int max = new int[] { sizeR, sizeG, sizeB }.Max();

            if(max == sizeR) SortedList = list.OrderBy(c => c.R).ToList();
            if(max == sizeG) SortedList = list.OrderBy(c => c.G).ToList();
            if(max == sizeB) SortedList = list.OrderBy(c => c.B).ToList();

            int n = SortedList.Count() / 2;

            for(int i = 0; i < n; i ++)
                finalList[0].Add(SortedList.ElementAt(i));

            for (int i = n; i < SortedList.Count(); i++)
                finalList[1].Add(SortedList.ElementAt(i));

            return finalList;
        }

        public struct Cube
        {
            public int minR;
            public int maxR;
            public int minG;
            public int maxG;
            public int minB;
            public int maxB;
            public Color average;
        }
    }
}
