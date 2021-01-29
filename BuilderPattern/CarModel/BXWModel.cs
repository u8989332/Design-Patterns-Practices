using System;

namespace CarModel
{
    internal class BXWModel : CarDetailModel
    {
        protected override void Alarm()
        {
            Console.WriteLine("BXW alarm");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("BXW engine boom");
        }

        protected override void Start()
        {
            Console.WriteLine("BXW start");
        }

        protected override void Stop()
        {
            Console.WriteLine("BXW stop");
        }
    }
}