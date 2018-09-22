namespace Periodico.Business
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Periodico.Business.Model;
    using Periodico.DTO;

    public interface IInformacionAutorBusiness
    {

        Task<OperationResult<bool>> CreateAutorDto(DTO.AutorDTO AutorDTO);

        Task<OperationResult<bool>> UpdateAutorDto(DTO.AutorDTO AutorDTO);

        Task<OperationResult<bool>> DeleteAutorDto(DTO.AutorDTO AutorDTO);

        Task<OperationResult<DTO.AutorDTO>> GetBy_AutorDto(long Codigo);

        Task<OperationResult<List<DTO.AutorDTO>>> GetBy_AutorAll();

        Task<OperationResult<List<DTO.AutorDTO>>> GetByCompania(long CompaniaCodigo);

        Task<OperationResult<List<DTO.AutorDTO>>> GetByEstado(int EstadoCodigo);


    }
}
