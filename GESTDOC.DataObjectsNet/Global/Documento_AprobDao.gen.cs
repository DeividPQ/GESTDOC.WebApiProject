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
    
    
    public partial class Documento_AprobDao : DataAccessBase
    {
        
        public virtual CDocumento_Aprob getDocumento_Aprob(DataRow dr)
        {
            return new CDocumento_Aprob(Convert.ToInt16(dr["Version"]),Convert.ToString(dr["CodDocumento"]),Convert.ToInt16(dr["Nivel"]),Convert.ToChar(dr["EstadoAprob"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]),Convert.ToString(dr["CodAprobador"]));
        }
        
        public virtual CDocumento_Aprob getDocumento_Aprob(IDataReader dr)
        {
            return new CDocumento_Aprob(Convert.ToInt16(dr["Version"]),Convert.ToString(dr["CodDocumento"]),Convert.ToInt16(dr["Nivel"]),Convert.ToChar(dr["EstadoAprob"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]),Convert.ToString(dr["CodAprobador"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CDocumento_Aprob oDocumento_Aprob)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.Documento_Aprob_Guardar")){
            Db.AddInParameter(dbCmd, "Version", DbType.Int16, oDocumento_Aprob.Version);
            Db.AddInParameter(dbCmd, "CodDocumento", DbType.String, oDocumento_Aprob.CodDocumento);
            Db.AddInParameter(dbCmd, "Nivel", DbType.Int16, oDocumento_Aprob.Nivel);
            Db.AddInParameter(dbCmd, "EstadoAprob", DbType.String, oDocumento_Aprob.EstadoAprob);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oDocumento_Aprob.UsuarioCrea);
            Db.AddInParameter(dbCmd, "FechaCrea", DbType.DateTime, oDocumento_Aprob.FechaCrea);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oDocumento_Aprob.UsuarioModif);
            Db.AddInParameter(dbCmd, "FechaModif", DbType.DateTime, oDocumento_Aprob.FechaModif);
            Db.AddInParameter(dbCmd, "CodAprobador", DbType.String, oDocumento_Aprob.CodAprobador);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            return Db.ExecuteNonQuery("Global.Documento_Aprob_Eliminar",Version,CodDocumento,Nivel);
        }
        
        public virtual CDocumento_Aprob Recuperar(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Aprob_Recuperar",Version,CodDocumento,Nivel).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getDocumento_Aprob(dtDatos.Rows[0]);
            else
            return new CDocumento_Aprob();
        }
        
        public virtual bool Existe(Int16 Version, String CodDocumento, Int16 Nivel)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Aprob_Recuperar",Version,CodDocumento,Nivel).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int16 Version, String CodDocumento, Int16 Nivel, out CDocumento_Aprob oDocumento_Aprob)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Aprob_Recuperar",Version,CodDocumento,Nivel).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oDocumento_Aprob = getDocumento_Aprob(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oDocumento_Aprob = new CDocumento_Aprob();
            return false;
            }
        }
        
        public virtual IList<CDocumento_Aprob> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.Documento_Aprob_Listar")){
            IList<CDocumento_Aprob> list = new List<CDocumento_Aprob>();
            while (dr.Read())
            list.Add(getDocumento_Aprob(dr));
            return list;
            }
        }
        #endregion
    }
}
