using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico.DTO
{
	public partial class EstadoDTO
	{
		public EstadoDTO()
		{
			AutorDTO = new HashSet<AutorDTO>();
			NoticiaDTO = new HashSet<NoticiaDTO>();
			CompaniaDTO = new HashSet<CompaniaDTO>();
		}

		[Key]
		public int Codigo { get; set; }

		public string Nombre_Estado { get; set; }

		public bool? Activo { get; set; } = false ; 

		public virtual ICollection<AutorDTO> AutorDTO { get; set; }
		public virtual ICollection<NoticiaDTO> NoticiaDTO { get; set; }
		public virtual ICollection<CompaniaDTO> CompaniaDTO { get; set; }
	}

}
