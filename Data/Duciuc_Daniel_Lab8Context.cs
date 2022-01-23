using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Duciuc_Daniel_Lab8.Models;

namespace Duciuc_Daniel_Lab8.Data
{
    public class Duciuc_Daniel_Lab8Context : DbContext
    {
        public Duciuc_Daniel_Lab8Context (DbContextOptions<Duciuc_Daniel_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Duciuc_Daniel_Lab8.Models.Book> Book { get; set; }

        public DbSet<Duciuc_Daniel_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Duciuc_Daniel_Lab8.Models.Category> Category { get; set; }
    }
}
