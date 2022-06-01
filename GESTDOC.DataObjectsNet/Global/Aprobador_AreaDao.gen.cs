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
    
    
    public partial class Aprobador_AreaDao : DataAccessBase
    {
        
        public virtual CAprobador_Area getAprobador_Area(DataRow dr)
        {
            return new CAprobador_Area(Convert.ToString(dr["CodArea"]),Convert.ToInt16(dr["Nivel"]),Convert.ToString(dr["CodAprobador"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]));
        }
        
        public virtual CAprobador_Area getAprobador_Area(IDataReader dr)
        {
            return new CAprobador_Area(Convert.ToString(dr["CodArea"]),Convert.ToInt16(dr["Nivel"]),Convert.ToString(dr["CodAprobador"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CAprobador_Area oAprobador_Area)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.Aprobador_Area_Guardar")){
            Db.AddInParameter(dbCmd, "CodArea", DbType.String, oAprobador_Area.CodArea);
            Db.AddInParameter(dbCmd, "Nivel", DbType.Int16, oAprobador_Area.Nivel);
            Db.AddInParameter(dbCmd, "CodAprobador", DbType.String, oAprobador_Area.CodAprobador);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oAprobador_Area.Estado);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oAprobador_Area.UsuarioCrea);
            Db.AddInParameter(dbCmd, "FechaCrea", DbType.DateTime, oAprobador_Area.FechaCrea);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oAprobador_Area.UsuarioModif);
            Db.AddInParameter(dbCmd, "FechaModif", DbType.DateTime, oAprobador_Area.FechaModif);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodArea, Int16 Nivel, String CodAprobador)
        {
            return Db.ExecuteNonQuery("Global.Aprobador_Area_Eliminar",CodArea,Nivel,CodAprobador);
        }
        
        public virtual CAprobador_Area Recuperar(String CodArea, Int16 Nivel, String CodAprobador)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Aprobador_Area_Recuperar",CodArea,Nivel,CodAprobador).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getAprobador_Area(dtDatos.Rows[0]);
            else
            return new CAprobador_Area();
        }
        
        public virtual bool Existe(String CodArea, Int16 Nivel, String CodAprobador)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Aprobador_Area_Recuperar",CodArea,Nivel,CodAprobador).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodArea, Int16 Nivel, String CodAprobador, out CAprobador_Area oAprobador_Area)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Aprobador_Area_Recuperar",CodArea,Nivel,CodAprobador).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oAprobador_Area = getAprobador_Area(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oAprobador_Area = new CAprobador_Area();
            return false;
            }
        }
        
        public virtual IList<CAprobador_Area> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.Aprobador_Area_Listar")){
            IList<CAprobador_Area> list = new List<CAprobador_Area>();
            while (dr.Read())
            list.Add(getAprobador_Area(dr));
            return list;
            }
        }
        #endregion
    }
}
