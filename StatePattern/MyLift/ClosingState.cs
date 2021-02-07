using System;

namespace MyLift
{
    class ClosingState : LiftState
    {
        public override void Close()
        {
            Console.WriteLine("Lift closing...");
        }

        public override void Open()
        {
            this.context.LiftStete = Context.openningState;
            this.context.LiftStete.Open();
        }

        public override void Run()
        {
            this.context.LiftStete = Context.runningState;
            this.context.LiftStete.Run();
        }

        public override void Stop()
        {
            this.context.LiftStete = Context.stoppingState;
            this.context.LiftStete.Stop();
        }
    }
}