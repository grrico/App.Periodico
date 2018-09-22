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
	public interface IInformacionEstado : IRepositorioGenerico<DTO.EstadoDTO>
	{

		Task<bool> CreateEstadoDto(DTO.EstadoDTO estadoDto);

		Task<bool> UpdateEstadoDto(DTO.EstadoDTO estadoDto);

		Task<bool> DeleteEstadoDto(DTO.EstadoDTO estadoDto);

		Task<DTO.EstadoDTO> GetBy_EstadoDto(int Codigo);

		Task<List<DTO.EstadoDTO>> GetBy_EstadoAll();
	}
}
