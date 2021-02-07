using System;

namespace MyWork
{
    class NoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour < 13)
            {
                Console.WriteLine($"Current time: {w.Hour} o'clock, I am hungry... have a lunch. Time to take a nap.");
            }
            else
            {
                w.SetState(new AfternoonState());
                w.WriteProgram();
            }
        }
    }
}