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
using GESTDOC.BusinessObjects.Seguridad;
using GESTDOC.FacadeNet.Seguridad;

namespace GESTDOC.WebApi.Controllers.Seguridad
{
    
    
    [Route("api/Acceso")]
    [ApiController()]
    public partial class AccesoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAcceso oAcceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                bool result = faAcceso.Grabar(oAcceso);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAcceso.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Acceso}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Eliminar(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Acceso}")]
        [HttpGet()]
        public virtual CAcceso Recuperar(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Recuperar(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Acceso}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Acceso)
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Existe(Cod_Acceso);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CAcceso> Listar()
        {
            try
            {
                AccesoFacade faAcceso = new AccesoFacade();
                return faAcceso.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
