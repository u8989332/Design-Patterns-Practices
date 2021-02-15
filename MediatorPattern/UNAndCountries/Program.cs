using System;

namespace UNAndCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitedNationsSecurityCouncil UNSC = new UnitedNationsSecurityCouncil();
            USA c1 = new USA(UNSC);
            Iraq c2 = new Iraq(UNSC);

            UNSC.Colleague1 = c1;
            UNSC.Colleague2 = c2;

            c1.Declare("Do not research nuclear weapon, or we will launch a war!");
            c2.Declare("We don't have nuclear weapon, and aren't afraid of aggression");

            Console.Read();
        }
    }
}
