using System;

namespace CarModel
{
    internal class BexzModel : CarDetailModel
    {
        protected override void Alarm()
        {
            Console.WriteLine("Bexz alarm");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("Bexz engine boom");
        }

        protected override void Start()
        {
            Console.WriteLine("Bexz start");
        }

        protected override void Stop()
        {
            Console.WriteLine("Bexz stop");
        }
    }
}