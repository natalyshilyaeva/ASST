using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursGeneticAlgorithm
{
    public class Draw
    {
        int Z = 5;                          //длина оси Z
        int z0;                             //начало оси Z
        int i;                              //счетчик
        int N = 20;                         //размер координатного пространства
        int count;                          //кол-во серий
                                            //параметры для прорисовки
        public double param1 { set; get; }
        public double param2 { set; get; }
        public double a { set; get; }
        public double b { set; get; }
        public double c { set; get; }

        double[,] arr;                      //массив координат

        Chart chart;                        
        Function f;
        Color color = Color.DarkSlateBlue;  //цвет графика
        Color cl = Color.Maroon;            //цвет точки
                                            //функции для масштабирования и прорисовки
        double sin(double x) { return Math.Sin(x * Math.PI / 180); }
        double cos(double x) { return Math.Cos(x * Math.PI / 180); }
        double l1() { return cos(a) * cos(c) - cos(b) * sin(a) * sin(c); }
        double m1() { return sin(a) * cos(c) + cos(b) * cos(a) * sin(c); }
        double n1() { return sin(b) * sin(c); }
        double l2() { return -cos(a) * sin(c) + cos(b) * sin(a) * cos(c); }
        double m2() { return -sin(a) * sin(c) + cos(b) * cos(a) * cos(c); }
        double n2() { return sin(b) * cos(c); }
        double l3() { return sin(b) * sin(a); }
        double m3() { return -sin(b) * cos(a); }
        double n3() { return cos(b); }
        //конструктор
        public Draw(Chart chart, Function f)
        {
            this.chart = chart;
            this.f = f;
            chart.Series.Clear();
            Update();
            Init();
        }
        //обновление координатного пространства
        public void Update()
        {
            chart.ChartAreas[0].AxisX.Minimum = -N / 2;
            chart.ChartAreas[0].AxisY.Minimum = -N / 2;
            chart.ChartAreas[0].AxisX.Maximum = N / 2;
            chart.ChartAreas[0].AxisY.Maximum = N / 2;
        }
        //инициализация Chart
        public void Init()
        {
            arr = new double[N, N];
            //заполнение массива координат
            for (int x = 0; x < N; x++)
                for (int y = 0; y < N; y++)
                    arr[x, y] = f(x - N / 2, y - N / 2);
            //координата Z
            z0 = 2 * N * 3 + 3;
            //создание серий
            for (i = 0; i < 2 * N * 3; i++)
            {
                chart.Series.Add("s" + i.ToString());
                chart.Series[i].ChartType = SeriesChartType.Line;
            }
            for (i = 0; i < 2 * N * 3; i++) chart.Series[i].Color = color;
            for (i = 2 * N * 3; i < 2 * N * 3 + 3; i++)
            {
                chart.Series.Add("a" + i.ToString());
                chart.Series[i].ChartType = SeriesChartType.Line;
                chart.Series[i].Color = Color.Black;
            }
            for (i = z0; i < z0 + Z * 3; i++)
            {
                chart.Series.Add("z" + i.ToString());
                chart.Series[i].Color = color;
            }
            for (int n = 0; n < 3; n++)
                for (int i = 0; i < Z; i++)
                    chart.Series[z0 + n * Z + i].Color = Color.FromArgb(255, 255 - i * 255 / Z, 0, i * 255 / Z);
            //добавление серии для точки
            count = chart.Series.Count;
            chart.Series.Add("p").Color = cl;
        }
        //прорисовка
        public void DrawScene()
        {
            Clear();
            DrawXYZ();
            CreateGraphics(f);
            DrawPoint();
        }
        //прорисовка графика
        private void CreateGraphics(Function f)
        {
            double[,] a = arr;
            int n = 0;
            double X, Y;
            for (int x = 0; x < N; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    X = l1() * (x - N / 2) + l2() * (y - N / 2) + l3() * a[x, y];
                    Y = m1() * (x - N / 2) + m2() * (y - N / 2) + m3() * a[x, y];
                    chart.Series[n].Points.AddXY(X, Y);
                }
                n++;
            }
            for (int y = 0; y < N; y++)
            {
                for (int x = 0; x < N; x++)
                {
                    X = l1() * (x - N / 2) + l2() * (y - N / 2) + l3() * a[x, y];
                    Y = m1() * (x - N / 2) + m2() * (y - N / 2) + m3() * a[x, y];
                    chart.Series[n].Points.AddXY(X, Y);
                }
                n++;
            }
            //очистка списка серий
            chart.Legends.Clear();
        }
        //прорисовка осей
        private void DrawXYZ()
        {
            double l = N / 2;
            //x
            chart.Series[2 * N * 3 + 1].Points.AddXY(0, 0);
            chart.Series[2 * N * 3 + 1].Points.AddXY(l1() * l, m1() * l);
            chart.Series[2 * N * 3 + 1].Points[1].Label = "X";
            //y
            chart.Series[2 * N * 3 + 2].Points.AddXY(0, 0);
            chart.Series[2 * N * 3 + 2].Points.AddXY(l2() * l, m2() * l);
            chart.Series[2 * N * 3 + 2].Points[1].Label = "Y";
            //z
            chart.Series[2 * N * 3].Points.AddXY(0, 0);
            chart.Series[2 * N * 3].Points.AddXY(l3() * l, m3() * l);
            chart.Series[2 * N * 3].Points[1].Label = "Z";
        }
        //очистка Chart
        private void Clear()
        {
            for (i = 0; i < chart.Series.Count; i++)
            {
                chart.Series[i].Points.Clear();
                
            }
            chart.Series[count].Points.Clear();
            chart.Series.RemoveAt(count);
        }
        //прорисовка точки
        private void DrawPoint()
        {
            chart.Series.Add("p").Color = cl;
            chart.Series[count].ChartType = SeriesChartType.Point;
            chart.Series[count].Points.AddXY( l1() * param1, m1() * param2);
        }
    }
}
