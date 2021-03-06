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
    public partial class Pizza : Form
    {
        public Pizza()
        {
            InitializeComponent();
        }

        public int quantity;
        public double sum;
        public double paypizza;

        private void Button1_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(textBox1.Text);
            sum = quantity * paypizza;
            Close();
        }

    }
}
