using System;

namespace PlayerTranslator
{
    class Center : Player
    {
        public Center(string name) : base(name)
        {
        }
        
        public override void Attack()
        {
            Console.WriteLine($"Center {name} attacks");
        }

        public override void Defense()
        {
            Console.WriteLine($"Center {name} defenses");
        }
    }
}
