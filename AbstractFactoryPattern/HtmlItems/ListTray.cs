using System.Text;

namespace HtmlItems
{
    internal class ListTray : Tray
    {
        public ListTray(string caption) : base(caption)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<li>");
            sb.Append(caption);
            sb.Append("<ul>");
            foreach(Item item in tray)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</ul>");
            sb.Append("</li>");

            return sb.ToString();
        }
    }
}