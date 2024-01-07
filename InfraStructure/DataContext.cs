using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraStructure
{
    public class DataContext : DbContext
    {
        public DataContext():base()
        { }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Owner> Owner { get; set; }
        public DbSet<PortfolioItem> PortfolioItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=MAHMOUD\\SQLEXPRESS;Initial Catalog=PortfolioDB;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<PortfolioItem>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = Guid.NewGuid(),
                    Profile = ".Net Core Developer",
                    FullName = "MahmoudIsmail",
                    Avatar = "avatar.jpg",
                    Address ="Cairo"
                }
                );
            base.OnModelCreating(modelBuilder);

        }
    }
}
