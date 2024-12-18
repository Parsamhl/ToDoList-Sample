using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList_sample.DAL.Configuration;
using ToDoList_sample.Entities;

namespace ToDoList_sample.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=ToDoList;Integrated Security=SSPI;");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new TaskConfiguration());
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<User> users { get; set; }
      
        public DbSet<Duty> tasks { get; set; }

    }
}
