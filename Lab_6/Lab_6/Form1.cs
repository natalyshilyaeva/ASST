using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        // Главное окно приложения исчезает с экрана
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Отображение на экране немодального окна Изменение фона
        private void Button_background_Click_1(object sender, EventArgs e)
        {
            FormColor.ApplyHandler += new EventHandler(ChangeColor);
            FormColor.Open();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var args = e as ColorEventArgs;
            BackColor = Color.FromArgb(args.Red, args.Green, args.Blue);
        }

/// <summary>
/// ////////////////////////////////////////////////////////////////////////////////
/// </summary>


        private int pbh,    // исходная высота и 
                    pbw;    // ширина элемента pictureBox1


        // формирует список иллюстраций в ListBox,
        // aPath - путь к папке с файлами

        private Boolean FillListBox(string aPath)
        {
            // информация о каталоге
            DirectoryInfo di = new DirectoryInfo(aPath);

            // массив информации о файлах
            FileInfo[] fi = di.GetFiles("*.jpg");

            // очищаем ранее полученный список файлов
            listBoxFoto.Items.Clear();

            // добавляем в listBox1 имена jpg- файлов,
            // содержащихся в каталоге aPath
            foreach (FileInfo fc in fi)
            {
                listBoxFoto.Items.Add(fc.Name);
            }
            labelFoto.Text = aPath;
            if (fi.Length == 0) return false;
            else
            {
                // выбираем первый файл из полученного списка
                listBoxFoto.SelectedIndex = 0;
                return true;
            }
        }

        // загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            // запоминаем исходные значения высоты и ширины
            // элемента pictureBox1
            pbh = pictureBoxFoto.Height;
            pbw = pictureBoxFoto.Width;

            // элементы listBox1 сортируются
            // в алфавитном порядке
            listBoxFoto.Sorted = true;

            // Application.StartupPath возвращает путь к каталогу,
            // из которого была запущена программа;
            // заполняем listBox1 списком иллюстраций
            FillListBox(Application.StartupPath + "\\");
        }

        // щелчок на кнопке Папка
        private void ButtonFoto_Click(object sender, EventArgs e)
        {
            // диалоговое окно выбора каталога
            FolderBrowserDialog fb = new FolderBrowserDialog();

            fb.Description = "Выберите папку";
            fb.ShowNewFolderButton = false;

            // отображаем диалоговое окно
            if (fb.ShowDialog() == DialogResult.OK)
                // пользователь выбрал каталог и
                // щелкнул на кнопке ОК
                if (!FillListBox(fb.SelectedPath + "\\"))
                    // в каталоге нет файлов, выгружаем
                    // из pictureBox1 ранее отображаемый файл
                    pictureBoxFoto.Image = null;
        }

        // пользователь выбрал файл щелчком кнопки мыши
        // или перемещением по списку при помощи клавиатуры
        private void ListBoxFoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            double mh, mw;  // коэфициенты масштабирования

            // загружаем изображение в pictureBox1
            pictureBoxFoto.Image = new Bitmap(labelFoto.Text + listBoxFoto.SelectedItem.ToString());

            // масштабируем, если нужно
            if ((pictureBoxFoto.Image.Width > pbw) || (pictureBoxFoto.Image.Height > pbh))
            {
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.StretchImage;

                mh = (double)pbh / (double)pictureBoxFoto.Image.Height;
                mw = (double)pbh / (double)pictureBoxFoto.Image.Width;

                if (mh < mw)
                {
                    // масштабируем по ширине
                    pictureBoxFoto.Width = Convert.ToInt16(pictureBoxFoto.Image.Width * mh);
                    pictureBoxFoto.Height = pbh;
                }
                else
                {
                    // масштабируем по высоте
                    pictureBoxFoto.Width = pbw;
                    pictureBoxFoto.Height = Convert.ToInt16(pictureBoxFoto.Image.Height * mw);
                }
            }
            else
                // если предыдущее изображение масштабировалось
                if (pictureBoxFoto.SizeMode == PictureBoxSizeMode.StretchImage)
                pictureBoxFoto.SizeMode = PictureBoxSizeMode.AutoSize;
        }
    }
}



