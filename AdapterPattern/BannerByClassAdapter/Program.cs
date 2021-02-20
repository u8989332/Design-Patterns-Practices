using System;

namespace BannerByClassAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.Read();
        }
    }
}
