using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll;

namespace Lab_3
{    
    public partial class Form1 : Form
    {
        private Client client;
        public Form1()
        {
            InitializeComponent();
        }

        Pizza pizzaform;     // = new Pizza();
        Sushi sushiform;      //= new Sushi();
        Surename surenameform;      //= new Surename();


        public double pizza, sushi;
        string surename;

        //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        {
            pizza = 600.0;
            sushi = 400.0;
            

            //dataGridView1.Columns.Add("", "Фамилия");
            //dataGridView1.Columns.Add("", "Количество");
            //dataGridView1.Columns.Add("", "Сумма");

            //dataGridView2.Columns.Add("", "Фамилия");
            //dataGridView2.Columns.Add("", "Количество");
            //dataGridView2.Columns.Add("", "Сумма");
        }

        private void ФамилияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            surenameform = new Surename();
            surenameform.ShowDialog();
            surename = surenameform.surename;
        }

        private void ДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pizzaform = new Pizza();
            pizzaform.paypizza = pizza;
            pizzaform.ShowDialog();
            dataGridView1.Rows.Insert(0, 1);
            dataGridView1[0, 0].Value = surename;
            dataGridView1[1, 0].Value = pizzaform.quantity;
            dataGridView1[2, 0].Value = pizzaform.sum;
        }

        private void ДанныеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sushiform = new Sushi();
            sushiform.sushi = sushi;
            sushiform.ShowDialog();
            dataGridView2.Rows.Insert(0, 1);
            dataGridView2[0, 0].Value = surename;
            dataGridView2[1, 0].Value = sushiform.quantity;
            dataGridView2[2, 0].Value = sushiform.amount;
            dataGridView2[3, 0].Value = sushiform.sum;
        }

        private void ФамилияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            surenameform = new Surename();
            surenameform.ShowDialog();
            surename = surenameform.surename;
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            surenameform = new Surename();
            surenameform.ShowDialog();
            surename = surenameform.surename;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            pizzaform = new Pizza();
            pizzaform.paypizza = pizza;
            pizzaform.ShowDialog();
            dataGridView1.Rows.Insert(0, 1);
            dataGridView1[0, 0].Value = surename;
            dataGridView1[1, 0].Value = pizzaform.quantity;
            dataGridView1[2, 0].Value = pizzaform.sum;
        }

        private void ToolStripButton3_Click(object sender, EventArgs e)
        {
            sushiform = new Sushi();
            sushiform.sushi = sushi;
            sushiform.ShowDialog();
            dataGridView2.Rows.Insert(0, 1);
            dataGridView2[0, 0].Value = surename;
            dataGridView2[1, 0].Value = sushiform.quantity;
            dataGridView2[2, 0].Value = sushiform.amount;
            dataGridView2[3, 0].Value = sushiform.sum;
        }

        private void СуммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double s = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                s = s + (double)(dataGridView1[2, i].Value);
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                s = s + (double)(dataGridView2[3, i].Value);
            MessageBox.Show(string.Format("{0:f2}", s), "Итоговая сумма");
        }

        private void Label_Pizza_Click(object sender, EventArgs e)
        {
            AbsFactory pfactory = new PFactory();
            client = new Client(pfactory);
            client.Window.ShowDialog();
        }

        private void Label_Sushi_Click(object sender, EventArgs e)
        {
            AbsFactory sfactory = new SFactory();
            client = new Client(sfactory);
            client.Window.ShowDialog();
        }

        //Завершение программы(через меню)
        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }              

    }
}

