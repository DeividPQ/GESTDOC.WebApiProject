using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.FacadeNet.Global;


namespace GESTDOC.WebApi.Controllers.Global
{


    [Route("api/Sistemas_Gestion")]
    [ApiController()]
    public partial class Sistemas_GestionController : Controller
    {
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar(CSistema_Gestion sistema_gestion)
        {
            try
            {
                Sistemas_GestionFacade faSistemas_Gestion = new Sistemas_GestionFacade();
                bool result = faSistemas_Gestion.Grabar(sistema_gestion);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faSistemas_Gestion.getError() }));
                }
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Eliminar/{CodSist_Gest}")]
        [HttpGet()]
        public virtual int Eliminar(String CodSist_Gest)
        {
            try
            {
                Sistemas_GestionFacade faSistemas_Gestion = new Sistemas_GestionFacade();
                return faSistemas_Gestion.Eliminar(CodSist_Gest);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Recuperar/{CodSist_Gest}")]
        [HttpGet()]
        public virtual CSistema_Gestion Recuperar(String CodSist_Gest)
        {
            try
            {
                Sistemas_GestionFacade faSistemas_Gestion = new Sistemas_GestionFacade();
                return faSistemas_Gestion.Recuperar(CodSist_Gest);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Existe/{CodSist_Gest}")]
        [HttpGet()]
        public virtual bool Existe(String CodSist_Gest)
        {
            try
            {
                Sistemas_GestionFacade faSistemas_Gestion = new Sistemas_GestionFacade();
                return faSistemas_Gestion.Existe(CodSist_Gest);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CSistema_Gestion> Listar()
        {
            try
            {
                Sistemas_GestionFacade faSistemas_Gestion = new Sistemas_GestionFacade();
                return faSistemas_Gestion.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
