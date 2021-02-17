using System;

namespace ManAndWoman
{
    class Amativeness : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine($"{concreteElementA.GetType().Name} {this.GetType().Name}, GetManConclusion for amativeness.");
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine($"{concreteElementB.GetType().Name} {this.GetType().Name}, GetWomanConclusion for amativeness.");
        }
    }
}
