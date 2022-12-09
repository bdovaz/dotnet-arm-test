using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using test;

IWebHost host = WebHost.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext, services) =>
    {
        services.AddMemoryCache();

        services.AddLogging(loggingBuilder =>
        {
            loggingBuilder.AddConfiguration(hostContext.Configuration.GetSection("Logging"));
        });
    })
    .UseStartup<Startup>()
    .Build();

host.Run();
