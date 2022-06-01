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

namespace GESTDOC.FacadeNet.Global
{
    
    
    [DataObject(true)]
    public partial class Tipo_DocumentoFacade
    {
        
        private Tipo_DocumentoDao tipo_Documento;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Tipo_DocumentoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tipo_Documento = new Tipo_DocumentoDao();
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
        public virtual bool Grabar(CTipo_Documento oTipo_Documento)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oTipo_Documento.Cod_Tipo.Trim() == "")
            {
            	Error = "Cod_Tipo no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return tipo_Documento.Grabar(oTipo_Documento);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CTipo_Documento oTipo_Documento, out string error)
        {
            bool rpta = Grabar(oTipo_Documento);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Tipo)
        {
            return tipo_Documento.Eliminar(Cod_Tipo);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CTipo_Documento Recuperar(String Cod_Tipo)
        {
            return tipo_Documento.Recuperar(Cod_Tipo);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Tipo)
        {
            return tipo_Documento.Existe(Cod_Tipo);
        }
        
        public virtual bool Existe(String Cod_Tipo, out CTipo_Documento oTipo_Documento)
        {
            return tipo_Documento.Existe(Cod_Tipo, out oTipo_Documento);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CTipo_Documento> Listar()
        {
            return tipo_Documento.Listar();
        }
        #endregion
    }
}
