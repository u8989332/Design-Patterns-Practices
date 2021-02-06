using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HtmlItems
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            // add necessary services
            services.AddSingleton<IConfiguration>(config);

            // build the pipeline
            var provider = services.BuildServiceProvider();

            Factory factory = Factory.GetFactory(provider.GetService<IConfiguration>()["Factory"]);
            Link google = factory.CreateLink("Google", "https://www.google.com/");
            Link bing = factory.CreateLink("Bing", "https://www.bing.com/");

            Link facebook = factory.CreateLink("Facebook", "https://www.facebook.com/");
            Link instagram = factory.CreateLink("Instagram", "https://www.instagram.com/");

            Link bbc = factory.CreateLink("BBC", "https://www.bbc.com");
            Link nyt = factory.CreateLink("The New York Times", "https://www.nytimes.com/");

            Link yahooSportNews = factory.CreateLink("Yahoo Sports News", "https://tw.news.yahoo.com/sports");
            Link yahooFinanceNews = factory.CreateLink("Yahoo Finance News", "https://tw.news.yahoo.com/finance");

            Tray traySearch = factory.CreateTray("Search Engine");
            traySearch.Add(google);
            traySearch.Add(bing);

            Tray traySocialMedia = factory.CreateTray("Social Media");
            traySocialMedia.Add(facebook);
            traySocialMedia.Add(instagram);

            Tray trayNews = factory.CreateTray("News");
            Tray trayYahooSubNews = factory.CreateTray("Yahoo");
            trayYahooSubNews.Add(yahooSportNews);
            trayYahooSubNews.Add(yahooFinanceNews);
            trayNews.Add(trayYahooSubNews);
            trayNews.Add(bbc);
            trayNews.Add(nyt);

            Page page = factory.CreatePage("Table Page", "GLJ");
            page.Add(traySearch);
            page.Add(traySocialMedia);
            page.Add(trayNews);

            page.Output();

            Console.Read();
        }
    }
}
