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
using GESTDOC.BusinessObjects.Seguridad;
using GESTDOC.DataObjectsNet.Seguridad;

namespace GESTDOC.FacadeNet.Seguridad
{
    
    
    [DataObject(true)]
    public partial class AccesoFacade
    {
        
        private AccesoDao acceso;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public AccesoFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: acceso = new AccesoDao();
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
        public virtual bool Grabar(CAcceso oAcceso)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oAcceso.Cod_Acceso.Trim() == "")
            {
            	Error = "Cod_Acceso no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return acceso.Grabar(oAcceso);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CAcceso oAcceso, out string error)
        {
            bool rpta = Grabar(oAcceso);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Acceso)
        {
            return acceso.Eliminar(Cod_Acceso);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CAcceso Recuperar(String Cod_Acceso)
        {
            return acceso.Recuperar(Cod_Acceso);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Acceso)
        {
            return acceso.Existe(Cod_Acceso);
        }
        
        public virtual bool Existe(String Cod_Acceso, out CAcceso oAcceso)
        {
            return acceso.Existe(Cod_Acceso, out oAcceso);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAcceso> Listar()
        {
            return acceso.Listar();
        }
        #endregion
    }
}
