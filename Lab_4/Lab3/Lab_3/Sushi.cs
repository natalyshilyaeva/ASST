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
    public partial class Sushi : Form
    {
        public Sushi()
        {
            InitializeComponent();
        }

        public int quantity;    // количество суши
        public int amount;      // количество соуса
        public double sushi;
        public double sauce;
        public double sum;

        private void Sushi_Load(object sender, EventArgs e)
        {
            sauce = 50.0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(textBox1.Text);
            amount = int.Parse(textBox2.Text);
            sum = sushi * quantity + sauce * amount;
            Close();
        }

    }
}
