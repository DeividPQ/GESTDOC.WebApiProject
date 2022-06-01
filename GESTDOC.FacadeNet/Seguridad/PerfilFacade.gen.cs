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
    public partial class PerfilFacade
    {
        
        private PerfilDao perfil;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PerfilFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: perfil = new PerfilDao();
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
        public virtual bool Grabar(CPerfil oPerfil)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oPerfil.Cod_Perfil.Trim() == "")
            {
            	Error = "Cod_Perfil no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return perfil.Grabar(oPerfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPerfil oPerfil, out string error)
        {
            bool rpta = Grabar(oPerfil);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Perfil)
        {
            return perfil.Eliminar(Cod_Perfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPerfil Recuperar(String Cod_Perfil)
        {
            return perfil.Recuperar(Cod_Perfil);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Perfil)
        {
            return perfil.Existe(Cod_Perfil);
        }
        
        public virtual bool Existe(String Cod_Perfil, out CPerfil oPerfil)
        {
            return perfil.Existe(Cod_Perfil, out oPerfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPerfil> Listar()
        {
            return perfil.Listar();
        }
        #endregion
    }
}
