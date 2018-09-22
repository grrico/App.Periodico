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

	public class InformacionCompaniaBusiness : IInformacionCompaniaBusiness
    {
		public EF.IInformacionCompania informacionCompania { get; set; }

		public InformacionCompaniaBusiness()
		{
			informacionCompania = new EF.InformacionCompania();
		}

        public async Task<OperationResult<bool>> CreateCompaniaDto(DTO.CompaniaDTO Compania)
        {
            try
            {
                var resultado = await informacionCompania.CreateCompaniaDto(Compania);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> UpdateCompaniaDto(DTO.CompaniaDTO Compania)
        {
            try
            {
                var resultado = await informacionCompania.UpdateCompaniaDto(Compania);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> DeleteCompaniaDto(DTO.CompaniaDTO Compania)
        {
            try
            {
                var resultado = await informacionCompania.DeleteCompaniaDto(Compania);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }
        
        public async Task<OperationResult<DTO.CompaniaDTO>> GetBy_CompaniaDto(long Codigo)
        {
            try
            {
                var resultado = await informacionCompania.GetBy_CompaniaDto(Codigo);

                return OperationResult<DTO.CompaniaDTO>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<DTO.CompaniaDTO>.ErrorResponse(ex);
            }

        }
		
		public async Task<OperationResult<List<DTO.CompaniaDTO>>> GetBy_CompaniaAll()
        {
			try
            {
				var resultado = await informacionCompania.GetBy_CompaniaAll();
				return OperationResult<List<DTO.CompaniaDTO>>.SuccessResponse(resultado);
			}
            catch (System.Exception ex)
            {
                return OperationResult<List<DTO.CompaniaDTO>>.ErrorResponse(ex);
            }
        }
		
		         /// <summary>
         /// Gets all records from Compania that are related to Estado
         /// </summary>
         public async Task<OperationResult<List<DTO.CompaniaDTO>>> GetByEstado(int EstadoCodigo)
         {
             try
             {
                 var resultado = await informacionCompania.GetByEstado(EstadoCodigo);
                 return OperationResult<List<DTO.CompaniaDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.CompaniaDTO>>.ErrorResponse(ex);
             }
         }

         /// <summary>
         /// Gets all records from Compania that are related to Paises
         /// </summary>
         public async Task<OperationResult<List<DTO.CompaniaDTO>>> GetByPaises(int PaisesCosifo)
         {
             try
             {
                 var resultado = await informacionCompania.GetByPaises(PaisesCosifo);
                 return OperationResult<List<DTO.CompaniaDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.CompaniaDTO>>.ErrorResponse(ex);
             }
         }


    }
}
