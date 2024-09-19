using Microsoft.Extensions.Configuration;

namespace ConsoleSetting
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
            Console.WriteLine($"Name : {configuration.GetSection("Name").Value}");
            Console.WriteLine($"Number : {configuration.GetSection("Number").Value}");
            Console.ReadLine();
        }
    }
}
