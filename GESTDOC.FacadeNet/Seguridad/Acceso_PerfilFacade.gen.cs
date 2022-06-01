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
using GESTDOC.FacadeNet.Seguridad;

namespace GESTDOC.FacadeNet.Seguridad
{
    
    
    [DataObject(true)]
    public partial class Acceso_PerfilFacade
    {
        
        private Acceso_PerfilDao acceso_Perfil;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Acceso_PerfilFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: acceso_Perfil = new Acceso_PerfilDao();
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
        public virtual bool Grabar(CAcceso_Perfil oAcceso_Perfil)
        {
            Error = "";
            hayError = false;
            AccesoFacade faAcceso = new AccesoFacade();
            PerfilFacade faPerfil = new PerfilFacade();
            //---Validando campos no nulos
            if (oAcceso_Perfil.Cod_Acceso.Trim() == "")
            {
            	Error = "Cod_Acceso no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oAcceso_Perfil.Cod_Perfil.Trim() == "")
            {
            	Error = "Cod_Perfil no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if (!faAcceso.Existe(oAcceso_Perfil.Cod_Acceso))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oAcceso_Perfil.Cod_Acceso," en Cod_Acceso no existe. (Acceso, Cod_Acceso)");
            	hayError = true;
            	return false;
            }
            else if (!faPerfil.Existe(oAcceso_Perfil.Cod_Perfil))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oAcceso_Perfil.Cod_Perfil," en Cod_Perfil no existe. (Perfil, Cod_Perfil)");
            	hayError = true;
            	return false;
            }
            else
            	return acceso_Perfil.Grabar(oAcceso_Perfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CAcceso_Perfil oAcceso_Perfil, out string error)
        {
            bool rpta = Grabar(oAcceso_Perfil);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Acceso, String Cod_Perfil)
        {
            return acceso_Perfil.Eliminar(Cod_Acceso,Cod_Perfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CAcceso_Perfil Recuperar(String Cod_Acceso, String Cod_Perfil)
        {
            return acceso_Perfil.Recuperar(Cod_Acceso,Cod_Perfil);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Acceso, String Cod_Perfil)
        {
            return acceso_Perfil.Existe(Cod_Acceso,Cod_Perfil);
        }
        
        public virtual bool Existe(String Cod_Acceso, String Cod_Perfil, out CAcceso_Perfil oAcceso_Perfil)
        {
            return acceso_Perfil.Existe(Cod_Acceso,Cod_Perfil, out oAcceso_Perfil);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAcceso_Perfil> Listar()
        {
            return acceso_Perfil.Listar();
        }
        #endregion
    }
}
