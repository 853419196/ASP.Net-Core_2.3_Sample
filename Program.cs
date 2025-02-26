using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyWebApp
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var builder = WebHost
                .CreateDefaultBuilder(args)
                .UseStartup<Startup>();

            var host = builder.Build();

            host.Run();
        }
    }
}
