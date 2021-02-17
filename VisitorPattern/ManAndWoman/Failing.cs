using System;

namespace ManAndWoman
{
    class Failing : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} {this.GetType().Name}, GetManConclusion for failing.");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} {this.GetType().Name}, GetWomanConclusion for failing.");
        }
    }
}
