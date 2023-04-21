namespace Semlan.SampleApp;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Semlan.DataSqlite;
using System;

class Program
{
    static  void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
     .SetBasePath(Environment.CurrentDirectory)
     .AddEnvironmentVariables()
     .AddCommandLine(args)
     .AddJsonFile("appsettings.json")
     .AddUserSecrets<Program>()
     .Build();

        var serviceProvider = new ServiceCollection()
            .AddDbContext<SemlanDbContext>(options =>
            {
                var connectionString = configuration.GetConnectionString("SemlanDb");
                options.UseSqlite(connectionString);
            })
            .AddLogging(l =>
            {
                l.AddSimpleConsole(options =>
                {
                    options.SingleLine = true;
                    options.TimestampFormat = "[hh:mm:ss] ";
                });
            })
            .AddSingleton<IServiceWorker, ServiceWorker>()
            .BuildServiceProvider();

        var svc = serviceProvider.GetRequiredService<IServiceWorker>();
        svc.DoWork();

    }
}
