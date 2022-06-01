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
    public partial class PlantillaFacade
    {
        
        private PlantillaDao plantilla;
        
        // --- Variables de control de errores 
        private string Error;
        
        private bool hayError;
        
        #region Constructores
        public PlantillaFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
            default: plantilla = new PlantillaDao();
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
        public virtual bool Grabar(CPlantilla oPlantilla)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (oPlantilla.CodPlantilla.Trim() == "")
            {
            	Error = "CodPlantilla no puede ser vacío.";
            	hayError = true;
            	return false;
            }
            //---Validando referencias foraneas
            else
            	return plantilla.Grabar(oPlantilla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CPlantilla oPlantilla, out string error)
        {
            bool rpta = Grabar(oPlantilla);
            error = Error;
            return rpta;
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodPlantilla)
        {
            return plantilla.Eliminar(CodPlantilla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CPlantilla Recuperar(String CodPlantilla)
        {
            return plantilla.Recuperar(CodPlantilla);
        }
        #endregion
        
        #region Metodos Secundarios
        public virtual bool Existe(String CodPlantilla)
        {
            return plantilla.Existe(CodPlantilla);
        }
        
        public virtual bool Existe(String CodPlantilla, out CPlantilla oPlantilla)
        {
            return plantilla.Existe(CodPlantilla, out oPlantilla);
        }
        
        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CPlantilla> Listar()
        {
            return plantilla.Listar();
        }
        public virtual string MaxValor()
        {
            return plantilla.MaxValor();
        }
        #endregion
    }
}
