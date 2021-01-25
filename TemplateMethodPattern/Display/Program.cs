using System;

namespace Display
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('T');
            AbstractDisplay d2 = new StringDisplay("Hello, world!");
            AbstractDisplay d3 = new StringDisplay("測試啦測試");

            d1.Display();
            d2.Display();
            d3.Display();

            Console.Read();
        }
    }
}

