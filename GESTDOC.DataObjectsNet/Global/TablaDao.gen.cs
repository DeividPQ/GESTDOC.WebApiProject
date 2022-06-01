//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 17 de mayo de 2022
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using GESTDOC.BusinessObjects.Global;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace GESTDOC.DataObjectsNet.Global
{
    
    
    public partial class TablaDao : DataAccessBase
    {
        
        public virtual CTabla getTabla(DataRow dr)
        {
            return new CTabla(Convert.ToString(dr["Cod_Tabla"]),Convert.ToString(dr["Nom_Tabla"]),Convert.ToString(dr["Cod_Padre"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Des_Tabla"]));
        }
        
        public virtual CTabla getTabla(IDataReader dr)
        {
            return new CTabla(Convert.ToString(dr["Cod_Tabla"]),Convert.ToString(dr["Nom_Tabla"]),Convert.ToString(dr["Cod_Padre"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Des_Tabla"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CTabla oTabla)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.Tabla_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Tabla", DbType.String, oTabla.Cod_Tabla);
            Db.AddInParameter(dbCmd, "Nom_Tabla", DbType.String, oTabla.Nom_Tabla);
            Db.AddInParameter(dbCmd, "Cod_Padre", DbType.String, oTabla.Cod_Padre);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oTabla.Estado);
            Db.AddInParameter(dbCmd, "Des_Tabla", DbType.String, oTabla.Des_Tabla);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Tabla)
        {
            return Db.ExecuteNonQuery("Global.Tabla_Eliminar",Cod_Tabla);
        }
        
        public virtual CTabla Recuperar(String Cod_Tabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Tabla_Recuperar",Cod_Tabla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTabla(dtDatos.Rows[0]);
            else
            return new CTabla();
        }
        
        public virtual bool Existe(String Cod_Tabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Tabla_Recuperar",Cod_Tabla).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Tabla, out CTabla oTabla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Tabla_Recuperar",Cod_Tabla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTabla = getTabla(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTabla = new CTabla();
            return false;
            }
        }
        
        public virtual IList<CTabla> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.Tabla_Listar")){
            IList<CTabla> list = new List<CTabla>();
            while (dr.Read())
            list.Add(getTabla(dr));
            return list;
            }
        }
        #endregion
    }
}
