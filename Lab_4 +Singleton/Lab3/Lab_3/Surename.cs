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
    public partial class Surename : Form
    {
        public Surename()
        {
            InitializeComponent();
        }

        public string surename;

        private void Button1_Click(object sender, EventArgs e)
        {
            surename = (string)listBox1.SelectedItem;
            Close();
        }

        private void Surename_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }
    }
}
