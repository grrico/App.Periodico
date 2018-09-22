using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Spatial;
using System.Collections.Generic;
using AutoMapper;
using Periodico.DTO;
using Entidad.Datos.Interfaces;

namespace Periodico.EF
{
	public interface IInformacionCompania : IRepositorioGenerico<DTO.CompaniaDTO>
	{

		Task<bool> CreateCompaniaDto(DTO.CompaniaDTO companiaDto);

		Task<bool> UpdateCompaniaDto(DTO.CompaniaDTO companiaDto);

		Task<bool> DeleteCompaniaDto(DTO.CompaniaDTO companiaDto);

		Task<DTO.CompaniaDTO> GetBy_CompaniaDto(long Codigo);

		Task<List<DTO.CompaniaDTO>> GetBy_CompaniaAll();

		/// <summary>
		/// Gets all records from Compania that are related to Estado
		/// </summary>
		Task<List<DTO.CompaniaDTO>> GetByEstado(int EstadoCodigo);

		/// <summary>
		/// Gets all records from Compania that are related to Paises
		/// </summary>
		Task<List<DTO.CompaniaDTO>> GetByPaises(int PaisesCosifo);
	}
}
