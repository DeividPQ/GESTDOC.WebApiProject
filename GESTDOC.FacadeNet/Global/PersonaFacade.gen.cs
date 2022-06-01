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
    public partial class PersonaFacade
    {
        
        private PersonaDao persona;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PersonaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: persona = new PersonaDao();
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
        public virtual bool Grabar(CPersona oPersona)
        {
            Error = "";
            hayError = false;
            AreaFacade faArea = new AreaFacade();
            //---Validando campos no nulos
            if (oPersona.CodPersona.Trim() == "")
            {
            	Error = "CodPersona no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if ((oPersona.CodArea.Trim() != "" && (!faArea.Existe(oPersona.CodArea))))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oPersona.CodArea," en CodArea no existe. (Area, CodArea)");
            	hayError = true;
            	return false;
            }
            else
            	return persona.Grabar(oPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPersona oPersona, out string error)
        {
            bool rpta = Grabar(oPersona);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodPersona)
        {
            return persona.Eliminar(CodPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPersona Recuperar(String CodPersona)
        {
            return persona.Recuperar(CodPersona);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodPersona)
        {
            return persona.Existe(CodPersona);
        }
        
        public virtual bool Existe(String CodPersona, out CPersona oPersona)
        {
            return persona.Existe(CodPersona, out oPersona);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPersona> Listar()
        {
            return persona.Listar();
        }
        #endregion
    }
}
