using System;

namespace MyWork
{
    class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine($"Current time: {w.Hour} o'clock, I can't stand for it, go to sleep.");
        }
    }
}