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
    
    
    [Route("api/Documento_Aprob")]
    [ApiController()]
    public partial class Documento_AprobController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CDocumento_Aprob oDocumento_Aprob)
        {
            try
            {
                Documento_AprobFacade faDocumento_Aprob = new Documento_AprobFacade();
                bool result = faDocumento_Aprob.Grabar(oDocumento_Aprob);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faDocumento_Aprob.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Version}/{CodDocumento}/{Nivel}")]
        [HttpGet()]
        public virtual int Eliminar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            try
            {
                Documento_AprobFacade faDocumento_Aprob = new Documento_AprobFacade();
                return faDocumento_Aprob.Eliminar(Version,CodDocumento,Nivel);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Version}/{CodDocumento}/{Nivel}")]
        [HttpGet()]
        public virtual CDocumento_Aprob Recuperar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            try
            {
                Documento_AprobFacade faDocumento_Aprob = new Documento_AprobFacade();
                return faDocumento_Aprob.Recuperar(Version,CodDocumento,Nivel);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Version}/{CodDocumento}/{Nivel}")]
        [HttpGet()]
        public virtual bool Existe(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            try
            {
                Documento_AprobFacade faDocumento_Aprob = new Documento_AprobFacade();
                return faDocumento_Aprob.Existe(Version,CodDocumento,Nivel);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CDocumento_Aprob> Listar()
        {
            try
            {
                Documento_AprobFacade faDocumento_Aprob = new Documento_AprobFacade();
                return faDocumento_Aprob.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
