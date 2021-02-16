using System.Collections;

namespace MyWebSite
{
    class WebSiteFactory
    {
        private Hashtable flyweights = new Hashtable();
        public WebSite GetWebSiteCategory(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteWebSite(key));
            }

            return (WebSite)flyweights[key];
        }

        public int GetWebSiteCount()
        {
            return flyweights.Count;
        }
    }
}
