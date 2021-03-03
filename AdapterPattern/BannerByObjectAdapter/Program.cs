using System;

namespace BannerByObjectAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Print p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();

            Console.Read();
        }
    }
}
