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
    
    
    [Route("api/Usuario")]
    [ApiController()]
    public partial class UsuarioController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CUsuario oUsuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                bool result = faUsuario.Grabar(oUsuario);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faUsuario.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Usuario}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Usuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Eliminar(Cod_Usuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Usuario}")]
        [HttpGet()]
        public virtual CUsuario Recuperar(String Cod_Usuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Recuperar(Cod_Usuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Usuario}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Usuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Existe(Cod_Usuario.ToLower());
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("isOk/{Cod_Usuario}")]
        [HttpGet()]
        public virtual bool isOk(String Cod_Usuario)
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Existe(Cod_Usuario);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CUsuario> Listar()
        {
            try
            {
                UsuarioFacade faUsuario = new UsuarioFacade();
                return faUsuario.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
