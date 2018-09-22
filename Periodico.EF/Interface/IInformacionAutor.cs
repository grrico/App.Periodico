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
	public interface IInformacionAutor : IRepositorioGenerico<DTO.AutorDTO>
	{

		Task<bool> CreateAutorDto(DTO.AutorDTO autorDto);

		Task<bool> UpdateAutorDto(DTO.AutorDTO autorDto);

		Task<bool> DeleteAutorDto(DTO.AutorDTO autorDto);

		Task<DTO.AutorDTO> GetBy_AutorDto(long Codigo);

		Task<List<DTO.AutorDTO>> GetBy_AutorAll();

		/// <summary>
		/// Gets all records from Autor that are related to Compania
		/// </summary>
		Task<List<DTO.AutorDTO>> GetByCompania(long CompaniaCodigo);

		/// <summary>
		/// Gets all records from Autor that are related to Estado
		/// </summary>
		Task<List<DTO.AutorDTO>> GetByEstado(int EstadoCodigo);
	}
}
