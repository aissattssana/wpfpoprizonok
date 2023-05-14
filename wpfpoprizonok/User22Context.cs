using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace wpfpoprizonok;

public partial class User22Context : DbContext
{
    public User22Context()
    {
    }

    public User22Context(DbContextOptions<User22Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Agent> Agents { get; set; }

    public virtual DbSet<Manager> Managers { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductSale> ProductSales { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-P5Q77BG;Database=user_22;Trusted_Connection=True;Persist Security Info=False;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Agent>(entity =>
        {
            entity.ToTable("Agent");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AgentIndex).HasMaxLength(255);
            entity.Property(e => e.City).HasMaxLength(255);
            entity.Property(e => e.Director).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.HouseNumber).HasMaxLength(255);
            entity.Property(e => e.Inn)
                .HasMaxLength(255)
                .HasColumnName("INN");
            entity.Property(e => e.Kpp)
                .HasMaxLength(255)
                .HasColumnName("KPP");
            entity.Property(e => e.Logo).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Region).HasMaxLength(255);
            entity.Property(e => e.Street).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<Manager>(entity =>
        {
            entity.ToTable("Manager");

            entity.Property(e => e.ManagerId)
                .ValueGeneratedNever()
                .HasColumnName("ManagerID");
            entity.Property(e => e.ManagerBank).HasMaxLength(50);
            entity.Property(e => e.ManagerBirthData).HasMaxLength(50);
            entity.Property(e => e.ManagerDegree).HasMaxLength(50);
            entity.Property(e => e.ManagerFamily).HasMaxLength(50);
            entity.Property(e => e.ManagerHealth).HasMaxLength(50);
            entity.Property(e => e.ManagerName).HasMaxLength(50);
            entity.Property(e => e.ManagerNfc)
                .HasMaxLength(10)
                .HasColumnName("ManagerNFC");
            entity.Property(e => e.ManagerPasport).HasMaxLength(50);
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Material");

            entity.Property(e => e.MaterialDescription).HasMaxLength(50);
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.MaterialName).HasMaxLength(50);
            entity.Property(e => e.MaterialPhoto).HasMaxLength(50);
            entity.Property(e => e.MaterialType).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Product");

            entity.Property(e => e.Articul).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<ProductSale>(entity =>
        {
            entity.ToTable("ProductSale");

            entity.Property(e => e.ProductSaleId)
                .ValueGeneratedNever()
                .HasColumnName("ProductSaleID");
            entity.Property(e => e.AgentName).HasMaxLength(50);
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ProductName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
