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
    
    
    public partial class AreaDao : DataAccessBase
    {
        
        public virtual CArea getArea(DataRow dr)
        {
            return new CArea(Convert.ToString(dr["CodArea"]),Convert.ToString(dr["Acronimo"]),Convert.ToString(dr["Nom_Area"]),Convert.ToChar(dr["Tipo"]),Convert.ToString(dr["CodParent"]),Convert.ToChar(dr["Estado"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]));
        }
        
        public virtual CArea getArea(IDataReader dr)
        {
            return new CArea(Convert.ToString(dr["CodArea"]),Convert.ToString(dr["Acronimo"]),Convert.ToString(dr["Nom_Area"]),Convert.ToChar(dr["Tipo"]),Convert.ToString(dr["CodParent"]),Convert.ToChar(dr["Estado"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CArea oArea)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Area_Guardar")){
            Db.AddInParameter(dbCmd, "CodArea", DbType.String, oArea.CodArea);
            Db.AddInParameter(dbCmd, "Acronimo", DbType.String, oArea.Acronimo);
            Db.AddInParameter(dbCmd, "Nom_Area", DbType.String, oArea.Nom_Area);
            Db.AddInParameter(dbCmd, "Tipo", DbType.String, oArea.Tipo);
            Db.AddInParameter(dbCmd, "CodParent", DbType.String, oArea.CodParent);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oArea.Estado);
            Db.AddInParameter(dbCmd, "FechaCrea", DbType.DateTime, oArea.FechaCrea);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oArea.UsuarioCrea);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oArea.UsuarioModif);
            Db.AddInParameter(dbCmd, "FechaModif", DbType.DateTime, oArea.FechaModif);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodArea)
        {
            return Db.ExecuteNonQuery("Global.spu_Area_Eliminar", CodArea);
        }
        
        public virtual CArea Recuperar(String CodArea)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Area_Recuperar",CodArea).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getArea(dtDatos.Rows[0]);
            else
            return new CArea();
        }
        
        public virtual bool Existe(String CodArea)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Area_Recuperar", CodArea).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodArea, out CArea oArea)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Area_Recuperar", CodArea).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oArea = getArea(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oArea = new CArea();
            return false;
            }
        }
        
        public virtual IList<CArea> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Global.spu_Area_Listar")){
            IList<CArea> list = new List<CArea>();
            while (dr.Read())
            list.Add(getArea(dr));
            return list;
            }
        }
        #endregion
    }
}
