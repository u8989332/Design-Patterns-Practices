namespace Greeting
{
    abstract class Builder
    {
        internal abstract void MakeTitle(string title);
        internal abstract void MakeString(string str);
        internal abstract void MakeItems(string[] items);
        internal abstract void Close();
    }
}
