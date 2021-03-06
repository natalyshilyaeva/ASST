using System;

namespace lab5_CR
{    
    abstract class ProcessKey
    {
        public abstract void KeyHandler(char c);
        public ProcessKey Successor { set; get; }
    }

    class ProcessUpper : ProcessKey
    {
        public override void KeyHandler(char c)
        {
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("Нажата клавиша: {0}", c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, c);
            }
            else if (Successor != null)
            {
                Successor.KeyHandler(c);
            }
        }
    }

    class ProcessLower : ProcessKey
    {
        public override void KeyHandler(char c)
        {
            if (c >= 'a' && c <= 'z')
            {
                Console.WriteLine("Нажата клавиша: {0}", c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, c);
            }
            else if (Successor != null)
            {
                Successor.KeyHandler(c);
            }
        }
    }

    class ProcessDigits : ProcessKey
    {
        public override void KeyHandler(char c)
        {
            if (c >= '0' && c <= '9')
            {
                Console.WriteLine("Нажата клавиша: {0}", c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, c);
            }
            else if (Successor != null)
            {
                Successor.KeyHandler(c);
            }
        }
    }

    class CountKey : ProcessKey
    {
        public int count = 0;
        public override void KeyHandler(char c)
        {
            count++;
            if (Successor != null)
            {
                Successor.KeyHandler(c);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProcessKey handlerUpper = new ProcessUpper();
            ProcessKey handlerLower = new ProcessLower();
            ProcessKey handlerDigits = new ProcessDigits();
            CountKey countKey = new CountKey();

            countKey.Successor = handlerUpper;
            handlerUpper.Successor = handlerLower;
            handlerLower.Successor = handlerDigits;

            Console.WriteLine("Введите строку с точкой в конце:");

            char c;
            do
            {
                c = (char)Console.Read();
                countKey.KeyHandler(c);
            }
            while (c != '.');

            Console.WriteLine("Было нажато {0} клавиш.", countKey.count);
            Console.ReadKey();
        }
    }
}