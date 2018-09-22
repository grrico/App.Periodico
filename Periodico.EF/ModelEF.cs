namespace Periodico.EF
{
	using System;
	using System.Linq;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class ModelEF : DbContext
	{
		public ModelEF()
		      : base("name = ModelEF")


		{
			    Database.SetInitializer<ModelEF>(null);
		}
		public virtual DbSet<Estado> Estado { get; set; }
		public virtual DbSet<Autor> Autor { get; set; }
		public virtual DbSet<Noticia> Noticia { get; set; }
		public virtual DbSet<Compania> Compania { get; set; }
		public virtual DbSet<Paises> Paises { get; set; }
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Estado>()
			.Property(e => e.Nombre_Estado)
			.IsUnicode(false);

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

			modelBuilder.Entity<Noticia>()
			.Property(e => e.TituloNoticia)
			.IsUnicode(false);

			modelBuilder.Entity<Noticia>()
			.Property(e => e.ContenidoNoticia)
			.IsUnicode(false);

			modelBuilder.Entity<Compania>()
			.Property(e => e.Nombre)
			.IsUnicode(false);

			modelBuilder.Entity<Paises>()
			.Property(e => e.Nombre)
			.IsUnicode(false);

			modelBuilder.Entity<Paises>()
			.Property(e => e.NumeroPais)
			.IsUnicode(false);

		}
	}
}
