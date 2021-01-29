using System;
using System.IO;
using System.Text;

namespace Greeting
{
    class HTMLBuilder : Builder
    {
        private string fileName;
        private StreamWriter writer;
        internal override void Close()
        {
            writer.WriteLine("</body></html>");
            writer.Dispose();
        }

        internal override void MakeItems(string[] items)
        {
            writer.WriteLine("<ul>");
            foreach(string item in items)
            {
                writer.WriteLine("<li>" + item + "</li>");
            }
            writer.WriteLine("</ul>");
        }

        internal override void MakeString(string str)
        {
            writer.WriteLine("<p>" + str + "</p>");
        }

        internal override void MakeTitle(string title)
        {
            fileName = title + ".html";
            try{
                writer = new System.IO.StreamWriter(fileName);
            }
            catch(Exception ex){
                Console.WriteLine(ex.ToString());
            }
            writer.WriteLine("<html><head><title>" + title + "</title></head><body>");
            writer.WriteLine("<h1>" + title + "</h1>");
        }

        internal string GetResult()
        {
            return fileName;
        }
    }
}
