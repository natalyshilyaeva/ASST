using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_5_6
{
    class Hotwater_Pay : Pay
    {
        private static double k = 3.0;
        private int cur;
        private int prev;

        public Hotwater_Pay(string surname, int cur, int prev) : base(surname)
        {
            this.cur = cur;
            this.prev = prev;
        }

        public override double Sum()
        {
            return (cur - prev) * k;
        }

        public override string Info()
        {
            return string.Format("{0,-10}{1,10:f2}{2,10:d6}",
                 surname, Sum(), cur - prev);
        }
    }
}
