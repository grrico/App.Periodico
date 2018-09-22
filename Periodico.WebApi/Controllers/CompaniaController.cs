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

	[RoutePrefix("api/Compania")]
	public class CompaniaController : ApiController
	{
		public IInformacionCompaniaBusiness informacioncompania { get; set; }

		public CompaniaController()
		{
			informacioncompania = new InformacionCompaniaBusiness();
		}

		[HttpPost]
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaGet/")]
		public async Task<IHttpActionResult> CompaniaGet(CompaniaRequest compania)
		{
			try
			{
				if (ModelState.IsValid)
				{
					CompaniaDTO companiaDTO = Mapper.Map<CompaniaRequest, CompaniaDTO>(compania);
					var resultado = await informacioncompania.GetBy_CompaniaDto(compania.Codigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							CompaniaResponse datosCompaniaResponse = Mapper.Map<CompaniaDTO, CompaniaResponse>(resultado.Result);
							return Ok(datosCompaniaResponse);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaGetAll/")]
		public async Task<IHttpActionResult> CompaniaGetAll()
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacioncompania.GetBy_CompaniaAll();
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<CompaniaResponse> datosCompaniaResponse = Mapper.Map<List<CompaniaDTO>, List<CompaniaResponse>>(resultado.Result);
							return Ok(datosCompaniaResponse);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaGetBy_Estado/")]
		public async Task<IHttpActionResult> CompaniaGetBy_Estado(int EstadoCodigo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacioncompania.GetByEstado(EstadoCodigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<CompaniaResponse> datosCompaniaResponse = Mapper.Map<List<CompaniaDTO>, List<CompaniaResponse>>(resultado.Result);
							return Ok(datosCompaniaResponse);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaGetBy_Paises/")]
		public async Task<IHttpActionResult> CompaniaGetBy_Paises(int PaisesCosifo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacioncompania.GetByPaises(PaisesCosifo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<CompaniaResponse> datosCompaniaResponse = Mapper.Map<List<CompaniaDTO>, List<CompaniaResponse>>(resultado.Result);
							return Ok(datosCompaniaResponse);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaCreate/")]
		public async Task<IHttpActionResult> CompaniaCreate(CompaniaRequest compania)
		{
			try
			{
				if (ModelState.IsValid)
				{
					CompaniaDTO companiaDTO = Mapper.Map<CompaniaRequest, CompaniaDTO>(compania);
					var resultado = await informacioncompania.CreateCompaniaDto(companiaDTO);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaUpdate/")]
		public async Task<IHttpActionResult> CompaniaUpdate(CompaniaRequest compania)
		{
			try
			{
				if (ModelState.IsValid)
				{
					CompaniaDTO companiaDTO = Mapper.Map<CompaniaRequest, CompaniaDTO>(compania);
					var resultado = await informacioncompania.UpdateCompaniaDto(companiaDTO);
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
		[ResponseType(typeof(CompaniaRequest))]
		[Route("CompaniaDelete/")]
		public async Task<IHttpActionResult> CompaniaDelete(CompaniaRequest compania)
		{
			try
			{
				if (ModelState.IsValid)
				{
					CompaniaDTO companiaDTO = Mapper.Map<CompaniaRequest, CompaniaDTO>(compania);
					var resultado = await informacioncompania.DeleteCompaniaDto(companiaDTO);
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
