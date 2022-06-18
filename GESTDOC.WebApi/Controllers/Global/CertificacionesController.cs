using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.FacadeNet.Global;

namespace GESTDOC.WebApi.Controllers.Global
{

    [Route("api/Certificaciones")]
    [ApiController()]
    public class CertificacionesController : ControllerBase
    {

        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CCertificaciones oCertificaciones)
        {
            try
            {
                CertificacionesFacade faCertificaciones = new CertificacionesFacade();
                bool result = faCertificaciones.Grabar(oCertificaciones);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faCertificaciones.getError() }));
                }
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Eliminar/{Cod_Certificacion}")]
        [HttpGet()]
        public virtual int Eliminar(String Cod_Certificacion)
        {
            try
            {
                CertificacionesFacade faCertificaciones = new CertificacionesFacade();
                return faCertificaciones.Eliminar(Cod_Certificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Recuperar/{Cod_Certificacion}")]
        [HttpGet()]
        public virtual CCertificaciones Recuperar(String Cod_Certificacion)
        {
            try
            {
                CertificacionesFacade faCertificaciones = new CertificacionesFacade();
                return faCertificaciones.Recuperar(Cod_Certificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Existe/{Cod_Certificacion}")]
        [HttpGet()]
        public virtual bool Existe(String Cod_Certificacion)
        {
            try
            {
                CertificacionesFacade faCertificaciones = new CertificacionesFacade();
                return faCertificaciones.Existe(Cod_Certificacion);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CCertificaciones> Listar()
        {
            try
            {
                CertificacionesFacade faCertificaciones = new CertificacionesFacade();
                return faCertificaciones.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
