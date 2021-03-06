using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_2_3
{
    public partial class Form1 : Form
    {
        public Square s = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double n;
                n = Convert.ToDouble(textBox1.Text);
                s = new Square(n);
                label2.Text = "Периметр: " + s.perimeter().ToString();
                label3.Text = "Площадь: " + s.area().ToString();
                button3.Show();
                button4.Visible = true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод");
            }            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Information inform = new Information();
            inform.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                Methods method = new Methods(this);
                method.ShowDialog();
            }
            else
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Периметр: ";
            label3.Text = "Площадь: ";
            button4.Visible = false;
        }
        
    }
}
