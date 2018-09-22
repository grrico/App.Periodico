namespace Periodico.WebApi.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using AutoMapper;
	using System.Net;
	using System.Net.Http;
	using System.Threading.Tasks;
	using System.Web.Http;
	using System.Web.Http.Description;
	using Periodico.WebApi;
	using Periodico.WebApi.Models;
	using Periodico.Business;
	using Periodico.Business.Model;
	using Periodico.DTO;

	[RoutePrefix("api/Estado")]
	public class EstadoController : ApiController
	{
		public IInformacionEstadoBusiness informacionestado { get; set; }

		public EstadoController()
		{
			informacionestado = new InformacionEstadoBusiness();
		}

		[HttpPost]
		[ResponseType(typeof(EstadoRequest))]
		[Route("EstadoGet/")]
		public async Task<IHttpActionResult> EstadoGet(EstadoRequest estado)
		{
			try
			{
				if (ModelState.IsValid)
				{
					EstadoDTO estadoDTO = Mapper.Map<EstadoRequest, EstadoDTO>(estado);
					var resultado = await informacionestado.GetBy_EstadoDto(estado.Codigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							EstadoResponse datosEstadoResponse = Mapper.Map<EstadoDTO, EstadoResponse>(resultado.Result);
							return Ok(datosEstadoResponse);
						}
						else
						{
							return NotFound();
						}
					}
					else
					{
						return BadRequest(resultado.Error.ToString());
					}
				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		[ResponseType(typeof(EstadoRequest))]
		[Route("EstadoGetAll/")]
		public async Task<IHttpActionResult> EstadoGetAll()
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionestado.GetBy_EstadoAll();
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<EstadoResponse> datosEstadoResponse = Mapper.Map<List<EstadoDTO>, List<EstadoResponse>>(resultado.Result);
							return Ok(datosEstadoResponse);
						}
						else
						{
							return NotFound();
						}
					}
					else
					{
						return BadRequest(resultado.Error.ToString());
					}
				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		[ResponseType(typeof(EstadoRequest))]
		[Route("EstadoCreate/")]
		public async Task<IHttpActionResult> EstadoCreate(EstadoRequest estado)
		{
			try
			{
				if (ModelState.IsValid)
				{
					EstadoDTO estadoDTO = Mapper.Map<EstadoRequest, EstadoDTO>(estado);
					var resultado = await informacionestado.CreateEstadoDto(estadoDTO);
					if (resultado.Success)
					{
						return Ok(resultado.Result);
					}
					else
					{
						return BadRequest(resultado.Error.ToString());
					}
				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		[ResponseType(typeof(EstadoRequest))]
		[Route("EstadoUpdate/")]
		public async Task<IHttpActionResult> EstadoUpdate(EstadoRequest estado)
		{
			try
			{
				if (ModelState.IsValid)
				{
					EstadoDTO estadoDTO = Mapper.Map<EstadoRequest, EstadoDTO>(estado);
					var resultado = await informacionestado.UpdateEstadoDto(estadoDTO);
					if (resultado.Success)
					{
						return Ok(resultado.Result);
					}
					else
					{
						return BadRequest(resultado.Error.ToString());
					}
				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

		[HttpPost]
		[ResponseType(typeof(EstadoRequest))]
		[Route("EstadoDelete/")]
		public async Task<IHttpActionResult> EstadoDelete(EstadoRequest estado)
		{
			try
			{
				if (ModelState.IsValid)
				{
					EstadoDTO estadoDTO = Mapper.Map<EstadoRequest, EstadoDTO>(estado);
					var resultado = await informacionestado.DeleteEstadoDto(estadoDTO);
					if (resultado.Success)
					{
						return Ok(resultado.Result);
					}
					else
					{
						return BadRequest(resultado.Error.ToString());
					}
				}
				return BadRequest(ModelState);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.ToString());
			}
		}

	}
}
