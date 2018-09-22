using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico.DTO
{
	public partial class AutorDTO
	{
		public AutorDTO()
		{
			NoticiaDTO = new HashSet<NoticiaDTO>();
		}

		[Key]
		public long Codigo { get; set; }

		public string PrimerNombre { get; set; }

		public string SegundoNombre { get; set; }

		public string PrimerApellido { get; set; }

		public string SegundoApellido { get; set; }

		public int? EstadoCodigo { get; set; }

		public string EstadoNombre { get; set; }

		public long? CompaniaCodigo { get; set; }

		public virtual ICollection<NoticiaDTO> NoticiaDTO { get; set; }
		public virtual CompaniaDTO CompaniaDTO { get; set; }
		public virtual EstadoDTO EstadoDTO { get; set; }
	}

}
