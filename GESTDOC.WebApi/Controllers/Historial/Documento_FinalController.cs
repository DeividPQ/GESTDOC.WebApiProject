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
using GESTDOC.BusinessObjects.Historial;
using GESTDOC.FacadeNet.Historial;

namespace GESTDOC.WebApi.Controllers.Historial
{
    
    
    [Route("api/Documento_Final")]
    [ApiController()]
    public partial class Documento_FinalController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CDocumento_Final oDocumento_Final)
        {
            try
            {
                Documento_FinalFacade faDocumento_Final = new Documento_FinalFacade();
                bool result = faDocumento_Final.Grabar(oDocumento_Final);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faDocumento_Final.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{IDDoc_Final}")]
        [HttpGet()]
        public virtual int Eliminar(Int32 IDDoc_Final)
        {
            try
            {
                Documento_FinalFacade faDocumento_Final = new Documento_FinalFacade();
                return faDocumento_Final.Eliminar(IDDoc_Final);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{IDDoc_Final}")]
        [HttpGet()]
        public virtual CDocumento_Final Recuperar(Int32 IDDoc_Final)
        {
            try
            {
                Documento_FinalFacade faDocumento_Final = new Documento_FinalFacade();
                return faDocumento_Final.Recuperar(IDDoc_Final);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{IDDoc_Final}")]
        [HttpGet()]
        public virtual bool Existe(Int32 IDDoc_Final)
        {
            try
            {
                Documento_FinalFacade faDocumento_Final = new Documento_FinalFacade();
                return faDocumento_Final.Existe(IDDoc_Final);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CDocumento_Final> Listar()
        {
            try
            {
                Documento_FinalFacade faDocumento_Final = new Documento_FinalFacade();
                return faDocumento_Final.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
