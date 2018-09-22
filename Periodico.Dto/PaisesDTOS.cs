using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodico.DTO
{
	public partial class PaisesDTO
	{
		public PaisesDTO()
		{
			CompaniaDTO = new HashSet<CompaniaDTO>();
		}

		[Key]
		public int Codigo { get; set; }

		public string Nombre { get; set; }

		public string NumeroPais { get; set; }

		public virtual ICollection<CompaniaDTO> CompaniaDTO { get; set; }
	}

}
