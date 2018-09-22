using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Periodico.WebApi.Models;
using Periodico.Business;
using Periodico.DTO;
using AutoMapper;
using System.Web.Http.Description;

namespace Periodico.WebApi.Models
{
	public partial class AutorResponse
	{
		public AutorResponse()
		{
			NoticiaResponse = new HashSet<NoticiaResponse>();
		}

		public long Codigo { get; set; }

		public string PrimerNombre { get; set; }

		public string SegundoNombre { get; set; }

		public string PrimerApellido { get; set; }

		public string SegundoApellido { get; set; }

		public int EstadoCodigo { get; set; }

		public string EstadoNombre { get; set; }

		public long CompaniaCodigo { get; set; }

		public virtual ICollection<NoticiaResponse> NoticiaResponse { get; set; }
		public virtual CompaniaResponse CompaniaResponse { get; set; }
		public virtual EstadoResponse EstadoResponse { get; set; }
	}

}
