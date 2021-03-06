using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingAndPictures
{
    public partial class Form1 : Form
    {
        private string s;                               //строка для прорисовки
        private Point p1, p2;                           //точки для прорисовки линии
        private int a, x, y, w, h;                      //всевозможные параметры        
        private bool doDraw, doLine, doEllipse, doText; //показатели, что прорисовка началась

        //конструктор
        public Form1()
        {
            InitializeComponent();
            doDraw = false;
            doLine = false;
            doEllipse = false;
            doText = false;
            pictureBox1.BackColor = Color.White;
            a = 1;            
        }


        Color фон = Color.Blue, линия = Color.Yellow;

        int RX,  //Размер по горизонтали
            RY;  //Размер по вертикали
        Graphics контекст;  //Параметры изображения

        int рисунок = 1;

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            контекст = Graphics.FromHwnd(panel1.Handle);
            RX = panel1.Size.Width;
            RY = panel1.Size.Height;
            if ((рисунок == 1) && radioButtonReverse.Checked)
                Drawing.DrawFlag11(контекст);
            else if (рисунок == 1)
                Drawing.DrawFlag1(контекст);
            else
            Drawing.Косинус(контекст, RX, RY, фон, линия);
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {
            //   контекст = e.Graphics;
            контекст = Graphics.FromHwnd(panel2.Handle);
            RX = panel2.Size.Width;
            RY = panel2.Size.Height;
            if (рисунок == 1)
                Drawing.DrawFlag2(контекст);
            else
                Drawing.Косинус(контекст, RX, RY, фон, линия);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
            //  контекст = Graphics.FromHwnd(panel3.Handle);
            контекст = e.Graphics;
            RX = panel3.Size.Width;
            RY = panel3.Size.Height;
            if (рисунок == 1)
                Drawing.DrawFlag3(контекст);
            else
                Drawing.Косинус(контекст, RX, RY, фон, линия);
        }

        private void RadioButtonDirect_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDirect.Checked)
            {
                фон = Color.Blue;
                линия = Color.Yellow;                
            }
        }

        private void RadioButtonReverse_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonReverse.Checked)                  
            {
                фон = Color.Yellow;
                линия = Color.Blue;
            }
        }

        private void ФлагToolStripMenuItem_Click(object sender, EventArgs e)
        {
            рисунок = 1;
        }

        private void ГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            рисунок = 2;
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            // Приложение сообщает о необходимости перерисовки его окна
            // В результате будет создано событие Paint и вызван его обработчик

            this.Invalidate();
        }

        //перерисовка при изменении размера
        private void panel1_Resize(object sender, EventArgs e)
        {
            { Invalidate(); }
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        //мышь опущена
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (a)
            {
                //прорисовка кривых
                case 1:
                    doDraw = true;
                    break;
                //прорисовка линий
                case 2:
                    doLine = true;
                    p1 = new Point(e.X, e.Y);
                    break;
                //прорисовка эллипсов
                case 3:
                    doEllipse = true;
                    x = e.X;
                    y = e.Y;
                    break;
                //прорисовка текста
                case 4:
                    doText = true;
                    x = e.X;
                    y = e.Y;
                    break;
            }
        }
        //рисовать
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw) Drawing.Instance.Draw(pictureBox1, e.X, e.Y);
        }
        //мышь поднята
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //прорисовка линий
            if (doLine)
            {
                p2 = new Point(e.X, e.Y);
                Drawing.Instance.DrawLine(pictureBox1, p1, p2);
            }
            //прорисовка эллипсов
            if (doEllipse)
            {
                w = Math.Abs(e.X - x);
                h = Math.Abs(y - e.Y);
                x = Math.Min(e.X, x);
                y = Math.Min(e.Y, y);
                Drawing.Instance.DrawEllipse(pictureBox1, x, y, w, h);
            }
            //прорисовка текста
            if (doText)
            {
                s = textBox1.Text;
                x = Math.Min(e.X, x);
                y = Math.Min(e.Y, y);
                Drawing.Instance.DrawText(pictureBox1, s, x, y);
            }
            //прорисовка закончена
            doDraw = false;
            doLine = false;
            doEllipse = false;
            doText = false;
        }
        
        //сменить цвет кисти
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Red;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Red);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Red, Color.LightPink, 45, false);
                    break;
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Blue;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Blue);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Blue, Color.LightBlue, 45, false);
                    break;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Green;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Green);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Green, Color.LightGreen, 45, false);
                    break;
            }
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Yellow;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Yellow);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Yellow, Color.LightYellow, 45, false);
                    break;
            }
        }
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.Black;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.Black);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Black, Color.LightGray, 45, false);
                    break;
            }
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            switch (Drawing.Instance.Brush.GetType().Name)
            {
                case "SolidBrush":
                    Drawing.Instance.Brush = Brushes.White;
                    break;
                case "HatchBrush":
                    Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
                            Color.Aquamarine, Color.White);
                    break;
                case "LinearGradientBrush":
                    Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                            Color.Gray, Color.White, 45, false);
                    break;
            }
        }

        //сменить кисть
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new SolidBrush(Color.Black);
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new HatchBrush(HatchStyle.OutlinedDiamond,
            Color.Aquamarine, Color.Black);
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Drawing.Instance.Brush = new LinearGradientBrush(new Rectangle(0, 0, 200, 200),
                Color.Black, Color.LightGray, 45, false);
        }

        //сменить ширину и длину кисти
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Drawing.Instance.Height = trackBar1.Value;
            Drawing.Instance.Width = trackBar1.Value;
        }

        //очистить от рисунка
        private void ОчиститьToolStripMenuItem_Click(object sender, EventArgs e) { pictureBox1.Refresh(); }

        //перерисовка при изменении размера
        private void pictureBox1_Resize(object sender, EventArgs e) { Invalidate(); }

        //рисуем кривые
        private void toolStripButton7_Click(object sender, EventArgs e) { a = 1; }
        //рисуем прямые
        private void toolStripButton8_Click(object sender, EventArgs e) { a = 2; }
        //рисуем эллипсы
        private void toolStripButton9_Click(object sender, EventArgs e) { a = 3; }
        //рисуем текст
        private void toolStripButton10_Click(object sender, EventArgs e) { a = 4; }
    }
}
