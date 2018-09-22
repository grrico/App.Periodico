using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.Collections.Generic;
using AutoMapper;
using Periodico.DTO;
using Entidad.Datos.Interfaces;
using Entidad.Datos;

namespace Periodico.EF
{
	public class InformacionNoticia : RepositorioGenerico<ModelEF, Noticia>, IInformacionNoticia
	{
		ModelEF modelEF = new ModelEF();

		public InformacionNoticia()
		{
			base.Context = modelEF;
		}

		public InformacionNoticia(ModelEF modelo) : base(modelo)
		{
		}


		public async Task<bool> CreateNoticiaDto(DTO.NoticiaDTO noticiaDto)
		{
			await Crear<DTO.NoticiaDTO>(noticiaDto, false);
			modelEF.SaveChanges();
			modelEF.Noticia.Local.FirstOrDefault();
			return true;
		}

		public async Task<bool> UpdateNoticiaDto(DTO.NoticiaDTO noticiaDto)
		{
			await Editar<DTO.NoticiaDTO>(noticiaDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<bool> DeleteNoticiaDto(DTO.NoticiaDTO noticiaDto)
		{
			await Eliminar<DTO.NoticiaDTO>(noticiaDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<DTO.NoticiaDTO> GetBy_NoticiaDto(int Codigo)
		{
			DTO.NoticiaDTO noticia = ObtenerEntidadPorCondicion<DTO.NoticiaDTO>(t => t.Codigo == Codigo);
			return await Task.FromResult(noticia);
		}

		public async Task<List<DTO.NoticiaDTO>> GetBy_NoticiaAll()
		{
			List<DTO.NoticiaDTO> noticiaList = ObtenerTodos<DTO.NoticiaDTO>().ToList();
			return await Task.FromResult(noticiaList.ToList());
		}

		/// <summary>
		/// Gets all records from Noticia that are related to Autor
		/// </summary>
		public async Task<List<DTO.NoticiaDTO>> GetByAutor(long AutorCodigo)
		{
			List<DTO.NoticiaDTO> noticiaList = ObtenerTodosPorCondicion<DTO.NoticiaDTO>(t => t.AutorCodigo == AutorCodigo).ToList();
			return await Task.FromResult(noticiaList.ToList());
		}

		/// <summary>
		/// Gets all records from Noticia that are related to Estado
		/// </summary>
		public async Task<List<DTO.NoticiaDTO>> GetByEstado(int EstadoCodigo)
		{
			List<DTO.NoticiaDTO> noticiaList = ObtenerTodosPorCondicion<DTO.NoticiaDTO>(t => t.EstadoCodigo == EstadoCodigo).ToList();
			return await Task.FromResult(noticiaList.ToList());
		}

	}
}
