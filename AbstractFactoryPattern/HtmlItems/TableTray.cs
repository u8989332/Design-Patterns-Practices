using System.Text;

namespace HtmlItems
{
    internal class TableTray : Tray
    {
        public TableTray(string caption) : base(caption)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<td>");
            sb.Append("<table width=\"100%\" border=\"1\"><tr>");
            sb.Append("<td bgcolor=\"#cccccc\" align=\"center\" colspan=\"" + tray.Count + "\"><b>" + caption + "</b></td>");
            sb.Append("</tr>");
            sb.Append("<tr>");
            foreach (Item item in tray)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</tr></table>");
            sb.Append("</td>");

            return sb.ToString();
        }
    }
}