namespace Periodico.Business
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Periodico.Business.Model;
	using Periodico.DTO;

    public interface IInformacionCompaniaBusiness
    {

		Task<OperationResult<bool>> CreateCompaniaDto(DTO.CompaniaDTO CompaniaDTO);
	
		Task<OperationResult<bool>> UpdateCompaniaDto(DTO.CompaniaDTO CompaniaDTO);
	
		Task<OperationResult<bool>> DeleteCompaniaDto(DTO.CompaniaDTO CompaniaDTO);
	
		Task<OperationResult<DTO.CompaniaDTO>> GetBy_CompaniaDto(long Codigo);		
	
		Task<OperationResult<List<DTO.CompaniaDTO>>> GetBy_CompaniaAll();
	
		     Task<OperationResult<List<DTO.CompaniaDTO>>> GetByEstado(int EstadoCodigo);

     Task<OperationResult<List<DTO.CompaniaDTO>>> GetByPaises(int PaisesCosifo);


    }
}
