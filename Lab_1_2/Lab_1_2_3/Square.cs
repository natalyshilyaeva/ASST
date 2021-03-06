using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_2_3
{
    public class Square
    {        
        public double N { get; }    // свойство
        
        public Square(double n)     // конструктор
        {
            this.N = n;
        }

        ~Square() { }       // деструктор

        public double perimeter() { return 4 * N; }     // вычисление периметра

        public double area() { return N * N; }      // вычисление площади

    }//end Square
}//end namespace
