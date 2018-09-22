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

	[RoutePrefix("api/Autor")]
	public class AutorController : ApiController
	{
		public IInformacionAutorBusiness informacionautor { get; set; }

		public AutorController()
		{
			informacionautor = new InformacionAutorBusiness();
		}

		[HttpPost]
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorGet/")]
		public async Task<IHttpActionResult> AutorGet(AutorRequest autor)
		{
			try
			{
				if (ModelState.IsValid)
				{
					AutorDTO autorDTO = Mapper.Map<AutorRequest, AutorDTO>(autor);
					var resultado = await informacionautor.GetBy_AutorDto(autor.Codigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							AutorResponse datosAutorResponse = Mapper.Map<AutorDTO, AutorResponse>(resultado.Result);
							return Ok(datosAutorResponse);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorGetAll/")]
		public async Task<IHttpActionResult> AutorGetAll()
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionautor.GetBy_AutorAll();
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<AutorResponse> datosAutorResponse = Mapper.Map<List<AutorDTO>, List<AutorResponse>>(resultado.Result);
							return Ok(datosAutorResponse);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorGetBy_Compania/")]
		public async Task<IHttpActionResult> AutorGetBy_Compania(long CompaniaCodigo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionautor.GetByCompania(CompaniaCodigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<AutorResponse> datosAutorResponse = Mapper.Map<List<AutorDTO>, List<AutorResponse>>(resultado.Result);
							return Ok(datosAutorResponse);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorGetBy_Estado/")]
		public async Task<IHttpActionResult> AutorGetBy_Estado(int EstadoCodigo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionautor.GetByEstado(EstadoCodigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<AutorResponse> datosAutorResponse = Mapper.Map<List<AutorDTO>, List<AutorResponse>>(resultado.Result);
							return Ok(datosAutorResponse);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorCreate/")]
		public async Task<IHttpActionResult> AutorCreate(AutorRequest autor)
		{
			try
			{
				if (ModelState.IsValid)
				{
					AutorDTO autorDTO = Mapper.Map<AutorRequest, AutorDTO>(autor);
					var resultado = await informacionautor.CreateAutorDto(autorDTO);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorUpdate/")]
		public async Task<IHttpActionResult> AutorUpdate(AutorRequest autor)
		{
			try
			{
				if (ModelState.IsValid)
				{
					AutorDTO autorDTO = Mapper.Map<AutorRequest, AutorDTO>(autor);
					var resultado = await informacionautor.UpdateAutorDto(autorDTO);
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
		[ResponseType(typeof(AutorRequest))]
		[Route("AutorDelete/")]
		public async Task<IHttpActionResult> AutorDelete(AutorRequest autor)
		{
			try
			{
				if (ModelState.IsValid)
				{
					AutorDTO autorDTO = Mapper.Map<AutorRequest, AutorDTO>(autor);
					var resultado = await informacionautor.DeleteAutorDto(autorDTO);
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
