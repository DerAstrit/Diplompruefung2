using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spicker
{
    internal class Context : DbContext
    {
        public DbSet<Mutter> Mutters { get; set; }
        public DbSet<Proband> Probanden { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=spicker;Trusted_Connection=true;trustservercertificate=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mutter>().HasKey(m => m.Id);    //Primärschlüssel
            modelBuilder.Entity<Proband>().HasKey(p => p.Id);
            modelBuilder.Entity<Pate>().HasKey(p => p.Id);
            modelBuilder.Entity<Freund>().HasKey(p => p.Id);

            modelBuilder.Entity<Proband>().HasOne(p => p.Mutter)
                .WithMany(m => m.Probanden)
                .HasForeignKey(p => p.MutterID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Proband>()
                .HasOne(p => p.Pate)
                .WithOne(p => p.Proband)
                .HasForeignKey<Proband>(p => p.PateId)
                .OnDelete(DeleteBehavior.Restrict);  //Frage



            modelBuilder.Entity<Feundschaft>()
                .HasKey(ff => new { ff.ProbandID, ff.FreundID });

            modelBuilder.Entity<Feundschaft>()
                .HasOne(ff => ff.Proband)
                .WithMany(p => p.Feundschaften)
                .HasForeignKey(ff => ff.ProbandID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Feundschaft>()
                .HasOne(ff => ff.Freund)
                .WithMany(f => f.Feundschaften)
                .HasForeignKey(ff => ff.FreundID);
        }
    }
}
