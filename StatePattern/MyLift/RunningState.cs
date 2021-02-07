using System;

namespace MyLift
{
    class RunningState : LiftState
    {
        public override void Close()
        {
        }

        public override void Open()
        {
        }

        public override void Run()
        {
            Console.WriteLine("Lift running...");
        }

        public override void Stop()
        {
            this.context.LiftStete = Context.stoppingState;
            this.context.LiftStete.Stop();
        }
    }
}