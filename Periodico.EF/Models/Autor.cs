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
	[Table("Autor")]
	public partial class Autor
	{
		public Autor()
		{
			Noticia = new HashSet<Noticia>();
		}

		[Key]
		public long Codigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "PrimerNombre")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string PrimerNombre { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "SegundoNombre")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string SegundoNombre { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "PrimerApellido")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string PrimerApellido { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "SegundoApellido")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string SegundoApellido { get; set; }

		[Display(Name = "EstadoCodigo")]
		public int? EstadoCodigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "EstadoNombre")]
		[StringLength(30, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string EstadoNombre { get; set; }

		[Display(Name = "CompaniaCodigo")]
		public long? CompaniaCodigo { get; set; }

		public virtual ICollection<Noticia> Noticia { get; set; }
		public virtual Compania Compania { get; set; }
		public virtual Estado Estado { get; set; }
	}

}
