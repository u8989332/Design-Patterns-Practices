using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DbConnectWithSimpleFactoryReflection
{
    class DataAccess
    {
        private IConfiguration configuration;
        private readonly string db = string.Empty;
        private readonly string assemblyName = Assembly.GetExecutingAssembly().GetName().Name;
        public DataAccess(IConfiguration configuration)
        {
            this.configuration = configuration;
            db = configuration["DB"];
        }

        public IUser CreateUser()
        {
            string className = assemblyName + "." + db + "User";
            return (IUser)Assembly.Load(assemblyName).CreateInstance(className);
        }

        public IDepartment CreateDepartment()
        {
            string className = assemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(assemblyName).CreateInstance(className);
        }
    }
}