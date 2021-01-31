using System;

namespace RoyalSpy
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer spy1 = new Spy1();
            Observer spy2 = new Spy2();
            FooKing fooKing = new FooKing();
            fooKing.AddObserver(spy1);
            fooKing.AddObserver(spy2);

            fooKing.HaveBreakfast();
            fooKing.HaveFun();

            Console.Read();
        }
    }
}
