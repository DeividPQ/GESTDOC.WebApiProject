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
    
    
    [Route("api/Persona")]
    [ApiController()]
    public partial class PersonaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CPersona oPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                bool result = faPersona.Grabar(oPersona);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPersona.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodPersona}")]
        [HttpGet()]
        public virtual int Eliminar(String CodPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Eliminar(CodPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodPersona}")]
        [HttpGet()]
        public virtual CPersona Recuperar(String CodPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Recuperar(CodPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodPersona}")]
        [HttpGet()]
        public virtual bool Existe(String CodPersona)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Existe(CodPersona);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CPersona> Listar()
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
