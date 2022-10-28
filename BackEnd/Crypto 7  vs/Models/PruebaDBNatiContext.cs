using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Crypto_7__vs.Models
{
    public partial class PruebaDBNatiContext : DbContext
    {
        public PruebaDBNatiContext()
        {
        }

        public PruebaDBNatiContext(DbContextOptions<PruebaDBNatiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Crypto> Cryptos { get; set; } = null!;
        public virtual DbSet<CryptoXusuario> CryptoXusuarios { get; set; } = null!;
        public virtual DbSet<Transaccion> Transaccions { get; set; } = null!;
        public virtual DbSet<Transaccione> Transacciones { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-SDJP9G6;Initial Catalog=PruebaDBNati;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Crypto>(entity =>
            {
                entity.HasKey(e => e.IdCrypto);

                entity.ToTable("Crypto");

                entity.Property(e => e.IdCrypto)
                    .ValueGeneratedNever()
                    .HasColumnName("idCrypto");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreCorto)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("nombreCorto");

                entity.Property(e => e.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<CryptoXusuario>(entity =>
            {
                entity.HasKey(e => new { e.Mail, e.IdCrypto });

                entity.ToTable("CryptoXUsuario");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.IdCrypto).HasColumnName("idCrypto");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.HasOne(d => d.IdCryptoNavigation)
                    .WithMany(p => p.CryptoXusuarios)
                    .HasForeignKey(d => d.IdCrypto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CryptoXUsuario_Crypto");

                entity.HasOne(d => d.MailNavigation)
                    .WithMany(p => p.CryptoXusuarios)
                    .HasForeignKey(d => d.Mail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CryptoXUsuario_Usuario");
            });

            modelBuilder.Entity<Transaccion>(entity =>
            {
                entity.HasKey(e => e.IdTransaccion);

                entity.ToTable("Transaccion");

                entity.Property(e => e.IdTransaccion)
                    .ValueGeneratedNever()
                    .HasColumnName("idTransaccion");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdCrypto).HasColumnName("idCrypto");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.MailComprador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mailComprador");

                entity.Property(e => e.MailVendedor)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mailVendedor");

                entity.HasOne(d => d.IdCryptoNavigation)
                    .WithMany(p => p.Transaccions)
                    .HasForeignKey(d => d.IdCrypto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaccion_Crypto");

                entity.HasOne(d => d.MailCompradorNavigation)
                    .WithMany(p => p.TransaccionMailCompradorNavigations)
                    .HasForeignKey(d => d.MailComprador)
                    .HasConstraintName("FK_Transaccion_Usuario1");

                entity.HasOne(d => d.MailVendedorNavigation)
                    .WithMany(p => p.TransaccionMailVendedorNavigations)
                    .HasForeignKey(d => d.MailVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transaccion_Usuario");
            });

            modelBuilder.Entity<Transaccione>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hash)
                    .IsUnicode(false)
                    .HasColumnName("hash");

                entity.Property(e => e.IdComprador).HasColumnName("id_comprador");

                entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");

                entity.Property(e => e.Moneda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("moneda");

                entity.Property(e => e.Monto).HasColumnName("monto");

                entity.HasOne(d => d.IdCompradorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdComprador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transacciones_Clientes_comprador");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdVendedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transacciones_Clientes_vendedor");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Mail);

                entity.ToTable("Usuario");

                entity.Property(e => e.Mail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("telefono");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
