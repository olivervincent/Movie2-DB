﻿using Microsoft.EntityFrameworkCore;
using System;


#nullable disable

namespace EFCoreMovie2_RazorPages.Models
{
    public partial class MovieDBContext : DbContext
    {
        public MovieDBContext()
        {
        }
        public MovieDBContext(DbContextOptions<MovieDBContext> options)
            : base(options)
        {
        }
       public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Studio> Studios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost,1433;Database=master;User Id=sa;Password=Localhost1!;TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Title).IsFixedLength(true);
                
                entity.HasOne(d => d.Studio)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.StudioId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Studio>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Hqcity).IsFixedLength(true);

                entity.Property(e => e.Name).IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
