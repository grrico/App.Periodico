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

	[RoutePrefix("api/Noticia")]
	public class NoticiaController : ApiController
	{
		public IInformacionNoticiaBusiness informacionnoticia { get; set; }

		public NoticiaController()
		{
			informacionnoticia = new InformacionNoticiaBusiness();
		}

		[HttpPost]
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaGet/")]
		public async Task<IHttpActionResult> NoticiaGet(NoticiaRequest noticia)
		{
			try
			{
				if (ModelState.IsValid)
				{
					NoticiaDTO noticiaDTO = Mapper.Map<NoticiaRequest, NoticiaDTO>(noticia);
					var resultado = await informacionnoticia.GetBy_NoticiaDto(noticia.Codigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							NoticiaResponse datosNoticiaResponse = Mapper.Map<NoticiaDTO, NoticiaResponse>(resultado.Result);
							return Ok(datosNoticiaResponse);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaGetAll/")]
		public async Task<IHttpActionResult> NoticiaGetAll()
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionnoticia.GetBy_NoticiaAll();
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<NoticiaResponse> datosNoticiaResponse = Mapper.Map<List<NoticiaDTO>, List<NoticiaResponse>>(resultado.Result);
							return Ok(datosNoticiaResponse);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaGetBy_Autor/")]
		public async Task<IHttpActionResult> NoticiaGetBy_Autor(long AutorCodigo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionnoticia.GetByAutor(AutorCodigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<NoticiaResponse> datosNoticiaResponse = Mapper.Map<List<NoticiaDTO>, List<NoticiaResponse>>(resultado.Result);
							return Ok(datosNoticiaResponse);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaGetBy_Estado/")]
		public async Task<IHttpActionResult> NoticiaGetBy_Estado(int EstadoCodigo)
		{
			try
			{
				if (ModelState.IsValid)
				{
					var resultado = await informacionnoticia.GetByEstado(EstadoCodigo);
					if (resultado.Success)
					{
						if (resultado.Result != null)
						{
							List<NoticiaResponse> datosNoticiaResponse = Mapper.Map<List<NoticiaDTO>, List<NoticiaResponse>>(resultado.Result);
							return Ok(datosNoticiaResponse);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaCreate/")]
		public async Task<IHttpActionResult> NoticiaCreate(NoticiaRequest noticia)
		{
			try
			{
				if (ModelState.IsValid)
				{
					NoticiaDTO noticiaDTO = Mapper.Map<NoticiaRequest, NoticiaDTO>(noticia);
					var resultado = await informacionnoticia.CreateNoticiaDto(noticiaDTO);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaUpdate/")]
		public async Task<IHttpActionResult> NoticiaUpdate(NoticiaRequest noticia)
		{
			try
			{
				if (ModelState.IsValid)
				{
					NoticiaDTO noticiaDTO = Mapper.Map<NoticiaRequest, NoticiaDTO>(noticia);
					var resultado = await informacionnoticia.UpdateNoticiaDto(noticiaDTO);
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
		[ResponseType(typeof(NoticiaRequest))]
		[Route("NoticiaDelete/")]
		public async Task<IHttpActionResult> NoticiaDelete(NoticiaRequest noticia)
		{
			try
			{
				if (ModelState.IsValid)
				{
					NoticiaDTO noticiaDTO = Mapper.Map<NoticiaRequest, NoticiaDTO>(noticia);
					var resultado = await informacionnoticia.DeleteNoticiaDto(noticiaDTO);
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
