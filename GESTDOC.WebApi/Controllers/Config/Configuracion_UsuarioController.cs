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
    
    
    [Route("api/Configuracion_Usuario")]
    [ApiController()]
    public partial class Configuracion_UsuarioController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            try
            {
                Configuracion_UsuarioFacade faConfiguracion_Usuario = new Configuracion_UsuarioFacade();
                bool result = faConfiguracion_Usuario.Grabar(oConfiguracion_Usuario);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faConfiguracion_Usuario.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Usuario}/{Nombre_Variable}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Usuario, String Nombre_Variable)
        {
            try
            {
                Configuracion_UsuarioFacade faConfiguracion_Usuario = new Configuracion_UsuarioFacade();
                return faConfiguracion_Usuario.Eliminar(Cod_Usuario,Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Usuario}/{Nombre_Variable}")]
        [HttpGet()]
        public virtual CConfiguracion_Usuario Recuperar(String Cod_Usuario, String Nombre_Variable)
        {
            try
            {
                Configuracion_UsuarioFacade faConfiguracion_Usuario = new Configuracion_UsuarioFacade();
                return faConfiguracion_Usuario.Recuperar(Cod_Usuario,Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Usuario}/{Nombre_Variable}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Usuario, String Nombre_Variable)
        {
            try
            {
                Configuracion_UsuarioFacade faConfiguracion_Usuario = new Configuracion_UsuarioFacade();
                return faConfiguracion_Usuario.Existe(Cod_Usuario,Nombre_Variable);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CConfiguracion_Usuario> Listar()
        {
            try
            {
                Configuracion_UsuarioFacade faConfiguracion_Usuario = new Configuracion_UsuarioFacade();
                return faConfiguracion_Usuario.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
