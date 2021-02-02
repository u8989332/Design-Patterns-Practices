using System;

namespace HumanBuilder
{
    abstract class AbstractBlackHuman : AbstractHuman
    {
        public override void GetColor()
        {
            Console.WriteLine("Black human with black skin");
        }

        public override void Talk()
        {
            Console.WriteLine("Black human talks");
        }
    }
}
