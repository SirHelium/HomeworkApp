using HomeworkApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp.Data
{
    public class MotoAppDbContext : DbContext
    {
        public DbSet<Student> Employee => Set<Student>();
        public DbSet<Professor> BusinessPartners => Set<Professor>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseInMemoryDatabase("StorageAppDb");
        }
    }
}
