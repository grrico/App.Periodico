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

	public class InformacionPaisesBusiness : IInformacionPaisesBusiness
    {
		public EF.IInformacionPaises informacionPaises { get; set; }

		public InformacionPaisesBusiness()
		{
			informacionPaises = new EF.InformacionPaises();
		}

        public async Task<OperationResult<bool>> CreatePaisesDto(DTO.PaisesDTO Paises)
        {
            try
            {
                var resultado = await informacionPaises.CreatePaisesDto(Paises);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> UpdatePaisesDto(DTO.PaisesDTO Paises)
        {
            try
            {
                var resultado = await informacionPaises.UpdatePaisesDto(Paises);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> DeletePaisesDto(DTO.PaisesDTO Paises)
        {
            try
            {
                var resultado = await informacionPaises.DeletePaisesDto(Paises);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }
        
        public async Task<OperationResult<DTO.PaisesDTO>> GetBy_PaisesDto(int Codigo)
        {
            try
            {
                var resultado = await informacionPaises.GetBy_PaisesDto(Codigo);

                return OperationResult<DTO.PaisesDTO>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<DTO.PaisesDTO>.ErrorResponse(ex);
            }

        }
		
		public async Task<OperationResult<List<DTO.PaisesDTO>>> GetBy_PaisesAll()
        {
			try
            {
				var resultado = await informacionPaises.GetBy_PaisesAll();
				return OperationResult<List<DTO.PaisesDTO>>.SuccessResponse(resultado);
			}
            catch (System.Exception ex)
            {
                return OperationResult<List<DTO.PaisesDTO>>.ErrorResponse(ex);
            }
        }
		
		
    }
}
