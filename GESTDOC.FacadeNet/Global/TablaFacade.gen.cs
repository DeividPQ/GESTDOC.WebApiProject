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
    public partial class TablaFacade
    {
        
        private TablaDao tabla;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public TablaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: tabla = new TablaDao();
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
        public virtual bool Grabar(CTabla oTabla)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oTabla.Cod_Tabla.Trim() == "")
            {
            	Error = "Cod_Tabla no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return tabla.Grabar(oTabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CTabla oTabla, out string error)
        {
            bool rpta = Grabar(oTabla);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Tabla)
        {
            return tabla.Eliminar(Cod_Tabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CTabla Recuperar(String Cod_Tabla)
        {
            return tabla.Recuperar(Cod_Tabla);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Tabla)
        {
            return tabla.Existe(Cod_Tabla);
        }
        
        public virtual bool Existe(String Cod_Tabla, out CTabla oTabla)
        {
            return tabla.Existe(Cod_Tabla, out oTabla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CTabla> Listar()
        {
            return tabla.Listar();
        }
        #endregion
    }
}
