using System;

namespace MyLift
{
    class StoppingState : LiftState
    {
        public override void Close()
        {
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
            Console.WriteLine("Lift stopping...");
        }
    }
}