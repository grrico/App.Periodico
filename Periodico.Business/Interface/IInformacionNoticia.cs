namespace Periodico.Business
{
	
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Periodico.Business.Model;
	using Periodico.DTO;

    public interface IInformacionNoticiaBusiness
    {

		Task<OperationResult<bool>> CreateNoticiaDto(DTO.NoticiaDTO NoticiaDTO);
	
		Task<OperationResult<bool>> UpdateNoticiaDto(DTO.NoticiaDTO NoticiaDTO);
	
		Task<OperationResult<bool>> DeleteNoticiaDto(DTO.NoticiaDTO NoticiaDTO);
	
		Task<OperationResult<DTO.NoticiaDTO>> GetBy_NoticiaDto(int Codigo);		
	
		Task<OperationResult<List<DTO.NoticiaDTO>>> GetBy_NoticiaAll();
	
		     Task<OperationResult<List<DTO.NoticiaDTO>>> GetByAutor(long AutorCodigo);

     Task<OperationResult<List<DTO.NoticiaDTO>>> GetByEstado(int EstadoCodigo);


    }
}
