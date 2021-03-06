using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5_6
{
    abstract class Pay
    {
        protected string surname;
        abstract public double Sum();
        abstract public string Info();
        public Pay(string surname)
        {
            this.surname = surname;
        }
    }
}
