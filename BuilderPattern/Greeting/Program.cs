using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBuilder textBuilder = new TextBuilder();
            Director director1 = new Director(textBuilder);
            director1.Construct();
            string result = textBuilder.GetResult();
            Console.WriteLine(result);

            HTMLBuilder htmlBuilder = new HTMLBuilder();
            Director director2 = new Director(htmlBuilder);
            director2.Construct();
            string fileName = htmlBuilder.GetResult();
            Console.WriteLine(fileName + " file is saved");

        }
    }
}
