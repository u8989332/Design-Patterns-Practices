using System;
using System.Collections.Generic;

namespace AbstractFactoryWithTypeMapper
{
    public class ConcreteFactory : AbstractFactoryBase
    {
        public ConcreteFactory(IDictionary<Type, Type> mapper) : base(mapper)
        {
        }
    }
}
