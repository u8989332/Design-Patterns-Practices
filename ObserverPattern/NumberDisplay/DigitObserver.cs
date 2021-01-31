using System;
using System.Threading;

namespace NumberDisplay
{
    class DigitObserver : Observer
    {
        public void Update(NumberGenerator generator)
        {
            Console.WriteLine("Digit number: " + generator.GetNumber());
            Thread.Sleep(100);
        }
    }
}
