using ExampleReact.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ExampleReact.Datas
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //Define DbSet Properties for your model Classes
        public DbSet <CPS_area> cPS_Areas { get; set; }
    }
}
