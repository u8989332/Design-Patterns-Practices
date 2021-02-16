using System;

namespace MyWebSite
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSiteFactory f = new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("Product Demo");
            fx.Use(new User("U1"));

            WebSite fy = f.GetWebSiteCategory("Product Demo");
            fy.Use(new User("U2"));

            WebSite fz = f.GetWebSiteCategory("Product Demo");
            fz.Use(new User("U3"));


            WebSite fa = f.GetWebSiteCategory("Blog");
            fa.Use(new User("U4"));

            WebSite fb = f.GetWebSiteCategory("Blog");
            fb.Use(new User("U5"));

            WebSite fc = f.GetWebSiteCategory("Blog");
            fc.Use(new User("U6"));

            Console.WriteLine("All web site category count: " + f.GetWebSiteCount());

            Console.Read();

        }
    }
}
