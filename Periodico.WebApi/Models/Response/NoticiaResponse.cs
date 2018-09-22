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
	public partial class NoticiaResponse
	{
		public NoticiaResponse()
		{
		}

		public int Codigo { get; set; }

		public string TituloNoticia { get; set; }

		public string ContenidoNoticia { get; set; }

		public DateTime Fecha { get; set; }

		public long AutorCodigo { get; set; }

		public int EstadoCodigo { get; set; }

		public virtual AutorResponse AutorResponse { get; set; }
		public virtual EstadoResponse EstadoResponse { get; set; }
	}

}
