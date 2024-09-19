using Microsoft.Extensions.Configuration;

namespace ConsoleSettingApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //loading configuration file
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddEnvironmentVariables()
                .AddJsonFile("./Config/config.json")
                .AddCommandLine(args)
                .Build();


            Console.WriteLine("Hello, World!");
            Console.WriteLine($"Name : {configuration.GetSection("Name").Value}");
            Console.ReadLine();
        }
    }
}
