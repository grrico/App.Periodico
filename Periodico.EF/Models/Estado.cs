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
	[Table("Estado")]
	public partial class Estado
	{
		public Estado()
		{
			Autor = new HashSet<Autor>();
			Noticia = new HashSet<Noticia>();
			Compania = new HashSet<Compania>();
		}

		[Key]
		public int Codigo { get; set; }

		[Column(TypeName =  "VARCHAR")]
		[Display(Name = "Nombre_Estado")]
		[StringLength(20, ErrorMessage = "La {0} debe tener una longitud máxima {1}")]
		public string Nombre_Estado { get; set; }

		[Display(Name = "Activo")]
		public bool? Activo { get; set; } = false ; 

		public virtual ICollection<Autor> Autor { get; set; }
		public virtual ICollection<Noticia> Noticia { get; set; }
		public virtual ICollection<Compania> Compania { get; set; }
	}

}
