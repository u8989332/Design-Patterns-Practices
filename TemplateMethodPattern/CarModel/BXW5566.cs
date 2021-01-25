using System;

namespace CarModel
{
    public class BXW5566 : Sedan
    {
        private bool alarmFlag = true;
        protected override void Alarm()
        {
            Console.WriteLine("BXW5566 alarm");
        }

        protected override void EngineBoom()
        {
            Console.WriteLine("BXW5566 engine boom");
        }

        protected override void Start()
        {
            Console.WriteLine("BXW5566 start");
        }

        protected override void Stop()
        {
            Console.WriteLine("BXW5566 stop");
        }

        protected override bool IsAlarm()
        {
            return this.alarmFlag;
        }

        public void SetAlarm(bool isAlarm)
        {
            this.alarmFlag = isAlarm;
        }
    }
}
