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
	public partial class EstadoRequest
	{
		public int Codigo { get; set; }

		public string Nombre_Estado { get; set; }

		public bool Activo { get; set; }

	}

}
