using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Courses.DbContextData
{
    public class ApplicationDbContext : DbContext
    {
        string connectionString;
        public ApplicationDbContext(string connection)
        {
            connectionString = connection;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=OnlineCourse;Username=postgres;Password=q1w2e3");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
