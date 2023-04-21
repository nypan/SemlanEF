using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Semlan.DataSqlite;
using Semlan.Domain.Models;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semlan.SampleApp
{
    public class ServiceWorker : IServiceWorker
    {
        private readonly ILogger<ServiceWorker> _logger;
        private readonly SemlanDbContext _context;

        public ServiceWorker(ILogger<ServiceWorker> logger, SemlanDbContext context)
        {
            _logger = logger;
            _context= context;
        }
        public void DoWork()
        {
            _logger.LogInformation("DoWork has been called.");

            //_context.Database.EnsureDeleted();
            //_context.Database.EnsureCreated();  
            var team1 = new Team { Id = Guid.NewGuid(), Name = "Team 1" };
            var team2 = new Team { Id = Guid.NewGuid(), Name = "Team 2" };
            var team3 = new Team { Id = Guid.NewGuid(), Name = "Team 3" };
            _context.Teams.Add(team1);
            _context.Teams.Add(team2);
            _context.Teams.Add(team3);

            _context.SaveChanges();

        }
    }
}
