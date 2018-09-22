namespace Periodico.WebApi.Util
{
	using System;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using Periodico.WebApi.Models;
	using Periodico.DTO;
	using Periodico.EF;

	public partial class AutoMapperConfigWebApi
	{
		internal static void InitializeMapper() => Mapper.Initialize(cfg =>
		{
			cfg.CreateMap<EstadoResponse, EstadoDTO>();
			cfg.CreateMap<EstadoDTO, EstadoResponse>();

			cfg.CreateMap<EstadoRequest, EstadoDTO>();
			cfg.CreateMap<EstadoDTO, EstadoRequest>();

			cfg.CreateMap<EF.Estado, EstadoDTO>();
			cfg.CreateMap<EstadoDTO, EF.Estado>();

			cfg.CreateMap<AutorResponse, AutorDTO>();
			cfg.CreateMap<AutorDTO, AutorResponse>();

			cfg.CreateMap<AutorRequest, AutorDTO>();
			cfg.CreateMap<AutorDTO, AutorRequest>();

			cfg.CreateMap<EF.Autor, AutorDTO>();
			cfg.CreateMap<AutorDTO, EF.Autor>();

			cfg.CreateMap<NoticiaResponse, NoticiaDTO>();
			cfg.CreateMap<NoticiaDTO, NoticiaResponse>();

			cfg.CreateMap<NoticiaRequest, NoticiaDTO>();
			cfg.CreateMap<NoticiaDTO, NoticiaRequest>();

			cfg.CreateMap<EF.Noticia, NoticiaDTO>();
			cfg.CreateMap<NoticiaDTO, EF.Noticia>();

			cfg.CreateMap<CompaniaResponse, CompaniaDTO>();
			cfg.CreateMap<CompaniaDTO, CompaniaResponse>();

			cfg.CreateMap<CompaniaRequest, CompaniaDTO>();
			cfg.CreateMap<CompaniaDTO, CompaniaRequest>();

			cfg.CreateMap<EF.Compania, CompaniaDTO>();
			cfg.CreateMap<CompaniaDTO, EF.Compania>();

			cfg.CreateMap<PaisesResponse, PaisesDTO>();
			cfg.CreateMap<PaisesDTO, PaisesResponse>();

			cfg.CreateMap<PaisesRequest, PaisesDTO>();
			cfg.CreateMap<PaisesDTO, PaisesRequest>();

			cfg.CreateMap<EF.Paises, PaisesDTO>();
			cfg.CreateMap<PaisesDTO, EF.Paises>();

			});
		}
	}
