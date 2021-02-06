using System.Text;

namespace HtmlItems
{
    class TablePage : Page
    {
        public TablePage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><head><title>" + title + "</title></head>");
            sb.Append("<body>");
            sb.Append("<h1>" + title + "</h1>");
            sb.Append("<table width=\"80%\" border=\"3\">");
            foreach(Item item in content)
            {
                sb.Append("<tr>" + item.MakeHtml() + "</tr>");
            }
            sb.Append("</table>");
            sb.Append("<hr><address>" + author + "</address>");
            sb.Append("</body></html>");
            return sb.ToString();
        }
    }
}