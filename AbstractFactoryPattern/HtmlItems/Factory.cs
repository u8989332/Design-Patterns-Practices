using System;

namespace HtmlItems
{
    abstract class Factory
    {
        public static Factory GetFactory(string className)
        {
            Factory factory = null;
            try
            {
                factory = (Factory)Activator.CreateInstance(Type.GetType(className));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + ", Not found class : " + className);
            }

            return factory;
        }
       
        public abstract Link CreateLink(string caption, string url);
        public abstract Tray CreateTray(string caption);
        public abstract Page CreatePage(string title, string author);
    }
}
