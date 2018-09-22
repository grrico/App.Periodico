using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Periodico.EF
{
	[Table("Noticia")]
	public partial class Noticia
	{
		public Noticia()
		{
		}

		[Key]
		public int Codigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "TituloNoticia")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string TituloNoticia { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "ContenidoNoticia")]
		public string ContenidoNoticia { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
		[Display(Name = "Fecha")]
		public DateTime? Fecha { get; set; }

		[Display(Name = "AutorCodigo")]
		public long? AutorCodigo { get; set; }

		[Display(Name = "EstadoCodigo")]
		public int? EstadoCodigo { get; set; }

		public virtual Autor Autor { get; set; }
		public virtual Estado Estado { get; set; }
	}

}
