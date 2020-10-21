using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_adopet.Shared;

namespace web_adopet.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Ong> Ongs { get; set; }
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Vacina> Vacinas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ANIMAL - CATEGORIA
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Categoria)
                .WithMany(c => c.Animais);

            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Animais)
                .WithOne(a => a.Categoria);

            // ANIMAL - RAÇA
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Raca)
                .WithMany(r => r.Animais);

            modelBuilder.Entity<Raca>()
                .HasMany(r => r.Animais)
                .WithOne(a => a.Raca);

            // ANIMAL - ONG
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Ong)
                .WithMany(o => o.Animais);

            modelBuilder.Entity<Ong>()
                .HasMany(o => o.Animais)
                .WithOne(a => a.Ong);

            // ANIMAL - FOTO
            modelBuilder.Entity<Foto>()
                .HasOne(f => f.Animal)
                .WithMany(a => a.Fotos);

            modelBuilder.Entity<Animal>()
                .HasMany(a => a.Fotos)
                .WithOne(f => f.Animal);

            // ANIMAL - HISTORICO
            modelBuilder.Entity<Animal>()
                .HasOne(a => a.Historico)
                .WithOne(h => h.Animal)
                .HasForeignKey<Historico>(h => h.AnimalId);

            // VACINAS - HISTORICO
            modelBuilder.Entity<Historico>()
                .HasOne(h => h.Vacina)
                .WithOne(v => v.Historico)
                .HasForeignKey<Vacina>(v => v.HistoricoId);

            // RAÇA - CATEGORIA
            modelBuilder.Entity<Raca>()
                .HasOne(r => r.Categoria)
                .WithMany(c => c.Racas);

            modelBuilder.Entity<Categoria>()
                .HasMany(c => c.Racas)
                .WithOne(r => r.Categoria);
        }
    }
}