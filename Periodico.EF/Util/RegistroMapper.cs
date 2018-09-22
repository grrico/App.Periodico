namespace Periodico.EF
{
	using System;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using Periodico.EF;
	using Periodico.DTO;

	public partial class RegistroMapper
	{
		internal static void InitializeMapper() => Mapper.Initialize(cfg =>
		{
			cfg.CreateMap<Estado, EstadoDTO>();
			cfg.CreateMap<EstadoDTO, Estado>();

			cfg.CreateMap<Autor, AutorDTO>();
			cfg.CreateMap<AutorDTO, Autor>();

			cfg.CreateMap<Noticia, NoticiaDTO>();
			cfg.CreateMap<NoticiaDTO, Noticia>();

			cfg.CreateMap<Compania, CompaniaDTO>();
			cfg.CreateMap<CompaniaDTO, Compania>();

			cfg.CreateMap<Paises, PaisesDTO>();
			cfg.CreateMap<PaisesDTO, Paises>();

			});
		}
	}
