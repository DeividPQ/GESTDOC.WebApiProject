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
    
    
    [Route("api/Documento")]
    [ApiController()]
    public partial class DocumentoController : ControllerBase
    {
        
        [Route("Grabar")]
        [HttpPost()]
        public virtual ActionResult<System.Boolean> Grabar([FromForm]  CDocumentoA oDocumento_)
        {
            try
            {
                CDocumento oDocumento = new CDocumento();
                DocumentoFacade faDocumento = new DocumentoFacade();
                oDocumento.CodDocumento = oDocumento_.CodDocumento;
                oDocumento.Version = oDocumento_.Version;
                oDocumento.CodPersona = oDocumento_.CodPersona;
                oDocumento.CodArea = oDocumento_.CodArea;
                oDocumento.CodDocumentoFinal = oDocumento_.CodDocumentoFinal;
                oDocumento.Cod_Tipo = oDocumento_.Cod_Tipo;
                oDocumento.Titulo = oDocumento_.Titulo;
                oDocumento.Descripcion = oDocumento_.Descripcion;
                oDocumento.ResumenDescripcion = oDocumento_.ResumenDescripcion;
                oDocumento.Nombre_Archivo = oDocumento_.Nombre_Archivo;
                oDocumento.Vistas = oDocumento_.Vistas;
                oDocumento.TipoDocumento = oDocumento_.TipoDocumento;
                oDocumento.DetalleCambios = oDocumento_.DetalleCambios;
                oDocumento.CodSist_Gest = oDocumento_.CodSist_Gest;
                oDocumento.Cod_Certificacion = oDocumento_.Cod_Certificacion;
                oDocumento.Estado = oDocumento_.Estado;
                oDocumento.UsuarioCrea = oDocumento_.UsuarioCrea;
                oDocumento.FechaCrea = oDocumento_.FechaCrea;
                oDocumento.UsuarioModif = oDocumento_.UsuarioModif;
                oDocumento.FechaModif = oDocumento_.FechaModif;
                oDocumento.EstadoAprob = oDocumento_.EstadoAprob;
                oDocumento.CodPlantilla = oDocumento_.CodPlantilla;
                var files = oDocumento_.Files;
                bool EstadoCre = false;
                string[] formato = files.FileName.Split('.');
                object fileName = Path.GetTempFileName().Replace(".tmp", "." + formato[formato.Length - 1]);
                using (FileStream filesStream = System.IO.File.Create(fileName.ToString()))
                {
                    files.CopyTo(filesStream);
                    filesStream.Flush();
                    EstadoCre = true;
                }
                if (EstadoCre)
                {
                    oDocumento.BinArchivo = Base64.Generar(fileName.ToString());
                    System.IO.File.Delete(fileName.ToString());
                }
                bool result = faDocumento.Grabar(oDocumento);
                if (!result)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, new JsonResult(new { message = faDocumento.getError() }));
                }
                	return result;
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Eliminar/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual int Eliminar(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Eliminar(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Recuperar/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual CDocumento Recuperar(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Recuperar(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Existe/{CodDocumento}/{Version}")]
        [HttpGet()]
        public virtual bool Existe(String CodDocumento, Int16 Version)
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Existe(CodDocumento,Version);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        
        [Route("Listar")]
        [HttpGet()]
        public virtual IList<CDocumento> Listar()
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.Listar();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("MaxDocumento")]
        [HttpGet()]
        public virtual string MaxDocumento()
        {
            try
            {
                DocumentoFacade faDocumento = new DocumentoFacade();
                return faDocumento.MaxDocumento();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
        [Route("ProcesarDoc")]
        [HttpPost()]
        public virtual CArchivoDatos ProcesarDoc([FromForm] CArchivoProcesar archivoProcesar)
        {
            try
            {
                CArchivoDatos archivodatos = new CArchivoDatos();
                var files = archivoProcesar.Files;
                bool EstadoCre = false;
                string[] formato = files.FileName.Split('.');
                object fileName = Path.GetTempFileName().Replace(".tmp", "." + formato[formato.Length - 1]);
                using (FileStream filesStream = System.IO.File.Create(fileName.ToString()))
                {
                    files.CopyTo(filesStream);
                    filesStream.Flush();
                    EstadoCre = true;
                }
                String datos= Base64.AbrirArchivo(fileName.ToString());
                if (EstadoCre)
                {
                    archivodatos.ArchivoBinary = Base64.Generar(fileName.ToString());
                    System.IO.File.Delete(fileName.ToString());
                }
                return new CArchivoDatos();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw e;
            }
        }
    }
}
