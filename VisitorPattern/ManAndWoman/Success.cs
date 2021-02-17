using System;

namespace ManAndWoman
{
    class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} {this.GetType().Name}, GetManConclusion for success.");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} {this.GetType().Name}, GetWomanConclusion for success.");
        }
    }
}
