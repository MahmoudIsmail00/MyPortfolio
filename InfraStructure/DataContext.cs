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
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "Playstation store app",
                    ImageUrl = "gps.png",
                    ProjectName = "Playstation"
                    
                });
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "Dummy data",
                    ImageUrl = "flappy.png",
                    ProjectName = "Home"

                });
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "Ocean",
                    ImageUrl = "ecole.png",
                    ProjectName = "Sea"

                });
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "Some dummy data",
                    ImageUrl = "instagram.png",
                    ProjectName = "bla bla"

                });
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "Video Rental App",
                    ImageUrl = "commercial.png",
                    ProjectName = "Vidly"

                }) ;
            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = Guid.NewGuid(),
                    Description = "BookStore App",
                    ImageUrl = "angry.png",
                    ProjectName = "Bookly"

                });
            base.OnModelCreating(modelBuilder);

        }
    }
}
