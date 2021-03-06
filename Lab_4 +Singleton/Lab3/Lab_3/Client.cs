using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dll;

namespace Lab_3
{
    public class Client
    {
        //ссылки на продукты
        private Food food;
        private Form window;
        public Food Food { get { return this.food; } }
        public Form Window { get { return this.window; } }
        public Client(AbsFactory factory)
        {
            this.food = factory.CreateFood();
            this.window = factory.CreateWindow(food);
            //теперь Window знает, с какой едой связан и откуда брать информацию
        }
    }
}
