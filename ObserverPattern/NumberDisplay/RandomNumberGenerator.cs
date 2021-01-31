using System;
using System.Collections.Generic;

namespace NumberDisplay
{
    class RandomNumberGenerator : NumberGenerator
    {
        private Random random = new Random();
        private int number;

        public override void Execute()
        {
            for (int i = 0; i < 20; ++i)
            {
                number = random.Next(0, 50);
                NotifyObservers();
            }
        }

        public override int GetNumber()
        {
            return number;
        }
    }
}