using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace lab04
{
    public partial class Form1 : Form
    {
        private ArrayList Points;
        private ArrayList Clusters;
        private bool ClustersFound = false;


        public Form1()
        {
            InitializeComponent();

            Points = new ArrayList();

            pbxMain.Image = new Bitmap(pbxMain.Width, pbxMain.Height);
            

        }

        private void ClearImage()
        {
            Graphics gpsMain = Graphics.FromImage(pbxMain.Image);

            gpsMain.FillRectangle(Brushes.White, 0, 0, pbxMain.Width, pbxMain.Height);

            gpsMain.Dispose();

            pbxMain.Refresh();
        }

        private void DrawPoints(bool Clear = true)
        {
            if (Clear)
                ClearImage();

            Graphics gpsMain = Graphics.FromImage(pbxMain.Image);

            for (int i = 0; i < Points.Count; i++)
            {
                Point Cur = (Point)Points[i];
                gpsMain.DrawEllipse(Pens.Black, Cur.x - 2, Cur.y - 2, 4, 4);
            }

            gpsMain.Dispose();

            pbxMain.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Левая кнопка добавление
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Point P = new Point();
                P.x = e.Location.X;
                P.y = e.Location.Y;
                Points.Add(P);

                StringBuilder SB = new StringBuilder();
                SB.AppendFormat("({0};{1})", P.x, P.y);

                lbxPoints.Items.Add(SB.ToString());

                DrawPoints();
                ClustersFound = false;
            }
            else
            {
                // Правая удаление
                for (int i = 0; i < Points.Count; i++)
                {
                    Point Cur = (Point)Points[i];

                    if ((Cur.x - e.Location.X) * (Cur.x - e.Location.X) +
                            (Cur.y - e.Location.Y) * (Cur.y - e.Location.Y) < 25)
                    {
                        Points.RemoveAt(i);
                        lbxPoints.Items.RemoveAt(i);

                        DrawPoints();
                        ClustersFound = false;
                        break;
                    }
                }
            }
        }

        private void btnDelPoints_Click(object sender, EventArgs e)
        {
            if (lbxPoints.SelectedIndex >= 0)
            {
                Points.RemoveAt(lbxPoints.SelectedIndex);
                lbxPoints.Items.RemoveAt(lbxPoints.SelectedIndex);

                DrawPoints();
                ClustersFound = false;
            }
        }

        private void btnClearPoints_Click(object sender, EventArgs e)
        {
            lbxPoints.Items.Clear();
            ClearImage();
            Points.Clear();
            ClustersFound = false;
        }

        private double Length(int PointInd, int ClusterInd)
        {
            Point P = (Point)Points[PointInd];
            Cluster C = (Cluster)Clusters[ClusterInd];

            return (P.x - C.x) * (P.x - C.x) + (P.y - C.y) * (P.y - C.y);
        }

        private double Length(Point P, int ClusterInd)
        {
            Cluster C = (Cluster)Clusters[ClusterInd];

            return (P.x - C.x) * (P.x - C.x) + (P.y - C.y) * (P.y - C.y);
        }

        private int FindClustNumber(Point P)
        {
            int MinInd = 0;
            double MinLen = Length(P, 0);

            for (int j = 0; j < Clusters.Count; j++)
            {
                double CurLen = Length(P, j);
                if (MinLen > CurLen)
                {
                    MinInd = j;
                    MinLen = CurLen;
                }
            }

            return MinInd;
        }

        private void FindClusters()
        {
            for (int i = 0; i < Clusters.Count; i++)
                ((Cluster)Clusters[i]).Points.Clear();

            // Ищем к каким кластерам принадлежит каждая точка
            for (int i = 0; i < Points.Count; i++)
            {
                int MinInd = 0;
                double MinLen = Length(i, 0);

                for (int j = 0; j < Clusters.Count; j++)
                {
                    double CurLen = Length(i, j);
                    if (MinLen > CurLen)
                    {
                        MinInd = j;
                        MinLen = CurLen;
                    }
                }

                ((Cluster)Clusters[MinInd]).Points.Add(i);
            }
        }

        private double CorrectClusters()
        {
            double e = 0;

            for (int i = 0; i < Clusters.Count; i++)
            {
                double mean_x = 0;
                double mean_y = 0;

                Cluster CurCluster = (Cluster)Clusters[i];

                if (CurCluster.Points.Count == 0)
                    continue;

                for (int j = 0; j < CurCluster.Points.Count; j++)
                {
                    Point CurPoint = (Point)Points[(int)CurCluster.Points[j]];
                    mean_x += CurPoint.x;
                    mean_y += CurPoint.y;
                }

                mean_x /= CurCluster.Points.Count;
                mean_y /= CurCluster.Points.Count;

                e += (mean_x - CurCluster.x) * (mean_x - CurCluster.x) + (mean_y - CurCluster.y) * (mean_y - CurCluster.y);

                CurCluster.x = Convert.ToInt32(mean_x);
                CurCluster.y = Convert.ToInt32(mean_y);
            }

            return e;
        }

        private void InitClusters(int count)
        {
            Clusters = new ArrayList();
            Random r = new Random();

            int MaxX = Int32.MinValue, MaxY = Int32.MinValue, MinX = Int32.MaxValue, MinY = Int32.MaxValue;
            // Смотрим максимальные и минимальные координаты точек
            for (int i = 0; i < Points.Count; i++)
            {
                Point Cur = (Point)Points[i];

                if (Cur.x > MaxX)
                    MaxX = Cur.x;
                if (Cur.x < MinX)
                    MinX = Cur.x;
                if (Cur.y > MaxY)
                    MaxY = Cur.y;
                if (Cur.y < MinY)
                    MinY = Cur.y;
            }

            for (int i = 0; i < count; i++)
            {
                Cluster Cur = new Cluster();
                Cur.x = (int)Math.Round(r.NextDouble() * (MaxX - MinX) + MinX);
                Cur.y = (int)Math.Round(r.NextDouble() * (MaxY - MinY) + MinY);
                Cur.C = Color.FromArgb((int)((r.Next() % 0xFFFFFF) | 0xFF000000));

                Clusters.Add(Cur);
            }
        }

        private void DrawClusters()
        {
            Bitmap Bmp = (Bitmap)pbxMain.Image;
            Graphics Gph = Graphics.FromImage(Bmp);

            for (int i = 0; i < pbxMain.Width; i++)
                for (int j = 0; j < pbxMain.Height; j++)
                {
                    Point P = new Point();
                    P.x = i;
                    P.y = j;
                    int num = FindClustNumber(P);

                    Bmp.SetPixel(i, j, ((Cluster)Clusters[num]).C); 
                }

            // Рисуем центры кластеро
            for (int i = 0; i < Clusters.Count; i++)
            {
                Cluster Cur = (Cluster)Clusters[i];
                Gph.DrawEllipse(new Pen(Color.Red), (float)Cur.x, (float)Cur.y, 2, 2); 
            }

            Brush BB = new SolidBrush(Color.Black);

            DrawPoints(false);
            pbxMain.Refresh();
                
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            int cc = Convert.ToInt32(tbxClusterCount.Text);
            double eps = Convert.ToDouble(tbxEps.Text);

            InitClusters(cc);

            double last_eps = 0, cur_eps = 0;

            do
            {
                last_eps = cur_eps;
                FindClusters();
                cur_eps = CorrectClusters();
            } while (Math.Abs(cur_eps - last_eps) > eps);

            DrawClusters();
            ClustersFound = true;
        }

        private void pbxMain_SizeChanged(object sender, EventArgs e)
        {
            if (pbxMain.Image != null)
                pbxMain.Image.Dispose();

            pbxMain.Image = new Bitmap(pbxMain.Width, pbxMain.Height);

            if (ClustersFound)
                DrawClusters();
            else
                DrawPoints();
        }
    }

    public class Point
    {
        public int x, y;
    }

    public class Cluster
    {
        public int x, y;
        public ArrayList Points;
        public Color C;

        public Cluster()
        {
            Points = new ArrayList(); 
        }
    }

}
