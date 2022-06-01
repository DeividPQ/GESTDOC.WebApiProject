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
using GESTDOC.FacadeNet.Global;
using GESTDOC.FacadeNet.Seguridad;

namespace GESTDOC.FacadeNet.Seguridad
{
    
    
    [DataObject(true)]
    public partial class UsuarioFacade
    {
        
        private UsuarioDao usuario;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public UsuarioFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: usuario = new UsuarioDao();
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
        public virtual bool Grabar(CUsuario oUsuario)
        {
            Error = "";
            hayError = false;
            PersonaFacade faPersona = new PersonaFacade();
            PerfilFacade faPerfil = new PerfilFacade();
            //---Validando campos no nulos
            if (oUsuario.Cod_Usuario.Trim() == "")
            {
            	Error = "Cod_Usuario no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oUsuario.CodPersona.Trim() != "" && (!faPersona.Existe(oUsuario.CodPersona))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oUsuario.CodPersona," en CodPersona no existe. (Persona, CodPersona)");
            	hayError = true;
            	return false;
            }
            else if ((oUsuario.Cod_Perfil.Trim() != "" && (!faPerfil.Existe(oUsuario.Cod_Perfil))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oUsuario.Cod_Perfil," en Cod_Perfil no existe. (Perfil, Cod_Perfil)");
            	hayError = true;
            	return false;
            }
            else
            	return usuario.Grabar(oUsuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CUsuario oUsuario, out string error)
        {
            bool rpta = Grabar(oUsuario);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Usuario)
        {
            return usuario.Eliminar(Cod_Usuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CUsuario Recuperar(String Cod_Usuario)
        {
            return usuario.Recuperar(Cod_Usuario);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Usuario)
        {
            return usuario.Existe(Cod_Usuario);
        }
        
        public virtual bool Existe(String Cod_Usuario, out CUsuario oUsuario)
        {
            return usuario.Existe(Cod_Usuario, out oUsuario);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CUsuario> Listar()
        {
            return usuario.Listar();
        }
        #endregion
    }
}
