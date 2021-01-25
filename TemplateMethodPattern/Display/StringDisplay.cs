using System;
using System.Text;

namespace Display
{
    public class StringDisplay : AbstractDisplay
    {
        private string content;
        private int width;
        public StringDisplay(string content)
        {
            this.content = content;
            this.width = Encoding.Default.GetByteCount(content);
        }

        protected override void Close()
        {
            PrintLine();
        }

        protected override void Open()
        {
            PrintLine();
        }

        protected override void Print()
        {
            Console.WriteLine("|" + content + "|");
        }

        private void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width;++i)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
