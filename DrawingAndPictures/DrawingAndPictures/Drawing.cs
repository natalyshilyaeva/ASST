using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DrawingAndPictures
{
    public class Drawing
    {
        public static void Косинус(Graphics g, int RX, int RY, Color Фон, Color линия)
        {
            SolidBrush кисть = new SolidBrush(Фон);
            Pen перо = new Pen(линия, 2);
            double Xmin = 0.0, Xmax = Math.PI * 2;
            double Ymin = -1.0, Ymax = 1.0;
            double Mx = (Xmax - Xmin) / RX,
                   My = (Ymax - Ymin) / RY;
            int xp, yp, ypp;
            g.FillRectangle(кисть, 0, 0, RX, RY);
            ypp = RY - (int)((Math.Cos(Xmin) - Ymin) / My);
            for (xp = 1; xp < RX; xp++)
            {
                yp = RY - (int)((Math.Cos(Xmin + xp * Mx) - Ymin) / My);
                g.DrawLine(перо, xp - 1, ypp, xp, yp);
                ypp = yp;
            }
        }

        public static void DrawFlag1(Graphics g)
        {
            Point[] star = {new Point(0,-100),
             new Point(22,-31),new Point(95,-31), new Point(36,12),
             new Point(59,81), new Point(0,38),   new Point(-59,81),
             new Point(-36,12),new Point(-95,-31),new Point(-22,-31)};
            g.FillRectangle(Brushes.Blue, 0, 0, 250, 180);
            g.TranslateTransform(125, 90);
            for (int i = 0; i < 9; i++)
            {
                double a = Math.PI * 2 * i / 9;
                g.TranslateTransform((float)(64 * Math.Cos(a)),
                                     (float)(64 * Math.Sin(a)));
                g.ScaleTransform(0.1f, 0.1f);
                g.FillPolygon(Brushes.Yellow, star);
                g.ScaleTransform(10f, 10f);
                g.TranslateTransform((float)(-64 * Math.Cos(a)),
                                     (float)(-64 * Math.Sin(a)));
            }
        }

        public static void DrawFlag11(Graphics g)
        {
            Point[] star = {new Point(0,-100),
             new Point(22,-31),new Point(95,-31), new Point(36,12),
             new Point(59,81), new Point(0,38),   new Point(-59,81),
             new Point(-36,12),new Point(-95,-31),new Point(-22,-31)};
            g.FillRectangle(Brushes.Yellow, 0, 0, 250, 180);
            g.TranslateTransform(125, 90);
            for (int i = 0; i < 9; i++)
            {
                double a = Math.PI * 2 * i / 9;
                g.TranslateTransform((float)(64 * Math.Cos(a)),
                                     (float)(64 * Math.Sin(a)));
                g.ScaleTransform(0.1f, 0.1f);
                g.FillPolygon(Brushes.Blue, star);
                g.ScaleTransform(10f, 10f);
                g.TranslateTransform((float)(-64 * Math.Cos(a)),
                                     (float)(-64 * Math.Sin(a)));
            }
        }

        public static void DrawFlag2(Graphics g)
        {
            Point[] star ={new Point(0,-20),  new Point(4,-6),
                           new Point(19,-6),  new Point(7,2),
                           new Point(12,16),  new Point(0,8),
                           new Point(-12,16), new Point(-7,2),
                           new Point(-19,-6), new Point(-4,-6)};
            g.FillRectangle(Brushes.White, 0, 0, 240, 160);
            g.FillRectangle(Brushes.Blue, 0, 80, 120, 80);
            g.FillRectangle(Brushes.Red, 120, 0, 120, 80);
            g.TranslateTransform(60, 40);
            g.FillPolygon(Brushes.Blue, star);
            g.TranslateTransform(120, 80);
            g.FillPolygon(Brushes.Red, star);
        }

        public static void DrawFlag3(Graphics g)
        {
            g.FillRectangle(Brushes.Blue, 0, 0, 75, 160);
            g.FillRectangle(Brushes.White, 75, 0, 150, 160);
            g.FillRectangle(Brushes.Red, 150, 0, 80, 160);
        }


        private float width;    //ширина кисти
        private float height;   //длина кисти
        private Brush brush;    //кисть

        private Graphics g;     //графика
        private Pen p;          //перо
        //доступ к полям
        public float Width { set { width = value; } get { return width; } }
        public float Height { set { height = value; } get { return height; } }
        public Brush Brush { set { brush = value; } get { return brush; } }
        //Singleton
        private static Drawing instance = new Drawing();
        public static Drawing Instance { get { return instance; } }
        //конструктор
        protected Drawing()
        {
            width = 1;
            height = 1;
            brush = new SolidBrush(Color.Black);
        }

        //прорисовка кривых
        public void Draw(PictureBox pic, float x, float y)
        {
            g = Graphics.FromHwnd(pic.Handle);
            g.FillRectangle(brush, x, y, width, height);
            g.Dispose();
        }
        //прорисовка линий
        public void DrawLine(PictureBox pic, Point p1, Point p2)
        {
            g = Graphics.FromHwnd(pic.Handle);
            p = new Pen(brush, width);
            g.DrawLine(p, p1, p2);
            g.Dispose();
        }
        //прорислвка эллипса
        public void DrawEllipse(PictureBox pic, int x, int y, int w, int h)
        {
            g = Graphics.FromHwnd(pic.Handle);
            p = new Pen(brush, width);
            g.DrawEllipse(p, x, y, w, h);
            g.Dispose();
        }
        //прорисовка текста
        public void DrawText(PictureBox pic, string str, float x, float y)
        {
            g = Graphics.FromHwnd(pic.Handle);
            g.DrawString(str, new Font(new FontFamily("Helvetica"), width, FontStyle.Regular, GraphicsUnit.Point), brush, x, y);
            g.Dispose();
        }
        


        
    }
}
