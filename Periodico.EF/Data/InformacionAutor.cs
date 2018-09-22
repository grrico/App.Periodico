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
	public class InformacionAutor : RepositorioGenerico<ModelEF, Autor>, IInformacionAutor
	{
		ModelEF modelEF = new ModelEF();

		public InformacionAutor()
		{
			base.Context = modelEF;
		}

		public InformacionAutor(ModelEF modelo) : base(modelo)
		{
		}


		public async Task<bool> CreateAutorDto(DTO.AutorDTO autorDto)
		{
			await Crear<DTO.AutorDTO>(autorDto, false);
			modelEF.SaveChanges();
			modelEF.Autor.Local.FirstOrDefault();
			return true;
		}

		public async Task<bool> UpdateAutorDto(DTO.AutorDTO autorDto)
		{
			await Editar<DTO.AutorDTO>(autorDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<bool> DeleteAutorDto(DTO.AutorDTO autorDto)
		{
			await Eliminar<DTO.AutorDTO>(autorDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<DTO.AutorDTO> GetBy_AutorDto(long Codigo)
		{
			DTO.AutorDTO autor = ObtenerEntidadPorCondicion<DTO.AutorDTO>(t => t.Codigo == Codigo);
			return await Task.FromResult(autor);
		}

		public async Task<List<DTO.AutorDTO>> GetBy_AutorAll()
		{
			List<DTO.AutorDTO> autorList = ObtenerTodos<DTO.AutorDTO>().ToList();
			return await Task.FromResult(autorList.ToList());
		}

		/// <summary>
		/// Gets all records from Autor that are related to Compania
		/// </summary>
		public async Task<List<DTO.AutorDTO>> GetByCompania(long CompaniaCodigo)
		{
			List<DTO.AutorDTO> autorList = ObtenerTodosPorCondicion<DTO.AutorDTO>(t => t.CompaniaCodigo == CompaniaCodigo).ToList();
			return await Task.FromResult(autorList.ToList());
		}

		/// <summary>
		/// Gets all records from Autor that are related to Estado
		/// </summary>
		public async Task<List<DTO.AutorDTO>> GetByEstado(int EstadoCodigo)
		{
			List<DTO.AutorDTO> autorList = ObtenerTodosPorCondicion<DTO.AutorDTO>(t => t.EstadoCodigo == EstadoCodigo).ToList();
			return await Task.FromResult(autorList.ToList());
		}

	}
}
