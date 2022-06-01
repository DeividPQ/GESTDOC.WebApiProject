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
using GESTDOC.BusinessObjects.Historial;
using GESTDOC.DataObjectsNet.Historial;
using GESTDOC.FacadeNet.Global;

namespace GESTDOC.FacadeNet.Historial
{
    
    
    [DataObject(true)]
    public partial class Documento_FinalFacade
    {
        
        private Documento_FinalDao documento_Final;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Documento_FinalFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: documento_Final = new Documento_FinalDao();
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
        public virtual bool Grabar(CDocumento_Final oDocumento_Final)
        {
            Error = "";
            hayError = false;
            DocumentoFacade faDocumento = new DocumentoFacade();
            //---Validando campos no nulos
            if (oDocumento_Final.IDDoc_Final<=0)
            {
            	Error = "IDDoc_Final no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oDocumento_Final.CodDocumento.Trim() != "" && (!faDocumento.Existe(oDocumento_Final.CodDocumento,oDocumento_Final.Version))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento_Final.CodDocumento," en CodDocumento no existe. (Documento, CodDocumento)");
            	hayError = true;
            	return false;
            }
            else if ((oDocumento_Final.Version <= 0 && (!faDocumento.Existe(oDocumento_Final.CodDocumento,oDocumento_Final.Version))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oDocumento_Final.Version," en Version no existe. (Documento, Version)");
            	hayError = true;
            	return false;
            }
            else
            	return documento_Final.Grabar(oDocumento_Final);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CDocumento_Final oDocumento_Final, out string error)
        {
            bool rpta = Grabar(oDocumento_Final);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(Int32 IDDoc_Final)
        {
            return documento_Final.Eliminar(IDDoc_Final);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CDocumento_Final Recuperar(Int32 IDDoc_Final)
        {
            return documento_Final.Recuperar(IDDoc_Final);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(Int32 IDDoc_Final)
        {
            return documento_Final.Existe(IDDoc_Final);
        }
        
        public virtual bool Existe(Int32 IDDoc_Final, out CDocumento_Final oDocumento_Final)
        {
            return documento_Final.Existe(IDDoc_Final, out oDocumento_Final);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CDocumento_Final> Listar()
        {
            return documento_Final.Listar();
        }
        #endregion
    }
}
