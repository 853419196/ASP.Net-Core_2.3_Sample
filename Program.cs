using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Startup = MyWebApp.Startup;

class Program
{
    static void Main(String[] args)
    {
        var builder = WebHost.CreateDefaultBuilder<Startup>(args);

        var host = builder.Build();

        host.Run();
    }
}
