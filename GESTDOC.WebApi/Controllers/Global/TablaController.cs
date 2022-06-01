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
    
    
    [Route("api/Tabla")]
    [ApiController()]
    public partial class TablaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CTabla oTabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                bool result = faTabla.Grabar(oTabla);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faTabla.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Tabla}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Tabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Eliminar(Cod_Tabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Tabla}")]
        [HttpGet()]
        public virtual CTabla Recuperar(String Cod_Tabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Recuperar(Cod_Tabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Tabla}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Tabla)
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Existe(Cod_Tabla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CTabla> Listar()
        {
            try
            {
                TablaFacade faTabla = new TablaFacade();
                return faTabla.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
