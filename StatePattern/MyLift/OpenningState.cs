using System;

namespace MyLift
{
    class OpenningState : LiftState
    {
        public override void Close()
        {
            this.context.LiftStete = Context.closingState;
            this.context.LiftStete.Close();
        }

        public override void Open()
        {
            Console.WriteLine("Lift opening...");
        }

        public override void Run()
        {
        }

        public override void Stop()
        {
        }
    }
}