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

	public class InformacionEstadoBusiness : IInformacionEstadoBusiness
    {
		public EF.IInformacionEstado informacionEstado { get; set; }

		public InformacionEstadoBusiness()
		{
			informacionEstado = new EF.InformacionEstado();
		}

        public async Task<OperationResult<bool>> CreateEstadoDto(DTO.EstadoDTO Estado)
        {
            try
            {
                var resultado = await informacionEstado.CreateEstadoDto(Estado);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> UpdateEstadoDto(DTO.EstadoDTO Estado)
        {
            try
            {
                var resultado = await informacionEstado.UpdateEstadoDto(Estado);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> DeleteEstadoDto(DTO.EstadoDTO Estado)
        {
            try
            {
                var resultado = await informacionEstado.DeleteEstadoDto(Estado);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }
        
        public async Task<OperationResult<DTO.EstadoDTO>> GetBy_EstadoDto(int Codigo)
        {
            try
            {
                var resultado = await informacionEstado.GetBy_EstadoDto(Codigo);

                return OperationResult<DTO.EstadoDTO>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<DTO.EstadoDTO>.ErrorResponse(ex);
            }

        }
		
		public async Task<OperationResult<List<DTO.EstadoDTO>>> GetBy_EstadoAll()
        {
			try
            {
				var resultado = await informacionEstado.GetBy_EstadoAll();
				return OperationResult<List<DTO.EstadoDTO>>.SuccessResponse(resultado);
			}
            catch (System.Exception ex)
            {
                return OperationResult<List<DTO.EstadoDTO>>.ErrorResponse(ex);
            }
        }
		
		
    }
}
