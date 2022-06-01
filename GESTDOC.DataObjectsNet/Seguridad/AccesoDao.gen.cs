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
using GESTDOC.BusinessObjects.Seguridad;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;
using LibreriaBSNetCore;

namespace GESTDOC.DataObjectsNet.Seguridad
{
    
    
    public partial class AccesoDao : DataAccessBase
    {
        
        public virtual CAcceso getAcceso(DataRow dr)
        {
            return new CAcceso(Convert.ToString(dr["Cod_Acceso"]),Convert.ToString(dr["Nombre_Acceso"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Comando"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Imagen"]),Convert.ToInt16(dr["Nivel"]));
        }
        
        public virtual CAcceso getAcceso(IDataReader dr)
        {
            return new CAcceso(Convert.ToString(dr["Cod_Acceso"]),Convert.ToString(dr["Nombre_Acceso"]),Convert.ToString(dr["Descripcion"]),Convert.ToString(dr["Comando"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Imagen"]),Convert.ToInt16(dr["Nivel"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CAcceso oAcceso)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.Acceso_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, oAcceso.Cod_Acceso);
            Db.AddInParameter(dbCmd, "Nombre_Acceso", DbType.String, oAcceso.Nombre_Acceso);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oAcceso.Descripcion);
            Db.AddInParameter(dbCmd, "Comando", DbType.String, oAcceso.Comando);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oAcceso.Estado);
            Db.AddInParameter(dbCmd, "Imagen", DbType.String, oAcceso.Imagen);
            Db.AddInParameter(dbCmd, "Nivel", DbType.Int16, oAcceso.Nivel);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Acceso)
        {
            return Db.ExecuteNonQuery("Seguridad.Acceso_Eliminar",Cod_Acceso);
        }
        
        public virtual CAcceso Recuperar(String Cod_Acceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Recuperar",Cod_Acceso).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getAcceso(dtDatos.Rows[0]);
            else
            return new CAcceso();
        }
        
        public virtual bool Existe(String Cod_Acceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Recuperar",Cod_Acceso).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Acceso, out CAcceso oAcceso)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Recuperar",Cod_Acceso).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oAcceso = getAcceso(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oAcceso = new CAcceso();
            return false;
            }
        }
        
        public virtual IList<CAcceso> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Seguridad.Acceso_Listar")){
            IList<CAcceso> list = new List<CAcceso>();
            while (dr.Read())
            list.Add(getAcceso(dr));
            return list;
            }
        }
        #endregion
    }
}
