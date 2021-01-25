namespace MultipleTemplateMethod
{
    public abstract class SetterBase : ISetter
    {

        public virtual string Append(string data)
        {
            if (!CheckHeader(data))
            {
                data = "H:" + data;
            }

            if (!CheckTailer(data))
            {
                data = data + ":T";
            }

            return data;
        }

        public abstract bool CheckHeader(string data);

        public abstract bool CheckTailer(string data);

    }
}
