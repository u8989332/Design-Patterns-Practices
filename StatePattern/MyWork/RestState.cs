using System;

namespace MyWork
{
    class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"Current time: {w.Hour} o'clock, off-work and go home~~~");
        }
    }
}