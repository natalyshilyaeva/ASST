using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dll
{
    public partial class Sushi : Form
    {
        public Sushi(Food food)
        {
            InitializeComponent();
            dataGridView_Sushi.Rows.Add("Размер", food.Size);
            dataGridView_Sushi.Rows.Add("Вес", food.Weight);
            //добравление в datagridview строк с информацией о размере и весе
            label_Sushi.Text = food.Info();
            //добавление исторического текста
        }

        private void ЗакрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void РазмерыToolStripMenuItem_Click(object sender, EventArgs e)
        {// переключение - включение и отключение визуализации информации
            if (dataGridView_Sushi.Visible) { dataGridView_Sushi.Visible = false; }
            else { dataGridView_Sushi.Visible = true; }

        }

        private void ИсторияСозданияToolStripMenuItem_Click(object sender, EventArgs e)
        {// переключение - включение и отключение визуализации информации
            if (label_Sushi.Visible) { label_Sushi.Visible = false; }
            else { label_Sushi.Visible = true; }

        }
    }
}