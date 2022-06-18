using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using GESTDOC.BusinessObjects.Global;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace GESTDOC.DataObjectsNet.Global
{
    public partial class Sistemas_GestionDao : DataAccessBase
    {

        public virtual CSistema_Gestion getTipo_Documento(DataRow dr)
        {
            return new CSistema_Gestion(Convert.ToString(dr["CodSist_Gest"]), Convert.ToString(dr["Descripcion"]), Convert.ToChar(dr["Estado"]));
        }

        public virtual CSistema_Gestion getTipo_Documento(IDataReader dr)
        {
            return new CSistema_Gestion(Convert.ToString(dr["CodSist_Gest"]), Convert.ToString(dr["Descripcion"]), Convert.ToChar(dr["Estado"]));
        }

        #region Metodos Principales
        public virtual bool Grabar(CSistema_Gestion sistema_gestion)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Sistemas_Gestion_Guardar"))
            {
                Db.AddInParameter(dbCmd, "CodSist_Gest", DbType.String, sistema_gestion.CodSist_Gest);
                Db.AddInParameter(dbCmd, "Descripcion", DbType.String, sistema_gestion.Descripcion);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, sistema_gestion.Estado);
                // --- Ejecutando procedimiento almacenado
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(String Cod_Tipo)
        {
            return Db.ExecuteNonQuery("Global.spu_Sistemas_Gestion_Eliminar", Cod_Tipo);
        }

        public virtual CSistema_Gestion Recuperar(String Cod_Tipo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Sistemas_Gestion_Recuperar", Cod_Tipo).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getTipo_Documento(dtDatos.Rows[0]);
            else
                return new CSistema_Gestion();
        }

        public virtual bool Existe(String Cod_Tipo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Sistemas_Gestion_Recuperar", Cod_Tipo).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(String Cod_Tipo, out CSistema_Gestion oTipo_Documento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Sistemas_Gestion_Recuperar", Cod_Tipo).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oTipo_Documento = getTipo_Documento(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oTipo_Documento = new CSistema_Gestion();
                return false;
            }
        }

        public virtual IList<CSistema_Gestion> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Global.spu_Sistemas_Gestion_Listar"))
            {
                IList<CSistema_Gestion> list = new List<CSistema_Gestion>();
                while (dr.Read())
                    list.Add(getTipo_Documento(dr));
                return list;
            }
        }
        #endregion
    }
}
