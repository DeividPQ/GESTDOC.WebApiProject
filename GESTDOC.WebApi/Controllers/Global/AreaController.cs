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
    
    
    [Route("api/Area")]
    [ApiController()]
    public partial class AreaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CArea oArea)
        {
            try
            {
                AreaFacade faArea = new AreaFacade();
                bool result = faArea.Grabar(oArea);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faArea.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodArea}")]
        [HttpGet()]
        public virtual int Eliminar(String CodArea)
        {
            try
            {
                AreaFacade faArea = new AreaFacade();
                return faArea.Eliminar(CodArea);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodArea}")]
        [HttpGet()]
        public virtual CArea Recuperar(String CodArea)
        {
            try
            {
                AreaFacade faArea = new AreaFacade();
                return faArea.Recuperar(CodArea);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodArea}")]
        [HttpGet()]
        public virtual bool Existe(String CodArea)
        {
            try
            {
                AreaFacade faArea = new AreaFacade();
                return faArea.Existe(CodArea);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CArea> Listar()
        {
            try
            {
                AreaFacade faArea = new AreaFacade();
                return faArea.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
