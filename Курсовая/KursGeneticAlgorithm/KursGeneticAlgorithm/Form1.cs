using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace KursGeneticAlgorithm
{
                                        //делегат входной функции
    public delegate double Function(double x, double y);
                                        //делегат функции для алгоритма
    public delegate double GAFunction(double[] values);

    public partial class Form1 : Form, IObserver
    {
        private GeneticAlgorithm model; //модель
        private Controller controller;  //контроллер
        private double[] values;        //массив лучших генов
        private double fitness;         //коэффициент приспособленнности
        private bool onMove = false;    //показатель движения мыши
        private string history;         //история работы алгоритма
        private int i, j;
                                        //поток записи в файл
        public StreamWriter SW = new StreamWriter(new FileStream("История.txt", FileMode.Create, FileAccess.Write));
                                        
        private Point startPosition;    //стартовая позиция для перерисовки
        private Draw draw;              //класс прорисовки
                                        //функции-примеры
        private double F1(double x, double y) { return (Math.Cos(Math.PI*Math.Sqrt(x*x+y*y))/Math.Sqrt(x * x + y * y + 0.5)); }
        private double F2(double x, double y) { return -1 * Math.Sin((x - 1) * (x - 1) + y * y); }
        private double F3(double x, double y) { return -1 * ((y / 2) * Math.Sin(x / 2)); }
        private double F4(double x, double y) { return -1 * Math.Sin(Math.Cos(y + 10) * Math.Sin(x + 10)); }
        private double F5(double x, double y) { return -1 * (x * Math.Sin(y) - Math.PI * Math.Pow(2, (x + 3) / 8)); }
        private double F6(double x, double y) { return -1 * (Math.Sin(y) + 2 * Math.Cos(1.5 * x)); }
        private double F7(double x, double y) { return -1 * Math.Sqrt(x * x + y * y + x * y); }
        private double F8(double x, double y) { return -1 * ((x - 1) * (x - 1) + y * y); }

        private Function f;             //делегат
        //конструктор
        public Form1(GeneticAlgorithm model)
        {
            InitializeComponent();
            //регистрация вида
            this.model = model;
            this.model.Register(this);

            j = 0;
            //инициализация DataGridView, Form, Chart, Controller
            InitDataGridView();
            InitForm();
            InitChart();
            AttachController(MakeController());
        }
        //создание контроллера
        protected Controller MakeController() { return new Controller(model, this); }
        //инициализация контроллера
        public void AttachController(Controller controller) { this.controller = controller; }
        //создания функции для алгоритма
        private double GenAlgTestFcn(double[] values)
        {
            if (values.GetLength(0) != 2)
                throw new Exception("should only have 2 args");

            double x = values[0];
            double y = values[1];

            return f(x, y);
        }
        //инициализация Form
        private void InitForm()
        {
            richTextBox1.Visible = false;
            textBox1.Visible = false;
            crossover.Enabled = false;
            mutation.Enabled = false;
            population.Enabled = false;
            generation.Enabled = false;
            calculate.Enabled = false;
            show.Enabled = false;
            save.Enabled = false;
        }
        //инициализация DataGridView
        private void InitDataGridView()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Поколение";                       //текст в шапке
            column1.Width = 100;                                    //ширина колонки
            column1.ReadOnly = true;                                //значение в этой колонке нельзя править
            column1.Name = "generation";                            //текстовое имя колонки
            column1.Frozen = true;                                  //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell();   //тип колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "x";
            column2.Name = "x";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "y";
            column3.Name = "y";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "z";
            column4.Name = "z";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
        }
        //инициализация Chart
        private void InitChart()
        {
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisY.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chart1.Series.Clear();
            chart1.Legends.Clear();
        }
        //доступ к кнопкам и полям
        private void Access()
        {
            InitForm();
            crossover.Enabled = true;
            mutation.Enabled = true;
            population.Enabled = true;
            generation.Enabled = true;
        }
        //работа алгоритма
        private async Task Go()
        {

            await Task.Delay(10);
            i = 0;
            richTextBox1.Clear();
            richTextBox1.Text = "История работы алгоритма\n";
            draw = new Draw(chart1, f);
            //получение результатов
            model.FitnessFunction = new GAFunction(GenAlgTestFcn);
            model.Elitism = true;
            await model.LaunchGA();
            model.GetBestValues(out values, out fitness);
            //вывод результатов
            label6.Text = "Вычисленные значения равны:\n x = " + Convert.ToString(values[0]) + ";\n y = " + Convert.ToString(values[1]);
            label7.Text = "f(x, y) = " + Convert.ToString(fitness);
            show.Enabled = true;
        }
        //обновление состояния
        public async Task UpdateState()
        {
            if (model.SwitchedOn)
            {
                model.GetBestValues(out values, out fitness);
                //заполнение DataGridView
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i * 100;
                dataGridView1.Rows[i].Cells[1].Value = values[0];
                dataGridView1.Rows[i].Cells[2].Value = values[1];
                dataGridView1.Rows[i].Cells[3].Value = fitness;
                //заполнение TextBox
                textBox1.Text = "";
                textBox1.Text = "x: " + Convert.ToString(values[0]) + " y: " + Convert.ToString(values[1]) + " f(x, y) = " + Convert.ToString(fitness);
                //заполнение RichTextBox
                richTextBox1.Text += "Поколение: " + Convert.ToString(i * 100) + "\n" +
                                     "Текущее значение x = " + Convert.ToString(values[0]) + "\n" +
                                     "Текущее значение y = " + Convert.ToString(values[1]) + "\n" +
                                     "Текущее значение f(x, y) = " + Convert.ToString(fitness) + "\n";
                //прорисовка
                draw.param1 = values[0];
                draw.param2 = values[1];
                draw.DrawScene();
                i++;
                //пауза
                await Task.Delay(1000);
            }
        }
        //первая функция
        private void f1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F1);
            Access();
        }
        //вторая функция
        private void f2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F2);
            Access();
        }
        //третья функция
        private void f3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F3);
            Access();
        }
        //четвертая функция
        private void f4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F4);
            Access();
        }
        //пятая функция
        private void F5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F5);
            Access();
        }
        //шестая функция
        private void F6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F6);
            Access();
        }
        //седьмая функция
        private void F7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F7);
            Access();
        }
        //восьмая функция
        private void F8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f = new Function(F8);
            Access();
        }
        //обработчик "мышь опущена"
        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                onMove = true;
                startPosition = e.Location;
            }
        }
        //обработчик "мышь движется"
        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (onMove)
            {
                if ((startPosition.Y - e.Y) < 0) draw.b--;
                if ((startPosition.Y - e.Y) > 0) draw.b++;
                if ((startPosition.X - e.X) < 0) draw.c--;
                if ((startPosition.X - e.X) > 0) draw.c++;

                if (draw.b > 359) draw.b = 0;
                if (draw.c > 359) draw.c = 0;
                if (draw.b < 0) draw.b = 359;
                if (draw.c < 0) draw.c = 359;

                draw.DrawScene();
            }
        }
        //обработчик "мышь поднята"
        private void chart1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) onMove = false;
        }
        //ввод данных
        private void into_Click(object sender, EventArgs e)
        {
            calculate.Enabled = true;
            try
            {
                controller.SetData(Convert.ToDouble(crossover.Text) / 100, Convert.ToDouble(mutation.Text) / 100, Convert.ToInt32(population.Text), Convert.ToInt32(generation.Text), 2);
            }
            catch
            {
                if (crossover.Text == "" || mutation.Text == "" || population.Text == "" || generation.Text == "") 
                        MessageBox.Show("Введите данные");
                else
                {
                    DialogResult result = MessageBox.Show("Ошибка ввода.\n" + "Неверный формат данных.\n" + "Повторить?",
                                    "Ошибка", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            this.Close();
                            break;
                    }
                }
            }
        }
        //запуск алгоритма
        private async void calculate_Click(object sender, EventArgs e)
        {
            try { await controller.SwitchOn(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            textBox1.Visible = true;
            richTextBox1.Visible = false;
            toolStripStatusLabel2.Text = "Работает";
            InitDataGridView();
            await Go();
            await controller.SwitchOff();
            textBox1.Visible = false;
            textBox1.Text = "";
            toolStripStatusLabel2.Text = "Выключен";
        }
        //доступ к RichTextBox
        private void show_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            save.Enabled = true;
        }
        //сохранение истории работы алгоритма
        private void save_Click(object sender, EventArgs e)
        {
            SW = new StreamWriter(new FileStream("История" + Convert.ToString(j), FileMode.Create, FileAccess.Write));
            j++;
            history = richTextBox1.Text;
            SW.Write(history);
            SW.Close();
            MessageBox.Show("Успешно сохранено");
        }
        //справка на русском
        private void работаСПрограммойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory factory1 = new AlgorithmFactory();
            Client.Take(factory1);
            Client.Instance.Run();
        }
        //справка на английском
        private void описаниеАлгоритмаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbstractFactory factory2 = new EnglishFactory();
            Client.Take(factory2);
            Client.Instance.Run();
        }

        //справка о программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Программа реализации генетического алгоритма для решения задачи оптимизации функции и нахождения ее глобального максимума.\n" +
                            "Разработчик: Шиляева Н. С.\n" +
                            "Группа: М8О-204Б-18\n" +
                            "Год: 2019", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
