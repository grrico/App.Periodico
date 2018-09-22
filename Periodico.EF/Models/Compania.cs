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
	[Table("Compania")]
	public partial class Compania
	{
		public Compania()
		{
			Autor = new HashSet<Autor>();
		}

		[Key]
		public long Codigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "Nombre")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string Nombre { get; set; }

		[Display(Name = "EstadoCodigo")]
		public int? EstadoCodigo { get; set; }

		[Display(Name = "PaisesCosifo")]
		public int? PaisesCosifo { get; set; }

		public virtual ICollection<Autor> Autor { get; set; }
		public virtual Estado Estado { get; set; }
		public virtual Paises Paises { get; set; }
	}

}
