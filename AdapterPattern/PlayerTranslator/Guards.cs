using System;

namespace PlayerTranslator
{
    class Guards : Player
    {
        public Guards(string name) : base(name)
        {
        }
        
        public override void Attack()
        {
            Console.WriteLine($"Guards {name} attacks");
        }

        public override void Defense()
        {
            Console.WriteLine($"Guards {name} defenses");
        }
    }
}
