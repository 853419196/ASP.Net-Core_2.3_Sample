using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyWebApp
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var builder = WebHost.CreateDefaultBuilder<Startup>(args);

            var host = builder.Build();

            host.Run();
        }
    }
}
