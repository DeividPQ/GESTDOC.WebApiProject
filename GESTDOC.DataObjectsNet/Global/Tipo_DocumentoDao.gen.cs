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
    
    
    public partial class Tipo_DocumentoDao : DataAccessBase
    {
        
        public virtual CTipo_Documento getTipo_Documento(DataRow dr)
        {
            return new CTipo_Documento(Convert.ToString(dr["Cod_Tipo"]),Convert.ToString(dr["Des_Tipo"]),Convert.ToChar(dr["Estado"]));
        }
        
        public virtual CTipo_Documento getTipo_Documento(IDataReader dr)
        {
            return new CTipo_Documento(Convert.ToString(dr["Cod_Tipo"]),Convert.ToString(dr["Des_Tipo"]),Convert.ToChar(dr["Estado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CTipo_Documento oTipo_Documento)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Tipo_Documento_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Tipo", DbType.String, oTipo_Documento.Cod_Tipo);
            Db.AddInParameter(dbCmd, "Des_Tipo", DbType.String, oTipo_Documento.Des_Tipo);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oTipo_Documento.Estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Tipo)
        {
            return Db.ExecuteNonQuery("Global.spu_Tipo_Documento_Eliminar", Cod_Tipo);
        }
        
        public virtual CTipo_Documento Recuperar(String Cod_Tipo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tipo_Documento_Recuperar",Cod_Tipo).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getTipo_Documento(dtDatos.Rows[0]);
            else
            return new CTipo_Documento();
        }
        
        public virtual bool Existe(String Cod_Tipo)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tipo_Documento_Recuperar", Cod_Tipo).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Tipo, out CTipo_Documento oTipo_Documento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Tipo_Documento_Recuperar", Cod_Tipo).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oTipo_Documento = getTipo_Documento(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oTipo_Documento = new CTipo_Documento();
            return false;
            }
        }
        
        public virtual IList<CTipo_Documento> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Global.spu_Tipo_Documento_Listar")){
            IList<CTipo_Documento> list = new List<CTipo_Documento>();
            while (dr.Read())
            list.Add(getTipo_Documento(dr));
            return list;
            }
        }
        #endregion
    }
}
