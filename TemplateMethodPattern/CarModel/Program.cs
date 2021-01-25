using System;

namespace CarModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want BXW556 to alarm ? 1 = yes, 0 = no");
            string toAlarm = Console.ReadLine();
            BXW5566 c1 = new BXW5566();

            if(toAlarm == "0")
            {
                c1.SetAlarm(false);
            }
            c1.Run();

            Bexz1234 c2 = new Bexz1234();
            c2.Run();
            Console.Read();
        }
    }
}
