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
    
    
    [Route("api/Perfil")]
    [ApiController()]
    public partial class PerfilController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CPerfil oPerfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                bool result = faPerfil.Grabar(oPerfil);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPerfil.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Perfil}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Perfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Eliminar(Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Perfil}")]
        [HttpGet()]
        public virtual CPerfil Recuperar(String Cod_Perfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Recuperar(Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Perfil}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Perfil)
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Existe(Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CPerfil> Listar()
        {
            try
            {
                PerfilFacade faPerfil = new PerfilFacade();
                return faPerfil.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
