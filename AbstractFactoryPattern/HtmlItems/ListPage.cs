using System.Text;

namespace HtmlItems
{
    class ListPage : Page
    {
        public ListPage(string title, string author) : base(title, author)
        {
        }

        public override string MakeHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html><head><title>" + title + "</title></head>");
            sb.Append("<body>");
            sb.Append("<h1>" + title + "</h1>");
            sb.Append("<ul>");
            foreach(Item item in content)
            {
                sb.Append(item.MakeHtml());
            }
            sb.Append("</ul>");
            sb.Append("<hr><address>" + author + "</address>");
            sb.Append("</body></html>");
            return sb.ToString();
        }
    }
}