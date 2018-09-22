namespace Periodico.Business
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Periodico.Business.Model;
	using Periodico.DTO;

    public interface IInformacionPaisesBusiness
    {

		Task<OperationResult<bool>> CreatePaisesDto(DTO.PaisesDTO PaisesDTO);
	
		Task<OperationResult<bool>> UpdatePaisesDto(DTO.PaisesDTO PaisesDTO);
	
		Task<OperationResult<bool>> DeletePaisesDto(DTO.PaisesDTO PaisesDTO);
	
		Task<OperationResult<DTO.PaisesDTO>> GetBy_PaisesDto(int Codigo);		
	
		Task<OperationResult<List<DTO.PaisesDTO>>> GetBy_PaisesAll();
	
		
    }
}
