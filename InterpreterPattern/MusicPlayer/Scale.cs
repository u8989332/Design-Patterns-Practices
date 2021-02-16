using System;

namespace MusicPlayer
{
    class Scale : Expression
    {
        public override void Execute(string key, double value)
        {
            string scale = "";
            switch(Convert.ToInt32(value))
            {
                case 1:
                    scale = "Bass";
                    break;
                case 2:
                    scale = "Alto";
                    break;
                case 3:
                    scale = "Treble";
                    break;
            }

            Console.Write($"{scale} ");
        }
    }
}
