using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DbConnectWithSimpleFactoryReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            // add necessary services
            services.AddSingleton<IConfiguration>(config);
            services.AddSingleton<DataAccess>();

            // build the pipeline
            var provider = services.BuildServiceProvider();


            User user = new User();
            Department dept = new Department();


            var dataAccess = provider.GetService<DataAccess>();

            IUser iu = dataAccess.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IDepartment idept = dataAccess.CreateDepartment();
            idept.Insert(dept);
            idept.GetDepartment(1);

            Console.Read();
        }
    }
}
