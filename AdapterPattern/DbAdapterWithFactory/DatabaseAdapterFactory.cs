using System;
using System.Collections.Generic;

namespace DbAdapterWithFactory
{
    public sealed class DatabaseAdapterFactory
    {
        class DatabaseAdapterMapper
        {
            private static IDictionary<string, Type> dic = new Dictionary<string, Type>();
            static DatabaseAdapterMapper()
            {
                dic.Clear();
                dic.Add("oracle", typeof(OracleAdapter));
                dic.Add("sqlserver", typeof(SqlServerAdapter));
            }

            public Type this[string name]
            {
                get
                {
                    if (!dic.ContainsKey(name))
                    {
                        throw new NotSupportedException(name);
                    }

                    return dic[name];
                }
            }
        }

        private DatabaseAdapterMapper mapper = new DatabaseAdapterMapper();
        public IDatabaseAdapter Create(string name)
        {
            return (IDatabaseAdapter)Activator.CreateInstance(mapper[name]);
        }
    }
}
