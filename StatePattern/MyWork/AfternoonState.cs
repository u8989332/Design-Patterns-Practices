using System;

namespace MyWork
{
    class AfternoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine($"Current time: {w.Hour} o'clock, I am still with good state and keep working.");
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }
}