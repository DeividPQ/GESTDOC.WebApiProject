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
using GESTDOC.FacadeNet.Seguridad;

namespace GESTDOC.FacadeNet.Config
{
    
    
    [DataObject(true)]
    public partial class Configuracion_UsuarioFacade
    {
        
        private Configuracion_UsuarioDao configuracion_Usuario;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Configuracion_UsuarioFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: configuracion_Usuario = new Configuracion_UsuarioDao();
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
        public virtual bool Grabar(CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            Error = "";
            hayError = false;
            UsuarioFacade faUsuario = new UsuarioFacade();
            //---Validando campos no nulos
            if (oConfiguracion_Usuario.Cod_Usuario.Trim() == "")
            {
            	Error = "Cod_Usuario no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oConfiguracion_Usuario.Nombre_Variable.Trim() == "")
            {
            	Error = "Nombre_Variable no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if (!faUsuario.Existe(oConfiguracion_Usuario.Cod_Usuario))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oConfiguracion_Usuario.Cod_Usuario," en Cod_Usuario no existe. (Usuario, Cod_Usuario)");
            	hayError = true;
            	return false;
            }
            else
            	return configuracion_Usuario.Grabar(oConfiguracion_Usuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CConfiguracion_Usuario oConfiguracion_Usuario, out string error)
        {
            bool rpta = Grabar(oConfiguracion_Usuario);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Usuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Eliminar(Cod_Usuario,Nombre_Variable);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CConfiguracion_Usuario Recuperar(String Cod_Usuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Recuperar(Cod_Usuario,Nombre_Variable);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Usuario, String Nombre_Variable)
        {
            return configuracion_Usuario.Existe(Cod_Usuario,Nombre_Variable);
        }
        
        public virtual bool Existe(String Cod_Usuario, String Nombre_Variable, out CConfiguracion_Usuario oConfiguracion_Usuario)
        {
            return configuracion_Usuario.Existe(Cod_Usuario,Nombre_Variable, out oConfiguracion_Usuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CConfiguracion_Usuario> Listar()
        {
            return configuracion_Usuario.Listar();
        }
        #endregion
    }
}
