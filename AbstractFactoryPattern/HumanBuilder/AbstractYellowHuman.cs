using System;

namespace HumanBuilder
{
    abstract class AbstractYellowHuman : AbstractHuman
    {
        public override void GetColor()
        {
            Console.WriteLine("Yellow human with yellow skin");
        }

        public override void Talk()
        {
            Console.WriteLine("Yellow human talks");
        }
    }
}
