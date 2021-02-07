using System;

namespace MyWork
{
    class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if(w.Hour < 21)
                {
                    Console.WriteLine($"Current time: {w.Hour} o'clock, overtime... I feel so tired.");
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }
        }
    }
}