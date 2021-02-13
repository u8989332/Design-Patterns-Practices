using System;

namespace Barbecue
{
    class Program
    {
        static void Main(string[] args)
        {
            Barbecuer boss = new Barbecuer();
            Command bakeMuttonCommand1 = new BakeMuttonCommand(boss);
            Command bakeMuttonCommand2 = new BakeMuttonCommand(boss);
            Command bakeChickenWingCommand1 = new BakeChickenWingCommand(boss);
            Waiter girl = new Waiter();

            girl.SetOrder(bakeMuttonCommand1);
            girl.SetOrder(bakeMuttonCommand2);
            girl.SetOrder(bakeChickenWingCommand1);

            girl.Notify();
            Console.Read();
        }
    }
}
