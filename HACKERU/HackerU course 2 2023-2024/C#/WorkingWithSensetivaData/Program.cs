using Microsoft.Extensions.Configuration;

namespace WorkingWithSensetivaData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config=new ConfigurationBuilder().AddUserSecrets<Program>().Build();

            string apikey = config["apikey"];
            Console.WriteLine("the apikey is " + apikey);

            string secret = Environment.GetEnvironmentVariable("secret");
            Console.WriteLine("the apikey is " + secret);

        }
    }
}