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
    public partial class Documento_AprobFacade
    {
        
        private Documento_AprobDao documento_Aprob;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Documento_AprobFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: documento_Aprob = new Documento_AprobDao();
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
        public virtual bool Grabar(CDocumento_Aprob oDocumento_Aprob)
        {
            Error = "";
            hayError = false;
            PersonaFacade faPersona = new PersonaFacade();
            DocumentoFacade faDocumento = new DocumentoFacade();
            //---Validando campos no nulos
            if (oDocumento_Aprob.Version<=0)
            {
            	Error = "Version no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDocumento_Aprob.CodDocumento.Trim() == "")
            {
            	Error = "CodDocumento no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oDocumento_Aprob.Nivel<=0)
            {
            	Error = "Nivel no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oDocumento_Aprob.CodAprobador.Trim() != "" && (!faPersona.Existe(oDocumento_Aprob.CodAprobador))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento_Aprob.CodAprobador," en CodAprobador no existe. (Persona, CodAprobador)");
            	hayError = true;
            	return false;
            }
            else if (!faDocumento.Existe(oDocumento_Aprob.CodDocumento,oDocumento_Aprob.Version))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento_Aprob.CodDocumento," en CodDocumento no existe. (Documento, CodDocumento)");
            	hayError = true;
            	return false;
            }
            else if (!faDocumento.Existe(oDocumento_Aprob.CodDocumento, oDocumento_Aprob.Version))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento_Aprob.Version," en Version no existe. (Documento, Version)");
            	hayError = true;
            	return false;
            }
            else
            	return documento_Aprob.Grabar(oDocumento_Aprob);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDocumento_Aprob oDocumento_Aprob, out string error)
        {
            bool rpta = Grabar(oDocumento_Aprob);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            return documento_Aprob.Eliminar(Version,CodDocumento,Nivel);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDocumento_Aprob Recuperar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            return documento_Aprob.Recuperar(Version,CodDocumento,Nivel);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            return documento_Aprob.Existe(Version,CodDocumento,Nivel);
        }
        
        public virtual bool Existe(Int16 Version, String CodDocumento, Int16 Nivel, out CDocumento_Aprob oDocumento_Aprob)
        {
            return documento_Aprob.Existe(Version,CodDocumento,Nivel, out oDocumento_Aprob);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDocumento_Aprob> Listar()
        {
            return documento_Aprob.Listar();
        }
        #endregion
    }
}
