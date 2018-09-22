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
	public class InformacionCompania : RepositorioGenerico<ModelEF, Compania>, IInformacionCompania
	{
		ModelEF modelEF = new ModelEF();

		public InformacionCompania()
		{
			base.Context = modelEF;
		}

		public InformacionCompania(ModelEF modelo) : base(modelo)
		{
		}


		public async Task<bool> CreateCompaniaDto(DTO.CompaniaDTO companiaDto)
		{
			await Crear<DTO.CompaniaDTO>(companiaDto, false);
			modelEF.SaveChanges();
			modelEF.Compania.Local.FirstOrDefault();
			return true;
		}

		public async Task<bool> UpdateCompaniaDto(DTO.CompaniaDTO companiaDto)
		{
			await Editar<DTO.CompaniaDTO>(companiaDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<bool> DeleteCompaniaDto(DTO.CompaniaDTO companiaDto)
		{
			await Eliminar<DTO.CompaniaDTO>(companiaDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<DTO.CompaniaDTO> GetBy_CompaniaDto(long Codigo)
		{
			DTO.CompaniaDTO compania = ObtenerEntidadPorCondicion<DTO.CompaniaDTO>(t => t.Codigo == Codigo);
			return await Task.FromResult(compania);
		}

		public async Task<List<DTO.CompaniaDTO>> GetBy_CompaniaAll()
		{
			List<DTO.CompaniaDTO> companiaList = ObtenerTodos<DTO.CompaniaDTO>().ToList();
			return await Task.FromResult(companiaList.ToList());
		}

		/// <summary>
		/// Gets all records from Compania that are related to Estado
		/// </summary>
		public async Task<List<DTO.CompaniaDTO>> GetByEstado(int EstadoCodigo)
		{
			List<DTO.CompaniaDTO> companiaList = ObtenerTodosPorCondicion<DTO.CompaniaDTO>(t => t.EstadoCodigo == EstadoCodigo).ToList();
			return await Task.FromResult(companiaList.ToList());
		}

		/// <summary>
		/// Gets all records from Compania that are related to Paises
		/// </summary>
		public async Task<List<DTO.CompaniaDTO>> GetByPaises(int PaisesCosifo)
		{
			List<DTO.CompaniaDTO> companiaList = ObtenerTodosPorCondicion<DTO.CompaniaDTO>(t => t.PaisesCosifo == PaisesCosifo).ToList();
			return await Task.FromResult(companiaList.ToList());
		}

	}
}
