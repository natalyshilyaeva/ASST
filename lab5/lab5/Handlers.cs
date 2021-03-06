using System;

namespace lab5
{
    abstract class ProcessKey
    {
        public abstract void KeyHandler(object source, KeyEventArgs args);
        public ProcessKey Successor { set; get; }
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
            else if (Successor != null)
            {
                Successor.KeyHandler(source, args);
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
            else if (Successor != null)
            {
                Successor.KeyHandler(source, args);
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
            else if (Successor != null)
            {
                Successor.KeyHandler(source, args);
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
