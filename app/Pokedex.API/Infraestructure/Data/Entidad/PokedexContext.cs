using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Pokedex.API.Infraestructure.Data.Entidad
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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=PE-LPALQ001124; Database=Pokedex; User ID=sa;Password=1234;");
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
