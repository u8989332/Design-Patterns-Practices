using System;
using System.Collections.Generic;
using System.IO;

namespace HtmlItems
{
    abstract class Page
    {
        protected string title;
        protected string author;
        protected List<Item> content = new List<Item>();
        public Page(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public void Add(Item item)
        {
            this.content.Add(item);
        }

        public void Output()
        {
            try
            {
                string filename = title + ".html";
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    writer.Write(this.MakeHtml());
                }
                Console.WriteLine(filename + " is created.");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public abstract string MakeHtml();
    }
}
