using System;

namespace PlayerTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Player larryBird = new Forwards("Larry Bird");
            larryBird.Attack();

            Player michaelJordan = new Guards("Michael Jordan");
            michaelJordan.Attack();

            Player ym = new Translator("Yao Ming");
            ym.Attack();
            ym.Defense();

            Console.Read();
        }
    }
}
