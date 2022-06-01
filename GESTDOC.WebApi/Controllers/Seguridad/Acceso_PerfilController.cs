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
    
    
    [Route("api/Acceso_Perfil")]
    [ApiController()]
    public partial class Acceso_PerfilController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAcceso_Perfil oAcceso_Perfil)
        {
            try
            {
                Acceso_PerfilFacade faAcceso_Perfil = new Acceso_PerfilFacade();
                bool result = faAcceso_Perfil.Grabar(oAcceso_Perfil);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAcceso_Perfil.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Acceso}/{Cod_Perfil}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Acceso, String Cod_Perfil)
        {
            try
            {
                Acceso_PerfilFacade faAcceso_Perfil = new Acceso_PerfilFacade();
                return faAcceso_Perfil.Eliminar(Cod_Acceso,Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Acceso}/{Cod_Perfil}")]
        [HttpGet()]
        public virtual CAcceso_Perfil Recuperar(String Cod_Acceso, String Cod_Perfil)
        {
            try
            {
                Acceso_PerfilFacade faAcceso_Perfil = new Acceso_PerfilFacade();
                return faAcceso_Perfil.Recuperar(Cod_Acceso,Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Acceso}/{Cod_Perfil}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Acceso, String Cod_Perfil)
        {
            try
            {
                Acceso_PerfilFacade faAcceso_Perfil = new Acceso_PerfilFacade();
                return faAcceso_Perfil.Existe(Cod_Acceso,Cod_Perfil);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CAcceso_Perfil> Listar()
        {
            try
            {
                Acceso_PerfilFacade faAcceso_Perfil = new Acceso_PerfilFacade();
                return faAcceso_Perfil.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
