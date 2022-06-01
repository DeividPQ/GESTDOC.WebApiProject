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
    public partial class AreaFacade
    {
        
        private AreaDao area;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public AreaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: area = new AreaDao();
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
        public virtual bool Grabar(CArea oArea)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oArea.CodArea.Trim() == "")
            {
            	Error = "CodArea no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return area.Grabar(oArea);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CArea oArea, out string error)
        {
            bool rpta = Grabar(oArea);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodArea)
        {
            return area.Eliminar(CodArea);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CArea Recuperar(String CodArea)
        {
            return area.Recuperar(CodArea);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodArea)
        {
            return area.Existe(CodArea);
        }
        
        public virtual bool Existe(String CodArea, out CArea oArea)
        {
            return area.Existe(CodArea, out oArea);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CArea> Listar()
        {
            return area.Listar();
        }
        #endregion
    }
}
