using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Models;

public partial class TiendapetshopContext : DbContext
{
    public TiendapetshopContext()
    {
    }

    public TiendapetshopContext(DbContextOptions<TiendapetshopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ProductosUsuario> ProductosUsuarios { get; set; }

    public virtual DbSet<ProductosVenta> ProductosVentas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__9B4120E2290AA0B6");

            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Imagen)
                .IsUnicode(false)
                .HasColumnName("imagen");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("Precio_Unitario");
        });

        modelBuilder.Entity<ProductosUsuario>(entity =>
        {
            entity.HasKey(e => e.IdUproducto).HasName("PK__Producto__F06FED6BD523DBB4");

            entity.Property(e => e.IdUproducto).HasColumnName("ID_UProducto");
            entity.Property(e => e.Fechai)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductosUsuarios)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("fk_ProdProdUsu");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.ProductosUsuarios)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("fk_UsuarProdUsu");
        });

        modelBuilder.Entity<ProductosVenta>(entity =>
        {
            entity.HasKey(e => e.IdVproducto).HasName("PK__Producto__3DA84B3DFB1CD95A");

            entity.Property(e => e.IdVproducto).HasColumnName("ID_Vproducto");
            entity.Property(e => e.IdProducto).HasColumnName("ID_Producto");
            entity.Property(e => e.IdVenta).HasColumnName("ID_Venta");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.ProductosVenta)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("fk_prodProdVen");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.ProductosVenta)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("fk_ventaProdVen");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__DE4431C529E92BC9");

            entity.Property(e => e.IdUsuario).HasColumnName("ID_Usuario");
            entity.Property(e => e.ApellidoM)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Apellido_M");
            entity.Property(e => e.ApellidoP)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Apellido_P");
            entity.Property(e => e.Clave)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Trol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Usuario");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Ventas__3CD842E5F1D0BEC6");

            entity.Property(e => e.IdVenta).HasColumnName("ID_Venta");
            entity.Property(e => e.FechaCompra)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Compra");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
