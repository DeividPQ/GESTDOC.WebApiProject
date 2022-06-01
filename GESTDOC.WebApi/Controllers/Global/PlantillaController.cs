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
using System.IO;
using GESTDOC.Utilis;

namespace GESTDOC.WebApi.Controllers.Global
{  
    
    [Route("api/Plantilla")]
    [ApiController()]
    public partial class PlantillaController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar([FromForm] CplantillaArchivo oPlantilla)
        {
            try
            {
                PlantillaFacade faPlantilla = new PlantillaFacade();
                CPlantilla plantilla = new CPlantilla();
                plantilla.CodPlantilla = oPlantilla.CodPlantilla;
                plantilla.Des_Plantilla = oPlantilla.Des_Plantilla;
                plantilla.Titulo = oPlantilla.Titulo;
                plantilla.Nombre_Archivo = oPlantilla.Nombre_Archivo;
                plantilla.Estado = oPlantilla.Estado;
                plantilla.UsuarioCrea = oPlantilla.UsuarioCrea;
                plantilla.UsuarioModif = oPlantilla.UsuarioModif;
                var files = oPlantilla.Files;
                bool EstadoCre = false;
                string[] formato = files.FileName.Split('.');
                object fileName = Path.GetTempFileName().Replace(".tmp", "." + formato[formato.Length-1]);
                using (FileStream filesStream = System.IO.File.Create(fileName.ToString()))
                {
                    files.CopyTo(filesStream);
                    filesStream.Flush();
                    EstadoCre = true;
                }
                if (EstadoCre)
                {
                    plantilla.BinArchivo = Base64.Generar(fileName.ToString());
                    System.IO.File.Delete(fileName.ToString());
                }
                bool result = faPlantilla.Grabar(plantilla);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faPlantilla.getError() }));
                }
                return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodPlantilla}")]
        [HttpGet()]
        public virtual int Eliminar(String CodPlantilla)
        {
            try
            {
                PlantillaFacade faPlantilla = new PlantillaFacade();
                return faPlantilla.Eliminar(CodPlantilla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodPlantilla}")]
        [HttpGet()]
        public virtual CPlantilla Recuperar(String CodPlantilla)
        {
            try
            {
                PlantillaFacade faPlantilla = new PlantillaFacade();
                return faPlantilla.Recuperar(CodPlantilla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodPlantilla}")]
        [HttpGet()]
        public virtual bool Existe(String CodPlantilla)
        {
            try
            {
                PlantillaFacade faPlantilla = new PlantillaFacade();
                return faPlantilla.Existe(CodPlantilla);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CPlantilla> Listar()
        {
            try
            {
                PlantillaFacade faPlantilla = new PlantillaFacade();
                return faPlantilla.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }

        [Route("MaxValor")]
        [HttpGet()]
        public virtual string MaxValor()
        {
            PlantillaFacade faPlantilla = new PlantillaFacade();
            return faPlantilla.MaxValor();
        }
        public class FILESNUEVOS
        {
            public string type { get; set; }
            public byte[] data { get; set; }
        }
    }
}
