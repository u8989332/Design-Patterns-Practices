using System;

namespace BuyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();

            a[0] = "A1";
            a[1] = "A2";
            a[2] = "A3";
            a[3] = "A4";
            a[4] = "A5";
            a[5] = "A6";

            Iterator i = a.CreateIterator();
            object item = i.First();
            Console.WriteLine(item);

            while (!i.IsDone())
            {
                Console.WriteLine($"{i.CurrentItem()} please buy a ticket");
                i.Next();
            }

            Console.WriteLine("----------------");

            Iterator i2 = new ConcreteIteratorDesc(a);
            object itemDesc = i2.First();
            Console.WriteLine(itemDesc);

            while (!i2.IsDone())
            {
                Console.WriteLine($"{i2.CurrentItem()} please buy a ticket");
                i2.Next();
            }

            Console.Read();
        }
    }
}
