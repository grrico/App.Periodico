namespace Periodico.Business
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Periodico.Business.Model;
	using Periodico.DTO;

    public interface IInformacionEstadoBusiness
    {

		Task<OperationResult<bool>> CreateEstadoDto(DTO.EstadoDTO EstadoDTO);
	
		Task<OperationResult<bool>> UpdateEstadoDto(DTO.EstadoDTO EstadoDTO);
	
		Task<OperationResult<bool>> DeleteEstadoDto(DTO.EstadoDTO EstadoDTO);
	
		Task<OperationResult<DTO.EstadoDTO>> GetBy_EstadoDto(int Codigo);		
	
		Task<OperationResult<List<DTO.EstadoDTO>>> GetBy_EstadoAll();
	
		
    }
}
