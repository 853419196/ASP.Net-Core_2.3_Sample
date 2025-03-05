using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MyWebApp
{
    class Program
    {
        static void Main(String[] args)
        {
            var builder = WebHost.CreateDefaultBuilder<Startup>(args);

            var host = builder.Build();

            host.Run();
        }
    }
}
