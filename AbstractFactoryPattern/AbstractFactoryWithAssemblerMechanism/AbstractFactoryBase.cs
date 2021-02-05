using System;

namespace AbstractFactoryWithAssemblerMechanism
{
    public abstract class AbstractFactoryBase : IAbstractFactoryWithTypeMapper
    {
        protected TypeMapperBase mapper;
        public virtual TypeMapperBase Mapper
        {
            get { return mapper; }
            set { mapper = value; }
        }

        public T Create<T>()
        {
            Type targetType = mapper[typeof(T)];
            return (T)Activator.CreateInstance(targetType);
        }
    }
}