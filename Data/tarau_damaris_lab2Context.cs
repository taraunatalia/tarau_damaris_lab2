using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tarau_damaris_lab2.Models;

namespace tarau_damaris_lab2.Data
{
    public class tarau_damaris_lab2Context : DbContext
    {
        public tarau_damaris_lab2Context (DbContextOptions<tarau_damaris_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<tarau_damaris_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<tarau_damaris_lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<tarau_damaris_lab2.Models.Category> Category { get; set; }
    }
}
