using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5_6
{
    class Repair_Pay : Pay
    {
        private static double k = 20.0;
        private int quantity;
        public Repair_Pay(string surname, int quantity) : base(surname)
        {
            this.quantity = quantity;
        }

        public override double Sum()
        {
            return quantity * k;
        }

        public override string Info()
        {
            return string.Format("{0,-10}{1,10:f2}{2,10:d2}",
                surname, Sum(), quantity);
        }
    }
}
