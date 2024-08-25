using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MiParcialitoEC100521Login.Models;

public partial class UfgbdContext : DbContext
{
    public UfgbdContext()
    {
    }

    public UfgbdContext(DbContextOptions<UfgbdContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Municipio> Municipios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost; Database=UFGBD; User Id=sa;password=p4nC0n-Q3s0!;Encrypt=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepaId)
                .HasMaxLength(255)
                .HasColumnName("depa_id");
            entity.Property(e => e.DepaNombre)
                .HasMaxLength(255)
                .HasColumnName("depa_nombre");
        });

        modelBuilder.Entity<Municipio>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DepaId)
                .HasMaxLength(255)
                .HasColumnName("depa_id");
            entity.Property(e => e.MuniId)
                .HasMaxLength(255)
                .HasColumnName("muni_id");
            entity.Property(e => e.MuniNombre)
                .HasMaxLength(255)
                .HasColumnName("muni_nombre");
            entity.Property(e => e.MunidepaId).HasColumnName("munidepa_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
