using System;

namespace MyWebSite
{
    class ConcreteWebSite : WebSite
    {
        private string name = string.Empty;
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }

        public override void Use(User user)
        {
            Console.WriteLine("Web site category: " + name + ", user: " + user.Name);
        }
    }
}
