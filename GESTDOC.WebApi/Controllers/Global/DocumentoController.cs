//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 17 de mayo de 2022
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.FacadeNet.Global;

namespace GESTDOC.WebApi.Controllers.Global
{
    
    
    [Route("api/Documento")]
    [ApiController()]
    public partial class DocumentoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CDocumento oDocumento)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                bool result = faDocumento.Grabar(oDocumento);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faDocumento.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual int Eliminar(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Eliminar(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual CDocumento Recuperar(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Recuperar(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual bool Existe(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Existe(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CDocumento> Listar()
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
