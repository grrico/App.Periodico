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
	[Table("Paises")]
	public partial class Paises
	{
		public Paises()
		{
			Compania = new HashSet<Compania>();
		}

		[Key]
		public int Codigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "Nombre")]
		[StringLength(50, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string Nombre { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "NumeroPais")]
		[StringLength(3, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string NumeroPais { get; set; }

		public virtual ICollection<Compania> Compania { get; set; }
	}

}
