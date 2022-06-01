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
using GESTDOC.BusinessObjects.Config;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace GESTDOC.DataObjectsNet.Config
{
    
    
    public partial class Configuracion_SistemaDao : DataAccessBase
    {
        
        public virtual CConfiguracion_Sistema getConfiguracion_Sistema(DataRow dr)
        {
            return new CConfiguracion_Sistema(Convert.ToString(dr["Variable"]),Convert.ToString(dr["Valor_Variable"]));
        }
        
        public virtual CConfiguracion_Sistema getConfiguracion_Sistema(IDataReader dr)
        {
            return new CConfiguracion_Sistema(Convert.ToString(dr["Variable"]),Convert.ToString(dr["Valor_Variable"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CConfiguracion_Sistema oConfiguracion_Sistema)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Config.Configuracion_Sistema_Guardar")){
            Db.AddInParameter(dbCmd, "Variable", DbType.String, oConfiguracion_Sistema.Variable);
            Db.AddInParameter(dbCmd, "Valor_Variable", DbType.String, oConfiguracion_Sistema.Valor_Variable);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Variable)
        {
            return Db.ExecuteNonQuery("Config.Configuracion_Sistema_Eliminar",Variable);
        }
        
        public virtual CConfiguracion_Sistema Recuperar(String Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.Configuracion_Sistema_Recuperar",Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getConfiguracion_Sistema(dtDatos.Rows[0]);
            else
            return new CConfiguracion_Sistema();
        }
        
        public virtual bool Existe(String Variable)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.Configuracion_Sistema_Recuperar",Variable).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Variable, out CConfiguracion_Sistema oConfiguracion_Sistema)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Config.Configuracion_Sistema_Recuperar",Variable).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oConfiguracion_Sistema = getConfiguracion_Sistema(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oConfiguracion_Sistema = new CConfiguracion_Sistema();
            return false;
            }
        }
        
        public virtual IList<CConfiguracion_Sistema> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Config.Configuracion_Sistema_Listar")){
            IList<CConfiguracion_Sistema> list = new List<CConfiguracion_Sistema>();
            while (dr.Read())
            list.Add(getConfiguracion_Sistema(dr));
            return list;
            }
        }
        #endregion
    }
}
