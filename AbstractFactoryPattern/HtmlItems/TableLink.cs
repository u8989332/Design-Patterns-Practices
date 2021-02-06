namespace HtmlItems
{
    internal class TableLink : Link
    {
        public TableLink(string caption, string url) : base(caption, url)
        {
        }

        public override string MakeHtml()
        {
            return $"<td><a href=\"{url}\">{caption}</a></td>";
        }
    }
}