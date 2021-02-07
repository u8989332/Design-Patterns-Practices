using System;

namespace MyWork
{
    class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if(w.Hour < 12)
            {
                Console.WriteLine($"Currtime: {w.Hour} o'clock, morning work and I'm in good spirits.");
            }
            else
            {
                w.SetState(new NoonState());
                w.WriteProgram();
            }
        }
    }
}