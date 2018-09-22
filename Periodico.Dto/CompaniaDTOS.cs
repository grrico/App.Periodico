using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico.DTO
{
	public partial class CompaniaDTO
	{
		public CompaniaDTO()
		{
			AutorDTO = new HashSet<AutorDTO>();
		}

		[Key]
		public long Codigo { get; set; }

		public string Nombre { get; set; }

		public int? EstadoCodigo { get; set; }

		public int? PaisesCosifo { get; set; }

		public virtual ICollection<AutorDTO> AutorDTO { get; set; }
		public virtual EstadoDTO EstadoDTO { get; set; }
		public virtual PaisesDTO PaisesDTO { get; set; }
	}

}
