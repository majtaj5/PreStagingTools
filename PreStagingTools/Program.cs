using Microsoft.Extensions.Hosting;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace PreStagingTools
{
    class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program starting...");
            var host = CreateHostBuilder(args).Build();
            host.Services.GetRequiredService<Program>().Run();
            Console.ReadKey();
        }

        public void Run()
        {
            
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddTransient<Program>();
                });
        }
    }
}