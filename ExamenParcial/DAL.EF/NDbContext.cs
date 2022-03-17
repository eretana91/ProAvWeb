using DAL.DO.Objects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.EF
{
    public partial class NDbContext : DbContext
    {
        public NDbContext()
        {
        }

        public NDbContext(DbContextOptions<NDbContext> options)
           : base(options)
        {
        }
        public virtual DbSet<Autores> Autores { get; set; }
        public virtual DbSet<Libros> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=Northwind2;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autores>(entity =>
            {
                entity.Property(e => e.Creacion).HasColumnType("date");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desactivacion).HasColumnType("date");

                entity.Property(e => e.DesactivadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).IsRequired();

  //              entity.HasOne(d => d.Pais)
  //                  .WithMany(p => p.Autores)
  //                  .HasForeignKey(d => d.PaisId)
   //                 .HasConstraintName("FK_Autores_Pais");
            });

            modelBuilder.Entity<Libros>(entity =>
            {
                entity.Property(e => e.Creacion).HasColumnType("date");

                entity.Property(e => e.CreadoPor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Desactivacion).HasColumnType("date");

                entity.Property(e => e.DesactivadoPor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo).IsRequired();

                entity.HasOne(d => d.Autor)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.AutorId);
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
