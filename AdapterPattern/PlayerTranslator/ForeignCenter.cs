using System;

namespace PlayerTranslator
{
    class ForeignCenter
    {
        public string name { get; set; }

        public void FCAttack()
        {
            Console.WriteLine($"Center {name} attacks");
        }

        public void FCDefense()
        {
            Console.WriteLine($"Center {name} defenses");
        }
    }
}
