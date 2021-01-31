using System;
using System.Threading;

namespace NumberDisplay
{
    class GraphObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("Graph number");
            int count = generator.GetNumber();
            for(int i = 0; i < count;++i)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Thread.Sleep(100);
        }
    }
}
