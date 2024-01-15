using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Day7Assignment.Models;

namespace Day7Assignment.Data
{
    public class Day7AssignmentDbContext : DbContext
    {
        public Day7AssignmentDbContext (DbContextOptions<Day7AssignmentDbContext> options)
            : base(options)
        {
        }

        public DbSet<Day7Assignment.Models.Player> Player { get; set; } = default!;
    }
}
