using System;

namespace PlayerTranslator
{
    class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }
        
        public override void Attack()
        {
            Console.WriteLine($"Forwards {name} attacks");
        }

        public override void Defense()
        {
            Console.WriteLine($"Forwards {name} defenses");
        }
    }
}
