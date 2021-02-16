using System;

namespace MusicPlayer
{
    class Speed : Expression
    {
        public override void Execute(string key, double value)
        {
            string speed = "";
            if(value < 500)
            {
                speed = "Allegro";
            }
            else if(value >= 1000)
            {
                speed = "Largo";
            }
            else
            {
                speed = "Moderato";
            }

            Console.Write($"{speed} ");
        }
    }
}
