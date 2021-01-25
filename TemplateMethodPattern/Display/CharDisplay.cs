using System;

namespace Display
{
    public class CharDisplay : AbstractDisplay
    {
        private char ch;
        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        protected override void Close()
        {
            Console.WriteLine(">>");
        }

        protected override void Open()
        {
            Console.Write("<<");
        }

        protected override void Print()
        {
            Console.Write(ch);
        }
    }
}
