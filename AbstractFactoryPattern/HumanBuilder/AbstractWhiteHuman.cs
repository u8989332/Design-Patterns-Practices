using System;

namespace HumanBuilder
{
    abstract class AbstractWhiteHuman : AbstractHuman
    {
        public override void GetColor()
        {
            Console.WriteLine("White human with white skin");
        }

        public override void Talk()
        {
            Console.WriteLine("White human talks");
        }
    }
}
