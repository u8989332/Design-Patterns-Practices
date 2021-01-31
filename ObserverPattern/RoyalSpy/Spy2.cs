using System;

namespace RoyalSpy
{
    class Spy2 : Observer
    {
        public void Update(string context)
        {
            Console.WriteLine("Spy2: I find FooKing is acting, so I will prepare sending a letter to soldiers");
            WriteStrategyLetter(context);
            Console.WriteLine("Spy2: My horse, send the letter to soldiers");
        }

        private void WriteStrategyLetter(string context)
        {
            Console.WriteLine("Spy2: Attention! All soldiers must be state of readiness, FooKing is acting-->" + context);
        }
    }
}