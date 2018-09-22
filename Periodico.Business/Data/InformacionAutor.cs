namespace Periodico.Business
{
	using System;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Data.Entity.Spatial;
	using System.Collections.Generic;
	using AutoMapper;
	using Periodico.EF;
	using Periodico.DTO;
	using Periodico.Business.Model;

	public class InformacionAutorBusiness : IInformacionAutorBusiness
    {
		public EF.IInformacionAutor informacionAutor { get; set; }

		public InformacionAutorBusiness()
		{
			informacionAutor = new EF.InformacionAutor();
		}

        public async Task<OperationResult<bool>> CreateAutorDto(DTO.AutorDTO Autor)
        {
            try
            {
                var resultado = await informacionAutor.CreateAutorDto(Autor);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> UpdateAutorDto(DTO.AutorDTO Autor)
        {
            try
            {
                var resultado = await informacionAutor.UpdateAutorDto(Autor);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> DeleteAutorDto(DTO.AutorDTO Autor)
        {
            try
            {
                var resultado = await informacionAutor.DeleteAutorDto(Autor);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }
        
        public async Task<OperationResult<DTO.AutorDTO>> GetBy_AutorDto(long Codigo)
        {
            try
            {
                var resultado = await informacionAutor.GetBy_AutorDto(Codigo);

                return OperationResult<DTO.AutorDTO>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<DTO.AutorDTO>.ErrorResponse(ex);
            }

        }
		
		public async Task<OperationResult<List<DTO.AutorDTO>>> GetBy_AutorAll()
        {
			try
            {
				var resultado = await informacionAutor.GetBy_AutorAll();
				return OperationResult<List<DTO.AutorDTO>>.SuccessResponse(resultado);
			}
            catch (System.Exception ex)
            {
                return OperationResult<List<DTO.AutorDTO>>.ErrorResponse(ex);
            }
        }
		
		         /// <summary>
         /// Gets all records from Autor that are related to Compania
         /// </summary>
         public async Task<OperationResult<List<DTO.AutorDTO>>> GetByCompania(long CompaniaCodigo)
         {
             try
             {
                 var resultado = await informacionAutor.GetByCompania(CompaniaCodigo);
                 return OperationResult<List<DTO.AutorDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.AutorDTO>>.ErrorResponse(ex);
             }
         }

         /// <summary>
         /// Gets all records from Autor that are related to Estado
         /// </summary>
         public async Task<OperationResult<List<DTO.AutorDTO>>> GetByEstado(int EstadoCodigo)
         {
             try
             {
                 var resultado = await informacionAutor.GetByEstado(EstadoCodigo);
                 return OperationResult<List<DTO.AutorDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.AutorDTO>>.ErrorResponse(ex);
             }
         }


    }
}
