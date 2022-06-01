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
using GESTDOC.BusinessObjects.Config;
using GESTDOC.FacadeNet.Config;

namespace GESTDOC.WebApi.Controllers.Config
{
    
    
    [Route("api/Configuracion_Sistema")]
    [ApiController()]
    public partial class Configuracion_SistemaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CConfiguracion_Sistema oConfiguracion_Sistema)
        {
            try
            {
                Configuracion_SistemaFacade faConfiguracion_Sistema = new Configuracion_SistemaFacade();
                bool result = faConfiguracion_Sistema.Grabar(oConfiguracion_Sistema);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faConfiguracion_Sistema.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Variable}")]
        [HttpGet()]
        public virtual int Eliminar(String Variable)
        {
            try
            {
                Configuracion_SistemaFacade faConfiguracion_Sistema = new Configuracion_SistemaFacade();
                return faConfiguracion_Sistema.Eliminar(Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Variable}")]
        [HttpGet()]
        public virtual CConfiguracion_Sistema Recuperar(String Variable)
        {
            try
            {
                Configuracion_SistemaFacade faConfiguracion_Sistema = new Configuracion_SistemaFacade();
                return faConfiguracion_Sistema.Recuperar(Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Variable}")]
        [HttpGet()]
        public virtual bool Existe(String Variable)
        {
            try
            {
                Configuracion_SistemaFacade faConfiguracion_Sistema = new Configuracion_SistemaFacade();
                return faConfiguracion_Sistema.Existe(Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CConfiguracion_Sistema> Listar()
        {
            try
            {
                Configuracion_SistemaFacade faConfiguracion_Sistema = new Configuracion_SistemaFacade();
                return faConfiguracion_Sistema.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
