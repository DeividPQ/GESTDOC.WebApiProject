//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: lunes, 13 de septiembre de 2021
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LibreriaBSNetCore.Exceptions;
using Microsoft.AspNetCore.Http;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.FacadeNet.Global;
//using WebApiSupTransp.Authorization;
using GESTDOC.WebApi.Helpers;

namespace GESTDOC.WebApi.Controllers.Correo
{
    
    //[Authorize]
    [Route("api/Correo")]
    [ApiController()]
    public partial class CorreoController : ControllerBase
    {

        MailService mailservice;

        public CorreoController(MailService mailservice_)
        {
            mailservice = mailservice_;
        }

        [Route("Enviar_Correo/{Receptor}/{asunto}/{mensaje}")]
        [HttpGet()]
        public bool Enviar_Correo(string Receptor, string asunto, string mensaje)
        {
            try
            {                
                return mailservice.Enviar_Correo(Receptor, asunto, mensaje);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
    }
}
