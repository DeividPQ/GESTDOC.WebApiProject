using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using LibreriaBSNet.InfoApp;
using GESTDOC.BusinessObjects.Global;
using GESTDOC.DataObjectsNet.Global;

namespace GESTDOC.FacadeNet.Global
{

    [DataObject(true)]
    public partial class Sistemas_GestionFacade
    {
        private Sistemas_GestionDao sistemas_gestion;

        // --- Variables de control de errores 
        private string Error;

        private bool hayError;

        #region Constructores
        public Sistemas_GestionFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    sistemas_gestion = new Sistemas_GestionDao();
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
        public virtual bool Grabar(CSistema_Gestion sistema_sestion)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (sistema_sestion.CodSist_Gest.Trim() == "")
            {
                Error = "Cod_Certificacion no puede ser vacío.";
                hayError = true;
                return false;
            }
            //---Validando referencias foraneas
            else
                return sistemas_gestion.Grabar(sistema_sestion);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CSistema_Gestion sistema_gestion, out string error)
        {
            bool rpta = Grabar(sistema_gestion);
            error = Error;
            return rpta;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String CodSist_Gest)
        {
            return sistemas_gestion.Eliminar(CodSist_Gest);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CSistema_Gestion Recuperar(String CodSist_Gest)
        {
            return sistemas_gestion.Recuperar(CodSist_Gest);
        }
        #endregion

        #region Metodos Secundarios
        public virtual bool Existe(String CodSist_Gest)
        {
            return sistemas_gestion.Existe(CodSist_Gest);
        }

        public virtual bool Existe(String CodSist_Gest, out CSistema_Gestion sistema_gestion)
        {
            return sistemas_gestion.Existe(CodSist_Gest, out sistema_gestion);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CSistema_Gestion> Listar()
        {
            return sistemas_gestion.Listar();
        }
        #endregion
    }
}
