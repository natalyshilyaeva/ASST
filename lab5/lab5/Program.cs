using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyEvent keyEvent = new KeyEvent();

            ProcessKey handlerUpper = new ProcessUpper();
            ProcessKey handlerLower = new ProcessLower();
            ProcessKey handlerDigits = new ProcessDigits();

            CountKey countKey = new CountKey();

            keyEvent.KeyPress += new KeyHandler(handlerUpper.KeyHandler);
            keyEvent.KeyPress += new KeyHandler(countKey.KeyHandler);

            handlerUpper.Successor = handlerLower;
            handlerLower.Successor = handlerDigits;

            Console.WriteLine("Введите строку с точкой в конце:");

            char c;
            do
            {
                c = (char)Console.Read();
                keyEvent.OnKeyPress(c);
            }
            while (c != '.');

            Console.WriteLine("Было нажато {0} клавиш.", countKey.count);
            Console.ReadKey();
        }
    }
}