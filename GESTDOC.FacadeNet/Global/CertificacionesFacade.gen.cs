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
    public partial class CertificacionesFacade
    {
        private CertificacionesDao certificacion;

        // --- Variables de control de errores 
        private string Error;

        private bool hayError;

        #region Constructores
        public CertificacionesFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    certificacion = new CertificacionesDao();
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
        public virtual bool Grabar(CCertificaciones certificaciones)
        {
            Error = "";
            hayError = false;
            //---Validando campos no nulos
            if (certificaciones.Cod_Certificacion.Trim() == "")
            {
                Error = "Cod_Certificacion no puede ser vacío.";
                hayError = true;
                return false;
            }
            //---Validando referencias foraneas
            else
                return certificacion.Grabar(certificaciones);
        }

        [DataObjectMethod(DataObjectMethodType.Insert)]
        public virtual bool Grabar(CCertificaciones certificaciones, out string error)
        {
            bool rpta = Grabar(certificaciones);
            error = Error;
            return rpta;
        }

        [DataObjectMethod(DataObjectMethodType.Delete)]
        public virtual int Eliminar(String Cod_Certificacion)
        {
            return certificacion.Eliminar(Cod_Certificacion);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual CCertificaciones Recuperar(String Cod_Certificacion)
        {
            return certificacion.Recuperar(Cod_Certificacion);
        }
        #endregion

        #region Metodos Secundarios
        public virtual bool Existe(String Cod_Tipo)
        {
            return certificacion.Existe(Cod_Tipo);
        }

        public virtual bool Existe(String Cod_Certificacion, out CCertificaciones certificaciones)
        {
            return certificacion.Existe(Cod_Certificacion, out certificaciones);
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public virtual IList<CCertificaciones> Listar()
        {
            return certificacion.Listar();
        }
        #endregion
    }
}
