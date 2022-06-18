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
    
    
    [Route("api/Aprobador_Area")]
    [ApiController()]
    public partial class Aprobador_AreaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CAprobador_Area oAprobador_Area)
        {
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                bool result = faAprobador_Area.Grabar(oAprobador_Area);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faAprobador_Area.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodArea}/{Nivel}/{CodAprobador}")]
        [HttpGet()]
        public virtual int Eliminar(String CodArea, String Cod_Tipo, Int16 Nivel, String CodAprobador)
        {
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                return faAprobador_Area.Eliminar(CodArea, Cod_Tipo, Nivel,CodAprobador);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodArea}/{Nivel}/{CodAprobador}")]
        [HttpGet()]
        public virtual CAprobador_Area Recuperar(String CodArea, String Cod_Tipo, Int16 Nivel, String CodAprobador)
        {
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                return faAprobador_Area.Recuperar(CodArea,Cod_Tipo,Nivel,CodAprobador);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodArea}/{Nivel}/{CodAprobador}")]
        [HttpGet()]
        public virtual bool Existe(String CodArea, String Cod_Tipo, Int16 Nivel, String CodAprobador)
        {
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                return faAprobador_Area.Existe(CodArea,Cod_Tipo,Nivel,CodAprobador);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CAprobador_Area> Listar()
        {
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                return faAprobador_Area.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("PersonaArea_Lista/{CodArea}")]
        [HttpGet()]
        public virtual IList<CAprobador_X_Area> PersonaArea_Lista(string CodArea)
        {
            if (CodArea == "*") { CodArea = ""; }
            try
            {
                Aprobador_AreaFacade faAprobador_Area = new Aprobador_AreaFacade();
                return faAprobador_Area.PersonaArea_Lista(CodArea);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

    }
}
