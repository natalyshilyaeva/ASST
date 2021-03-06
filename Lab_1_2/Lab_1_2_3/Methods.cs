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
    public partial class Methods : Form
    {
        private Form1 f1 = null;
        public Methods(Form1 f)
        {
            f1 = f;
            InitializeComponent();
        }

        private void Methods_Load(object sender, EventArgs e)
        {
            label1.Text = "Периметр: " + f1.s.perimeter().ToString();
            label2.Text = "Площадь: " + f1.s.area().ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
