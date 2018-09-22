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
	public class InformacionEstado : RepositorioGenerico<ModelEF, Estado>, IInformacionEstado
	{
		ModelEF modelEF = new ModelEF();

		public InformacionEstado()
		{
			base.Context = modelEF;
		}

		public InformacionEstado(ModelEF modelo) : base(modelo)
		{
		}


		public async Task<bool> CreateEstadoDto(DTO.EstadoDTO estadoDto)
		{
			await Crear<DTO.EstadoDTO>(estadoDto, false);
			modelEF.SaveChanges();
			modelEF.Estado.Local.FirstOrDefault();
			return true;
		}

		public async Task<bool> UpdateEstadoDto(DTO.EstadoDTO estadoDto)
		{
			await Editar<DTO.EstadoDTO>(estadoDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<bool> DeleteEstadoDto(DTO.EstadoDTO estadoDto)
		{
			await Eliminar<DTO.EstadoDTO>(estadoDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<DTO.EstadoDTO> GetBy_EstadoDto(int Codigo)
		{
			DTO.EstadoDTO estado = ObtenerEntidadPorCondicion<DTO.EstadoDTO>(t => t.Codigo == Codigo);
			return await Task.FromResult(estado);
		}

		public async Task<List<DTO.EstadoDTO>> GetBy_EstadoAll()
		{
			List<DTO.EstadoDTO> estadoList = ObtenerTodos<DTO.EstadoDTO>().ToList();
			return await Task.FromResult(estadoList.ToList());
		}

	}
}
