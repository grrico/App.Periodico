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
	public partial class CompaniaResponse
	{
		public CompaniaResponse()
		{
			AutorResponse = new HashSet<AutorResponse>();
		}

		public long Codigo { get; set; }

		public string Nombre { get; set; }

		public int EstadoCodigo { get; set; }

		public int PaisesCosifo { get; set; }

		public virtual ICollection<AutorResponse> AutorResponse { get; set; }
		public virtual EstadoResponse EstadoResponse { get; set; }
		public virtual PaisesResponse PaisesResponse { get; set; }
	}

}
