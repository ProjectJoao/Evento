using Eventos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventos
{
    public class EventosDbContext : DbContext
    {
        public EventosDbContext(DbContextOptions<EventosDbContext> options)
            : base(options) { }

        public DbSet<pessoa> pessoas { get; set; }
        public DbSet<sala> salas { get; set; }
        public DbSet<cafe> cafes { get; set; }
    }
}
