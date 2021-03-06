using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаём объект класса событие
            KeyEvent keyEvent = new KeyEvent();

            // создаём объекты классов (разработчик - метод класса)
            ProcessKey handlerUpper = new ProcessUpper();
            ProcessKey handlerLower = new ProcessLower();
            ProcessKey handlerDigits = new ProcessDigits();

            CountKey countKey = new CountKey();

            // для события формируем список обработчиков
            keyEvent.KeyPress += new KeyHandler(handlerUpper.KeyHandler);
            keyEvent.KeyPress += new KeyHandler(handlerLower.KeyHandler);
            keyEvent.KeyPress += new KeyHandler(handlerDigits.KeyHandler);
            keyEvent.KeyPress += new KeyHandler(countKey.KeyHandler);

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

    // делегат для события -ссылка на обработчики + сигнатура для обработчиков-
    //(тип возврата + список параметров)
    delegate void KeyHandler(object source, KeyEventArgs args);

    //  параметры для обработчиков
    class KeyEventArgs : EventArgs
    {
        public char c;
    }

    // класс события, связанного с нажатием клавиши на клавиатуре
    class KeyEvent
    {
        //  событие
        public event KeyHandler KeyPress;

        //  генерация события, связанного с нажатием клавиши
        public void OnKeyPress(char key)
        {
            KeyEventArgs args = new KeyEventArgs();
            if (KeyPress != null)
            {
                //  формирование аргумента для обработчиков
                args.c = key;
                KeyPress(this, args);
            }
        }
    }

    abstract class ProcessKey
    {
        public abstract void KeyHandler(object source, KeyEventArgs args);
    }

    class ProcessUpper : ProcessKey
    {
        public override void KeyHandler(object source, KeyEventArgs args)
        {
            if (args.c >= 'A' && args.c <= 'Z')
            {
                Console.WriteLine("Нажата клавиша: {0}", args.c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, args.c);
            }
        }
    }

    class ProcessLower : ProcessKey
    {
        public override void KeyHandler(object source, KeyEventArgs args)
        {
            if (args.c >= 'a' && args.c <= 'z')
            {
                Console.WriteLine("Нажата клавиша: {0}", args.c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, args.c);
            }
        }
    }

    class ProcessDigits : ProcessKey
    {
        public override void KeyHandler(object source, KeyEventArgs args)
        {
            if (args.c >= '0' && args.c <= '9')
            {
                Console.WriteLine("Нажата клавиша: {0}", args.c);
                Console.WriteLine("{0} обработал запрос {1}\n", GetType().Name, args.c);
            }
        }
    }

    class CountKey
    {
        public int count = 0;
        public void KeyHandler(object source, KeyEventArgs args)
        {
            count++;
        }
    }
}