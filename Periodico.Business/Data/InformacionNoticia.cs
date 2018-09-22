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

	public class InformacionNoticiaBusiness : IInformacionNoticiaBusiness
    {
		public EF.IInformacionNoticia informacionNoticia { get; set; }

		public InformacionNoticiaBusiness()
		{
			informacionNoticia = new EF.InformacionNoticia();
		}

        public async Task<OperationResult<bool>> CreateNoticiaDto(DTO.NoticiaDTO Noticia)
        {
            try
            {
                var resultado = await informacionNoticia.CreateNoticiaDto(Noticia);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> UpdateNoticiaDto(DTO.NoticiaDTO Noticia)
        {
            try
            {
                var resultado = await informacionNoticia.UpdateNoticiaDto(Noticia);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }

        public async Task<OperationResult<bool>> DeleteNoticiaDto(DTO.NoticiaDTO Noticia)
        {
            try
            {
                var resultado = await informacionNoticia.DeleteNoticiaDto(Noticia);

                return OperationResult<bool>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<bool>.ErrorResponse(ex);
            }

        }
        
        public async Task<OperationResult<DTO.NoticiaDTO>> GetBy_NoticiaDto(int Codigo)
        {
            try
            {
                var resultado = await informacionNoticia.GetBy_NoticiaDto(Codigo);

                return OperationResult<DTO.NoticiaDTO>.SuccessResponse(resultado);

            }
            catch (System.Exception ex)
            {
                return OperationResult<DTO.NoticiaDTO>.ErrorResponse(ex);
            }

        }
		
		public async Task<OperationResult<List<DTO.NoticiaDTO>>> GetBy_NoticiaAll()
        {
			try
            {
				var resultado = await informacionNoticia.GetBy_NoticiaAll();
				return OperationResult<List<DTO.NoticiaDTO>>.SuccessResponse(resultado);
			}
            catch (System.Exception ex)
            {
                return OperationResult<List<DTO.NoticiaDTO>>.ErrorResponse(ex);
            }
        }
		
		         /// <summary>
         /// Gets all records from Noticia that are related to Autor
         /// </summary>
         public async Task<OperationResult<List<DTO.NoticiaDTO>>> GetByAutor(long AutorCodigo)
         {
             try
             {
                 var resultado = await informacionNoticia.GetByAutor(AutorCodigo);
                 return OperationResult<List<DTO.NoticiaDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.NoticiaDTO>>.ErrorResponse(ex);
             }
         }

         /// <summary>
         /// Gets all records from Noticia that are related to Estado
         /// </summary>
         public async Task<OperationResult<List<DTO.NoticiaDTO>>> GetByEstado(int EstadoCodigo)
         {
             try
             {
                 var resultado = await informacionNoticia.GetByEstado(EstadoCodigo);
                 return OperationResult<List<DTO.NoticiaDTO>>.SuccessResponse(resultado);
             }
             catch (System.Exception ex)
             {
                 return OperationResult<List<DTO.NoticiaDTO>>.ErrorResponse(ex);
             }
         }


    }
}
