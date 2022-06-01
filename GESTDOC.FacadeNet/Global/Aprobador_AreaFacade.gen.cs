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
    public partial class Aprobador_AreaFacade
    {
        
        private Aprobador_AreaDao aprobador_Area;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public Aprobador_AreaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: aprobador_Area = new Aprobador_AreaDao();
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
        public virtual bool Grabar(CAprobador_Area oAprobador_Area)
        {
            Error = "";
            hayError = false;
            AreaFacade faArea = new AreaFacade();
            PersonaFacade faPersona = new PersonaFacade();
            //---Validando campos no nulos
            if (oAprobador_Area.CodArea.Trim() == "")
            {
            	Error = "CodArea no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oAprobador_Area.Nivel<=0)
            {
            	Error = "Nivel no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            else if (oAprobador_Area.CodAprobador.Trim() == "")
            {
            	Error = "CodAprobador no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else if (!faArea.Existe(oAprobador_Area.CodArea))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oAprobador_Area.CodArea," en CodArea no existe. (Area, CodArea)");
            	hayError = true;
            	return false;
            }
            else if (!faPersona.Existe(oAprobador_Area.CodAprobador))
            {//---No existe clave foranea pero permite vacio
            	Error = string.Concat("El valor ", oAprobador_Area.CodAprobador," en CodAprobador no existe. (Persona, CodAprobador)");
            	hayError = true;
            	return false;
            }
            else
            	return aprobador_Area.Grabar(oAprobador_Area);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CAprobador_Area oAprobador_Area, out string error)
        {
            bool rpta = Grabar(oAprobador_Area);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodArea, Int16 Nivel, String CodAprobador)
        {
            return aprobador_Area.Eliminar(CodArea,Nivel,CodAprobador);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CAprobador_Area Recuperar(String CodArea, Int16 Nivel, String CodAprobador)
        {
            return aprobador_Area.Recuperar(CodArea,Nivel,CodAprobador);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodArea, Int16 Nivel, String CodAprobador)
        {
            return aprobador_Area.Existe(CodArea,Nivel,CodAprobador);
        }
        
        public virtual bool Existe(String CodArea, Int16 Nivel, String CodAprobador, out CAprobador_Area oAprobador_Area)
        {
            return aprobador_Area.Existe(CodArea,Nivel,CodAprobador, out oAprobador_Area);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CAprobador_Area> Listar()
        {
            return aprobador_Area.Listar();
        }
        #endregion
    }
}
