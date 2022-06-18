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
        [Route("Lista_X_Area/{CodArea}")]
        [HttpGet()]
        public virtual IList<CPersona> Lista_X_Area(string CodArea)
        {
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.Lista_X_Area(CodArea);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("PersonaBuscar/{CodPersona}/{Nombres}/{Apellido_Paterno}/{Apellido_Materno}/{CodArea}/{Nom_Area}/{Nivel}")]
        [HttpGet()]
        public virtual IList<CPersonaArea> PersonaBuscar(string CodPersona,string Nombres,string Apellido_Paterno,string Apellido_Materno, string CodArea, string Nom_Area, String Nivel)
        {
            string CodPersona_ = "", Nombres_ = "", Apellido_Paterno_ = "", Apellido_Materno_ = "", CodArea_ = "", Nom_Area_="",Nivel_="";

            if (CodPersona == "*") { CodPersona_ = "";    } else { CodPersona_ = CodPersona; }
            if (Nombres == "*") { Nombres_ = ""; } else { Nombres_ = Nombres; }
            if (Apellido_Paterno == "*") { Apellido_Paterno_ = ""; } else { Apellido_Paterno_ = Apellido_Paterno; }
            if (Apellido_Materno == "*") { Apellido_Materno_ = ""; } else { Apellido_Materno_ = Apellido_Materno; }
            if (CodArea == "*") { CodArea_ = ""; } else { CodArea_ = CodArea; }
            if (Nom_Area == "*") { Nom_Area_ = ""; } else { CodPersona_ = Nom_Area; }
            if (Nivel == "*") { Nivel_ = ""; } else { Nivel_ = Nivel; }
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.PersonaBuscar(CodPersona_,Nombres_,Apellido_Paterno_,Apellido_Materno_,CodArea_,Nom_Area_,Nivel_);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("ListaPersonaXArea/{CodPersona}/{Nombres}/{Apellido_Paterno}/{Apellido_Materno}/{CodArea}/{Nom_Area}")]
        [HttpGet()]
        public virtual IList<CPersonaXAr> ListaPersonaXArea(string CodPersona, string Nombres, string Apellido_Paterno, string Apellido_Materno, string CodArea, string Nom_Area)
        {
            string CodPersona_ = "", Nombres_ = "", Apellido_Paterno_ = "", Apellido_Materno_ = "", CodArea_ = "", Nom_Area_ = "";

            if (CodPersona == "*") { CodPersona_ = ""; } else { CodPersona_ = CodPersona; }
            if (Nombres == "*") { Nombres_ = ""; } else { Nombres_ = Nombres; }
            if (Apellido_Paterno == "*") { Apellido_Paterno_ = ""; } else { Apellido_Paterno_ = Apellido_Paterno; }
            if (Apellido_Materno == "*") { Apellido_Materno_ = ""; } else { Apellido_Materno_ = Apellido_Materno; }
            if (CodArea == "*") { CodArea_ = ""; } else { CodArea_ = CodArea; }
            if (Nom_Area == "*") { Nom_Area_ = ""; } else { CodPersona_ = Nom_Area; }
            try
            {
                PersonaFacade faPersona = new PersonaFacade();
                return faPersona.ListaPersonaXArea(CodPersona_, Nombres_, Apellido_Paterno_, Apellido_Materno_, CodArea_, Nom_Area_);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
