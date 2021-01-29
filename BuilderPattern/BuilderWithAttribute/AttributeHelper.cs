using System;
using System.Collections.Generic;
using System.Reflection;

namespace BuilderWithAttribute
{
    public class AttributeHelper
    {
        public static IList<T> GetCustomAttributes<T>(Type type) where T : Attribute
        {
            if(type == null)
            {
                throw new ArgumentNullException("type");
            }

            T[] attributes = (T[])(type.GetCustomAttributes(typeof(T), false));
            return (attributes.Length == 0) ? null : new List<T>(attributes);
        }

        public static IList<MethodInfo> GetMethodWithCustomAttribute<T>(Type type) where T : Attribute
        {
            if(type == null)
            {
                throw new ArgumentNullException("type");
            }
            
            MethodInfo[] methods = type.GetMethods();
            if(methods == null || methods.Length == 0)
            {
                return null;
            }

            IList<MethodInfo> result = new List<MethodInfo>();
            foreach(MethodInfo method in methods)
            {
                if(method.IsDefined(typeof(T), false))
                {
                    result.Add(method);
                }
            }

            return result.Count == 0 ? null : result;
        }

        public static IList<T> GetMethodCustomAttributes<T>(MethodInfo method) where T : Attribute
        {
            if(method == null)
            {
                throw new ArgumentNullException("method");
            }

            T[] attributes = (T[])(method.GetCustomAttributes(typeof(T), false));
            return (attributes.Length == 0) ? null : new List<T>(attributes);
        }

        public static T GetMethodCustomAttribute<T>(MethodInfo method) where T : Attribute
        {
            IList<T> attributes = GetMethodCustomAttributes<T>(method);
            return (attributes == null) ? null : attributes[0];
        }
    }
}
