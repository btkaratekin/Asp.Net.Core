using Microsoft.EntityFrameworkCore;
using OgrIsler.Entities.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace OgrIsler.DataAccess.Concrete.EntityFramework
{
    public class OgrIslerDbContext:DbContext
    {
        public DbSet<Bilgi> OgrBilgi { get; set; }
        public DbSet<Okul> OgrOkul { get; set; }
        public DbSet<Danisman> OgrDanisman { get; set; }
        public DbSet<Bolum> OgrBolum { get; set; }
        public DbSet<PrograM> OgrProgram { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=OgrIslerCore;Integrated Security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bilgi>().ToTable("OgrBilgi");
            modelBuilder.Entity<Okul>().ToTable("OgrOkul");
            modelBuilder.Entity<Bolum>().ToTable("OgrBolum");
            modelBuilder.Entity<PrograM>().ToTable("OgrProgram");
            modelBuilder.Entity<Danisman>().ToTable("OgrDanisman");

            modelBuilder.Entity<Bilgi>().HasOne(b => b.okul).WithOne(b => b.bilgi).HasForeignKey<Okul>(o => o.OgrNo);
            modelBuilder.Entity<Okul>().HasOne(o => o.Programkodu).WithMany(p => p.okullar).HasForeignKey("Pkodu");
            modelBuilder.Entity<Okul>().HasOne(o => o.Danismankodu).WithMany(d => d.okullar).HasForeignKey("Dkodu");
            modelBuilder.Entity<PrograM>().HasOne(p => p.Bolumkodu).WithMany(b => b.programlar).HasForeignKey("Bkodu");
            modelBuilder.Entity<Danisman>().HasOne(d => d.Bolumkodu).WithMany(b => b.danismanlar).HasForeignKey("Bkodu");

        }
    }
    
}
