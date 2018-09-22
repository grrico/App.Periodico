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
	public class InformacionPaises : RepositorioGenerico<ModelEF, Paises>, IInformacionPaises
	{
		ModelEF modelEF = new ModelEF();

		public InformacionPaises()
		{
			base.Context = modelEF;
		}

		public InformacionPaises(ModelEF modelo) : base(modelo)
		{
		}


		public async Task<bool> CreatePaisesDto(DTO.PaisesDTO paisesDto)
		{
			await Crear<DTO.PaisesDTO>(paisesDto, false);
			modelEF.SaveChanges();
			modelEF.Paises.Local.FirstOrDefault();
			return true;
		}

		public async Task<bool> UpdatePaisesDto(DTO.PaisesDTO paisesDto)
		{
			await Editar<DTO.PaisesDTO>(paisesDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<bool> DeletePaisesDto(DTO.PaisesDTO paisesDto)
		{
			await Eliminar<DTO.PaisesDTO>(paisesDto, false);
			modelEF.SaveChanges();
			return true;
		}

		public async Task<DTO.PaisesDTO> GetBy_PaisesDto(int Codigo)
		{
			DTO.PaisesDTO paises = ObtenerEntidadPorCondicion<DTO.PaisesDTO>(t => t.Codigo == Codigo);
			return await Task.FromResult(paises);
		}

		public async Task<List<DTO.PaisesDTO>> GetBy_PaisesAll()
		{
			List<DTO.PaisesDTO> paisesList = ObtenerTodos<DTO.PaisesDTO>().ToList();
			return await Task.FromResult(paisesList.ToList());
		}

	}
}
