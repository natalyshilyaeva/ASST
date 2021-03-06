using System;
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
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

    private static FormColor instance = new FormColor();

        public static void Open()
        {
            try
            {
                instance.Show();
            }
            catch (ObjectDisposedException)
            {
                instance = new FormColor();
                instance.Show();
            }
        }

        private void RadioButtonRed_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(255, 0, 0));
        }

        private void RadioButtonOrange_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(255, 153, 0));
        }

        private void RadioButtonYellow_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(255, 255, 0));
        }

        private void RadioButtonGreen_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(0, 255, 0));
        }

        private void RadioButtonLightblue_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(0, 255, 255));
        }

        private void RadioButtonBlue_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(0, 0, 255));
        }

        private void RadioButtonViolet_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(153, 51, 204));
        }

        private void RadioButtonBlack_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(0, 0, 0));
        }

        private void RadioButtonWhite_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(255, 255, 255));
        }

        private void RadioButtonPink_CheckedChanged(object sender, EventArgs e)
        {
            ApplyHandler?.Invoke(this, new ColorEventArgs(255, 0, 255));
        }


        public static event EventHandler ApplyHandler;

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class ColorEventArgs : EventArgs
    {
        public ColorEventArgs(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
    }
}
    
    

