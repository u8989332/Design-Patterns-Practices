using System.Text;

namespace Greeting
{
    class TextBuilder : Builder
    {
        private StringBuilder buffer = new StringBuilder();
        internal override void Close()
        {
            buffer.Append("=========================\n");
        }

        internal override void MakeItems(string[] items)
        {
            foreach(string item in items)
            {
                buffer.Append("   - " + item + "\n");
            }
        }

        internal override void MakeString(string str)
        {
            buffer.Append("■" + str + "\n");
        }

        internal override void MakeTitle(string title)
        {
            buffer.Append("=========================\n");
            buffer.Append($"[{title}]\n\n");
        }

        internal string GetResult()
        {
            return buffer.ToString();
        }
    }
}
