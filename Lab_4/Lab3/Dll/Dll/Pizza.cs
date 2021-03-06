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
    public partial class Pizza : Form
    {
        public Pizza(Food food)
        {
            InitializeComponent();
            dataGridView_Pizza.Rows.Add("Размер", food.Size);
            dataGridView_Pizza.Rows.Add("Вес", food.Weight);
            //добравление в datagridview строк с информацией о размере и весе
            label_Pizza.Text = food.Info();
            //добавление исторического текста
        }

        private void ToolStripButton_Close_ButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ВидыToolStripMenuItem_Click(object sender, EventArgs e)
        {//переключение - включение и отключение визуализации информации
            if (dataGridView_Pizza.Visible) { dataGridView_Pizza.Visible = false; }
            else { dataGridView_Pizza.Visible = true; }

        }

        private void ИсторияСозданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {//переключение - включение и отключение визуализации информации
                if (label_Pizza.Visible) { label_Pizza.Visible = false; }
                else { label_Pizza.Visible = true; }
            }
        }
     }
}