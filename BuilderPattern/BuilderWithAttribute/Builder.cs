using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace BuilderWithAttribute
{
    public class Builder<T> : IBuilder<T> where T : class, new()
    {
        private static ConcurrentDictionary<Type, IList<BuildStepAttribute>> cache = 
            new ConcurrentDictionary<Type, IList<BuildStepAttribute>>();
        public virtual T BuildUp()
        {
            IList<BuildStepAttribute> attributes = DiscoveryBuildSteps();
            if(attributes == null)
            {
                return new T();
            }

            T target = new T();
            foreach(BuildStepAttribute attribute in attributes)
            {
                for(int i = 0 ; i < attribute.Times;++i)
                {
                    attribute.Handler.Invoke(target, null);
                }
            }

            return target;
        }

        protected virtual IList<BuildStepAttribute> DiscoveryBuildSteps()
        {
            if(!cache.ContainsKey(typeof(T)))
            {
                IList<MethodInfo> methods = AttributeHelper.GetMethodWithCustomAttribute<BuildStepAttribute>(typeof(T));
                if(methods == null || methods.Count == 0)
                {
                    return null;
                }

                BuildStepAttribute[] attributes = new BuildStepAttribute[methods.Count];
                for(int i = 0; i < methods.Count;++i)
                {
                    BuildStepAttribute attribute = AttributeHelper.GetMethodCustomAttribute<BuildStepAttribute>(methods[i]);
                    attribute.Handler = methods[i];
                    attributes[i] = attribute;
                }

                Array.Sort<BuildStepAttribute>(attributes);
                cache[typeof(T)] = attributes;
            }
            
            return cache[typeof(T)];
        }
    }
}
