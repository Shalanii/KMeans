﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMEANS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float[] xx = new float[100];
        float[] yy = new float[100];
        int centros;
        float[,] cen = new float[50,2];
        int[] pointCluster = new int[50];
        int len;

        private void drawPointDarkBlue(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.DarkBlue, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.DarkBlue, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void drawPointLightBlue(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.LightBlue, a,panel.Height-b-3,a,panel.Height-b+3);
            g.DrawLine(Pens.LightBlue, a+3,panel.Height-b,a-3,panel.Height-b);
        }

        private void drawPointRed(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.Red, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.Red, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void drawPointYellow(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.Yellow, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.Yellow, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void drawPointGreen(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.LightGreen, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.LightGreen, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void drawPointViolet(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.Violet, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.Violet, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void drawPointPink(float a, float b)
        {
            Graphics g = panel.CreateGraphics();
            g.DrawLine(Pens.HotPink, a, panel.Height - b - 3, a, panel.Height - b + 3);
            g.DrawLine(Pens.HotPink, a + 3, panel.Height - b, a - 3, panel.Height - b);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string[] ar = tbCOORDS.Lines;
            int i;
            len = ar.Length;
            string[] aa = new string[2];
            for (i = 0; i < len; i++)
            {
                aa = ar[i].Split(',');
                try
                {
                    xx[i] = Convert.ToInt32(aa[0]);
                    yy[i] = Convert.ToInt32(aa[1]);               
                }
                catch (Exception)
                {
                    MessageBox.Show("Exception occured in line " + Convert.ToString(i + 1));
                }
            }

            bool a = int.TryParse(txtCENTRO.Text, out centros);

            if (!a)
            {
                MessageBox.Show("Enter a valid integer");
                txtCENTRO.Clear();
            }
            else if(centros<2 || centros > len - 1)
            {
                MessageBox.Show("Not a valid value");
                txtCENTRO.Clear();
            }

            for (i = 0; i < len; i++)
            {
                drawPointLightBlue(xx[i], yy[i]);
            }

            for (i = 0; i < centros; i++)
            {
                cen[i, 0] = xx[i];
                cen[i, 1] = yy[i];
                drawPointRed(cen[i,0], cen[i,1]);
            }
        }

        private void btnCLUSTERS_Click(object sender, EventArgs e)
        {

            double[,] clength = new double[30, 100];
            txtCENTRO.Enabled = false;
            tbCOORDS.Enabled = false;
            btnOK.Enabled = false;
            int i,j;
            int k = 0;
            int a;
            int[] c = new int[20];
            float[,] newcen = new float[50, 2];

            while (k < 10)
            {
                clength = new double[30, 100];
                pointCluster = new int[50];
                c= new int[20];
                newcen = new float[50, 2];

                for (j = 0; j < centros; j++)
                {
                    Console.WriteLine("Centroids = " + cen[j, 0] + "," + cen[j, 1]);
                    for (i = 0; i < len; i++)
                    {
                        clength[j, i] = Math.Pow(xx[i] - cen[j, 0], 2) + Math.Pow(yy[i] - cen[j, 1], 2);
                    }
                }
               

                for (i = 0; i < len; i++)
                {
                    pointCluster[i] = 0;
                    double min = 10000000000;
                    for (j = 0; j < centros; j++)
                    {
                        if (min > clength[j, i])
                        {
                            min = clength[j, i];
                            pointCluster[i] = j;
                        }
                    }
                }

                
                for (i = 0; i < len; i++)
                {
                    a = pointCluster[i];
                    Console.Write("a = " + a + " ");
                    newcen[a, 0] = newcen[a, 0] + xx[i];
                    newcen[a, 1] = newcen[a, 1] + yy[i];
                    c[a]=c[a]+1;
                    int b = a % 5;
                    switch (b)
                    {
                        case 0: drawPointYellow(xx[i], yy[i]);  break;
                        case 1: drawPointGreen(xx[i], yy[i]); break;
                        case 2: drawPointPink(xx[i], yy[i]); break;
                        case 3: drawPointRed(xx[i], yy[i]); break;
                        case 4: drawPointLightBlue(xx[i], yy[i]); break;
                    }
                }

                for (i = 0; i < centros; i++)
                {
                    Console.WriteLine(c[i]);
                    newcen[i, 0] = newcen[i, 0] / c[i];
                    newcen[i, 1] = newcen[i, 1] / c[i];
                }   
                           

                for (i = 0; i < centros; i++)
                {
                    cen[i, 0] = newcen[i, 0];
                    cen[i, 1] = newcen[i, 1];
                }

                k++;
            }


        }

        private void panel_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = panel.PointToClient(Cursor.Position);
            int x = p.X;
            int y = panel.Height - p.Y;
            MessageBox.Show(x.ToString()+" "+y.ToString());

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCENTRO.Text = "";
            tbCOORDS.Text = "";
            txtCENTRO.Enabled = true;
            tbCOORDS.Enabled = true;
            btnOK.Enabled = true;
            btnCLUSTERS.Enabled = true;
            panel.Invalidate();
        }

        private void btnEDITCOORDS_Click(object sender, EventArgs e)
        {
            txtCENTRO.Enabled = true;
            tbCOORDS.Enabled = true;
            btnOK.Enabled = true;
            btnCLUSTERS.Enabled = true;
            panel.Invalidate();
        }
    }
}
