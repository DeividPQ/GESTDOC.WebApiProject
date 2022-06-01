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
using GESTDOC.BusinessObjects.Config;
using GESTDOC.DataObjectsNet.Config;

namespace GESTDOC.FacadeNet.Config
{
    
    
    [DataObject(true)]
    public partial class Configuracion_SistemaFacade
    {
        
        private Configuracion_SistemaDao configuracion_Sistema;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Configuracion_SistemaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: configuracion_Sistema = new Configuracion_SistemaDao();
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
        public virtual bool Grabar(CConfiguracion_Sistema oConfiguracion_Sistema)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oConfiguracion_Sistema.Variable.Trim() == "")
            {
            	Error = "Variable no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return configuracion_Sistema.Grabar(oConfiguracion_Sistema);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConfiguracion_Sistema oConfiguracion_Sistema, out string error)
        {
            bool rpta = Grabar(oConfiguracion_Sistema);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Variable)
        {
            return configuracion_Sistema.Eliminar(Variable);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConfiguracion_Sistema Recuperar(String Variable)
        {
            return configuracion_Sistema.Recuperar(Variable);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Variable)
        {
            return configuracion_Sistema.Existe(Variable);
        }
        
        public virtual bool Existe(String Variable, out CConfiguracion_Sistema oConfiguracion_Sistema)
        {
            return configuracion_Sistema.Existe(Variable, out oConfiguracion_Sistema);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConfiguracion_Sistema> Listar()
        {
            return configuracion_Sistema.Listar();
        }
        #endregion
    }
}
