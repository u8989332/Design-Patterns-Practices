namespace MultipleTemplateMethod
{
    public class DataBroker : ITransform, ISetter
    {
        class InternalTransform : TransformBase
        {
            public override bool Parse(string data)
            {
                return data.Contains("X");
            }

            public override string Replace(string data)
            {
                return data.Replace("X", "Y");
            }
        }

        class InternalSetter : SetterBase
        {
            public override bool CheckHeader(string data)
            {
                return data.StartsWith("H:");
            }

            public override bool CheckTailer(string data)
            {
                return data.EndsWith(":T");
            }
        }

        private ITransform transform = new InternalTransform();
        private ISetter setter = new InternalSetter();

        public string Transform(string data)
        {
            return transform.Transform(data);
        }

        public bool Parse(string data)
        {
            return transform.Parse(data);
        }

        public string Replace(string data)
        {
            return transform.Replace(data);
        }

        public string Append(string data)
        {
            return setter.Append(data);
        }

        public bool CheckHeader(string data)
        {
            return setter.CheckHeader(data);
        }

        public bool CheckTailer(string data)
        {
            return setter.CheckTailer(data);
        }
    }
}
