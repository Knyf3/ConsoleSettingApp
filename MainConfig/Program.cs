using Microsoft.Extensions.Configuration;

namespace MainConfig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Adding Configuration file

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("./Config/config.json")
                .AddCommandLine(args)
                .Build();

            Console.WriteLine("Hello, World!");
            
           
        }
    }
}
