namespace BannerByObjectAdapter
{
    class PrintBanner : Print
    {
        private Banner banner;
        public PrintBanner(string content)
        {
            this.banner = new Banner(content);
        }

        public override void PrintStrong()
        {
            banner.ShowWithAster();
        }

        public override void PrintWeak()
        {
            banner.ShowWithParen();
        }
    }
}
