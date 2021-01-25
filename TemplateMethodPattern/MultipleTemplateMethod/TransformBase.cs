namespace MultipleTemplateMethod
{
    public abstract class TransformBase : ITransform
    {
        public abstract bool Parse(string data);

        public abstract string Replace(string data);

        public virtual string Transform(string data)
        {
            if(Parse(data))
            {
                data = Replace(data);
            }

            return data;
        }
    }
}
