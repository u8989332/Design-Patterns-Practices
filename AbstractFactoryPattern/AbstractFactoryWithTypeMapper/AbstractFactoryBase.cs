using System;
using System.Collections.Generic;

namespace AbstractFactoryWithTypeMapper
{
    public abstract class AbstractFactoryBase : IAbstractFactory
    {
        protected IDictionary<Type, Type> mapper;
        public AbstractFactoryBase(IDictionary<Type, Type> mapper)
        {
            this.mapper = mapper;
        }
        public T Create<T>() where T : class
        {
            if((mapper == null) || (mapper.Count == 0) || (!mapper.ContainsKey(typeof(T))))
            {
                throw new Exception("T");
            }

            Type targetType = mapper[typeof(T)];
            return (T)Activator.CreateInstance(targetType);
        }
    }
}
