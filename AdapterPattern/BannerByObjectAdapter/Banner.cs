using System;

namespace BannerByObjectAdapter
{
    class Banner
    {
        private string content;
        public Banner(string content)
        {
            this.content = content;
        }

        public void ShowWithParen()
        {
            Console.WriteLine("(" + content + ")");
        }

        public void ShowWithAster()
        {
            Console.WriteLine("*" + content + "*");
        }
    }
}
