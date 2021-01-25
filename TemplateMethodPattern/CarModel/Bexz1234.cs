using System;

namespace CarModel
{
    public class Bexz1234 : Sedan
    {
        protected override void Alarm()
        {
            Console.WriteLine("Bexz1234 alarm");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("Bexz1234 engine boom");
        }

        protected override void Start()
        {
            Console.WriteLine("Bexz1234 start");
        }

        protected override void Stop()
        {
            Console.WriteLine("Bexz1234 stop");
        }

        protected override bool IsAlarm()
        {
            return false;
        }
    }
}
