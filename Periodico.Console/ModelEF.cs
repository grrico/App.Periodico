namespace Periodico.Console
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelEF : DbContext
    {
        public ModelEF()
            : base("name=ModelEF2")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Compania> Compania { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Noticia> Noticia { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .Property(e => e.PrimerNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.SegundoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.PrimerApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.SegundoApellido)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.EstadoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Compania>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Nombre_Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Noticia>()
                .Property(e => e.TituloNoticia)
                .IsUnicode(false);

            modelBuilder.Entity<Noticia>()
                .Property(e => e.ContenidoNoticia)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .Property(e => e.NumeroPais)
                .IsUnicode(false);

            modelBuilder.Entity<Paises>()
                .HasMany(e => e.Compania)
                .WithOptional(e => e.Paises)
                .HasForeignKey(e => e.PaisesCosifo);
        }
    }
}
