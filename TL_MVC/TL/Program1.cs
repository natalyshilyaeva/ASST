using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  WindowsApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(150, 1500);
            Console.Write("ПРИВЕТ\n");

            TrafficLightModel model = new TrafficLightModel();

            TrafficLightView view1 = new TrafficLightView(model);
            TrafficLightView2 view2 = new TrafficLightView2(model);
            ControlForm view3 = new ControlForm(model);
            Form1 view4 = new Form1(model);

            view1.Show();
            view3.Show();
            Application.Run(view4);

            Console.Beep(300, 1500);
        }
    }
}
