using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Pokedex.API.Infrastructure.Data.Entities;

#nullable disable

namespace Pokedex.API.Infrastructure.Data.Context
{
    public partial class PokedexContext : DbContext
    {
        public PokedexContext()
        {
        }

        public PokedexContext(DbContextOptions<PokedexContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pokemon> Pokemons { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=DbConnection");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.ToTable("Pokemon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.BaseAttack).HasColumnName("baseAttack");

                entity.Property(e => e.BaseDefense).HasColumnName("baseDefense");

                entity.Property(e => e.BaseHp).HasColumnName("baseHP");

                entity.Property(e => e.BaseSpAttack).HasColumnName("baseSp_Attack");

                entity.Property(e => e.BaseSpDefense).HasColumnName("baseSp_Defense");

                entity.Property(e => e.BaseSpeed).HasColumnName("baseSpeed");

                entity.Property(e => e.Namechinese)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("namechinese");

                entity.Property(e => e.Nameenglish)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("nameenglish");

                entity.Property(e => e.Namefrench)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("namefrench");

                entity.Property(e => e.Namejapanese)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("namejapanese");

                entity.Property(e => e.Numero)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("numero");

                entity.Property(e => e.RutaImagen)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("rutaImagen");

                entity.Property(e => e.RutaMiniatura)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("rutaMiniatura");

                entity.Property(e => e.Type0)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type0");

                entity.Property(e => e.Type1)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("type1");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.English)
                    .HasName("PK__Tipo__7416F11185B8D478");

                entity.ToTable("Tipo");

                entity.Property(e => e.English)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("english");

                entity.Property(e => e.Chinese)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("chinese");

                entity.Property(e => e.Japanese)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("japanese");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
