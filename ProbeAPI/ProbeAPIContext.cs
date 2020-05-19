using Microsoft.EntityFrameworkCore;
using ProbeAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProbeAPI
{
    public class ProbeAPIContext : DbContext
    {
        public ProbeAPIContext(DbContextOptions<ProbeAPIContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
    }
}
