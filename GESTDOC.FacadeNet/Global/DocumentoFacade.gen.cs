//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 17 de mayo de 2022
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.DataObjectsNet.Global;
using GESTDOC.FacadeNet.Global;

namespace GESTDOC.FacadeNet.Global
{
    
    
    [DataObject(true)]
    public partial class DocumentoFacade
    {
        
        private DocumentoDao documento;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public DocumentoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: documento = new DocumentoDao();
            break;
            }
        }
        #endregion
        
        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }
        
        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion
        
        #region Metodos Basicos
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDocumento oDocumento)
        {
            Error = "";
            hayError = false;
            AreaFacade faArea = new AreaFacade();
            PersonaFacade faPersona = new PersonaFacade();
            Tipo_DocumentoFacade faTipo_Documento = new Tipo_DocumentoFacade();
            PlantillaFacade faPlantilla = new PlantillaFacade();
            //---Validando campos no nulos
            if (oDocumento.CodDocumento.Trim() == "")
            {
            	Error = "CodDocumento no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDocumento.Version<=0)
            {
            	Error = "Version no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oDocumento.CodArea.Trim() != "" && (!faArea.Existe(oDocumento.CodArea))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento.CodArea," en CodArea no existe. (Area, CodArea)");
            	hayError = true;
            	return false;
            }
            else if ((oDocumento.CodPersona.Trim() != "" && (!faPersona.Existe(oDocumento.CodPersona))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento.CodPersona," en CodPersona no existe. (Persona, CodPersona)");
            	hayError = true;
            	return false;
            }
            else if ((oDocumento.Cod_Tipo.Trim() != "" && (!faTipo_Documento.Existe(oDocumento.Cod_Tipo))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento.Cod_Tipo," en Cod_Tipo no existe. (Tipo_Documento, Cod_Tipo)");
            	hayError = true;
            	return false;
            }
            else if ((oDocumento.CodPlantilla.Trim() != "" && (!faPlantilla.Existe(oDocumento.CodPlantilla))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento.CodPlantilla," en CodPlantilla no existe. (Plantilla, CodPlantilla)");
            	hayError = true;
            	return false;
            }
            else
            	return documento.Grabar(oDocumento);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDocumento oDocumento, out string error)
        {
            bool rpta = Grabar(oDocumento);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodDocumento, Int16 Version)
        {
            return documento.Eliminar(CodDocumento,Version);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDocumento Recuperar(String CodDocumento, Int16 Version)
        {
            return documento.Recuperar(CodDocumento,Version);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodDocumento, Int16 Version)
        {
            return documento.Existe(CodDocumento,Version);
        }
        
        public virtual bool Existe(String CodDocumento, Int16 Version, out CDocumento oDocumento)
        {
            return documento.Existe(CodDocumento,Version, out oDocumento);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDocumento> Listar()
        {
            return documento.Listar();
        }
        public virtual string MaxDocumento()
        {
            return documento.MaxDocumento();
        }
        #endregion
    }
}
