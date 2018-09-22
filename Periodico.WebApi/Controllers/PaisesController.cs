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

	[RoutePrefix("api/Paises")]
	public class PaisesController : ApiController
	{
		public IInformacionPaisesBusiness informacionpaises { get; set; }

		public PaisesController()
		{
			informacionpaises = new InformacionPaisesBusiness();
		}

		[HttpPost]
		[ResponseType(typeof(PaisesRequest))]
		[Route("PaisesGet/")]
		public async Task<IHttpActionResult> PaisesGet(PaisesRequest paises)
		{
			try
			{
				if (ModelState.IsValid)
				{
					PaisesDTO paisesDTO = Mapper.Map<PaisesRequest, PaisesDTO>(paises);
					var resultado = await informacionpaises.GetBy_PaisesDto(paises.Codigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							PaisesResponse datosPaisesResponse = Mapper.Map<PaisesDTO, PaisesResponse>(resultado.Result);
							return Ok(datosPaisesResponse);
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
		[ResponseType(typeof(PaisesRequest))]
		[Route("PaisesGetAll/")]
		public async Task<IHttpActionResult> PaisesGetAll()
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionpaises.GetBy_PaisesAll();
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<PaisesResponse> datosPaisesResponse = Mapper.Map<List<PaisesDTO>, List<PaisesResponse>>(resultado.Result);
							return Ok(datosPaisesResponse);
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
		[ResponseType(typeof(PaisesRequest))]
		[Route("PaisesCreate/")]
		public async Task<IHttpActionResult> PaisesCreate(PaisesRequest paises)
		{
			try
			{
				if (ModelState.IsValid)
				{
					PaisesDTO paisesDTO = Mapper.Map<PaisesRequest, PaisesDTO>(paises);
					var resultado = await informacionpaises.CreatePaisesDto(paisesDTO);
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
		[ResponseType(typeof(PaisesRequest))]
		[Route("PaisesUpdate/")]
		public async Task<IHttpActionResult> PaisesUpdate(PaisesRequest paises)
		{
			try
			{
				if (ModelState.IsValid)
				{
					PaisesDTO paisesDTO = Mapper.Map<PaisesRequest, PaisesDTO>(paises);
					var resultado = await informacionpaises.UpdatePaisesDto(paisesDTO);
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
		[ResponseType(typeof(PaisesRequest))]
		[Route("PaisesDelete/")]
		public async Task<IHttpActionResult> PaisesDelete(PaisesRequest paises)
		{
			try
			{
				if (ModelState.IsValid)
				{
					PaisesDTO paisesDTO = Mapper.Map<PaisesRequest, PaisesDTO>(paises);
					var resultado = await informacionpaises.DeletePaisesDto(paisesDTO);
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
