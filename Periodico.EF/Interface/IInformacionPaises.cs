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
	public interface IInformacionPaises : IRepositorioGenerico<DTO.PaisesDTO>
	{

		Task<bool> CreatePaisesDto(DTO.PaisesDTO paisesDto);

		Task<bool> UpdatePaisesDto(DTO.PaisesDTO paisesDto);

		Task<bool> DeletePaisesDto(DTO.PaisesDTO paisesDto);

		Task<DTO.PaisesDTO> GetBy_PaisesDto(int Codigo);

		Task<List<DTO.PaisesDTO>> GetBy_PaisesAll();
	}
}
