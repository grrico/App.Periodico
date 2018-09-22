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
	public interface IInformacionNoticia : IRepositorioGenerico<DTO.NoticiaDTO>
	{

		Task<bool> CreateNoticiaDto(DTO.NoticiaDTO noticiaDto);

		Task<bool> UpdateNoticiaDto(DTO.NoticiaDTO noticiaDto);

		Task<bool> DeleteNoticiaDto(DTO.NoticiaDTO noticiaDto);

		Task<DTO.NoticiaDTO> GetBy_NoticiaDto(int Codigo);

		Task<List<DTO.NoticiaDTO>> GetBy_NoticiaAll();

		/// <summary>
		/// Gets all records from Noticia that are related to Autor
		/// </summary>
		Task<List<DTO.NoticiaDTO>> GetByAutor(long AutorCodigo);

		/// <summary>
		/// Gets all records from Noticia that are related to Estado
		/// </summary>
		Task<List<DTO.NoticiaDTO>> GetByEstado(int EstadoCodigo);
	}
}
