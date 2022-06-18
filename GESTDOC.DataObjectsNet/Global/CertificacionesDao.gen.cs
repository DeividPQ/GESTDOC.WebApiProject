using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using GESTDOC.BusinessObjects.Global;

namespace GESTDOC.DataObjectsNet.Global
{
    public partial class CertificacionesDao : DataAccessBase
    {
        public virtual CCertificaciones getTipo_Documento(DataRow dr)
        {
            return new CCertificaciones(Convert.ToString(dr["Cod_Certificacion"]), Convert.ToString(dr["Descripcion"]), Convert.ToChar(dr["Estado"]));
        }

        public virtual CCertificaciones getTipo_Documento(IDataReader dr)
        {
            return new CCertificaciones(Convert.ToString(dr["Cod_Certificacion"]), Convert.ToString(dr["Descripcion"]), Convert.ToChar(dr["Estado"]));
        }

        #region Metodos Principales
        public virtual bool Grabar(CCertificaciones Cod_Certificacion)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Certificaciones_Guardar"))
            {
                Db.AddInParameter(dbCmd, "Cod_Certificacion", DbType.String, Cod_Certificacion.Cod_Certificacion);
                Db.AddInParameter(dbCmd, "Descripcion", DbType.String, Cod_Certificacion.Descripcion);
                Db.AddInParameter(dbCmd, "Estado", DbType.String, Cod_Certificacion.Estado);
                // --- Ejecutando procedimiento almacenado
                return Db.ExecuteNonQuery(dbCmd) > 0;
            }
        }

        public virtual int Eliminar(String Cod_Certificacion)
        {
            return Db.ExecuteNonQuery("Global.spu_Certificaciones_Eliminar", Cod_Certificacion);
        }

        public virtual CCertificaciones Recuperar(String Cod_Certificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Certificaciones_Recuperar", Cod_Certificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
                return getTipo_Documento(dtDatos.Rows[0]);
            else
                return new CCertificaciones();
        }

        public virtual bool Existe(String Cod_Certificacion)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Certificaciones_Recuperar", Cod_Certificacion).Tables[0];
            return dtDatos.Rows.Count > 0;
        }

        public virtual bool Existe(String Cod_Certificacion, out CCertificaciones oTipo_Documento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Certificaciones_Recuperar", Cod_Certificacion).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                oTipo_Documento = getTipo_Documento(dtDatos.Rows[0]);
                return true;
            }
            else
            {
                oTipo_Documento = new CCertificaciones();
                return false;
            }
        }

        public virtual IList<CCertificaciones> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Global.spu_Certificaciones_Listar"))
            {
                IList<CCertificaciones> list = new List<CCertificaciones>();
                while (dr.Read())
                    list.Add(getTipo_Documento(dr));
                return list;
            }
        }
        #endregion
    }
}
