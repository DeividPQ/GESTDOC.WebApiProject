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
    
    
    [Route("api/Tipo_Documento")]
    [ApiController()]
    public partial class Tipo_DocumentoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CTipo_Documento oTipo_Documento)
        {
            try
            {
                Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
                bool result = faTipo_Documento.Grabar(oTipo_Documento);
                if (!result)
                {
                return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faTipo_Documento.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{Cod_Tipo}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Tipo)
        {
            try
            {
                Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
                return faTipo_Documento.Eliminar(Cod_Tipo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{Cod_Tipo}")]
        [HttpGet()]
        public virtual CTipo_Documento Recuperar(String Cod_Tipo)
        {
            try
            {
                Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
                return faTipo_Documento.Recuperar(Cod_Tipo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{Cod_Tipo}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Tipo)
        {
            try
            {
                Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
                return faTipo_Documento.Existe(Cod_Tipo);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CTipo_Documento> Listar()
        {
            try
            {
                Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
                return faTipo_Documento.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
