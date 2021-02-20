namespace BannerByClassAdapter
{
    class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string content) : base(content)
        {
        }

        public void PrintStrong()
        {
            this.ShowWithAster();
        }

        public void PrintWeak()
        {
            this.ShowWithParen();
        }
    }
}
