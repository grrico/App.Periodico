using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico.DTO
{
	public partial class NoticiaDTO
	{
		public NoticiaDTO()
		{
		}

		[Key]
		public int Codigo { get; set; }

		public string TituloNoticia { get; set; }

		public string ContenidoNoticia { get; set; }

		public DateTime? Fecha { get; set; }

		public long? AutorCodigo { get; set; }

		public int? EstadoCodigo { get; set; }

		public virtual AutorDTO AutorDTO { get; set; }
		public virtual EstadoDTO EstadoDTO { get; set; }
	}

}
