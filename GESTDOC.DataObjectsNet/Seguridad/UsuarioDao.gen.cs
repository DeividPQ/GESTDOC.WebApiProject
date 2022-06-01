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

namespace GESTDOC.DataObjectsNet.Seguridad
{
    
    
    public partial class UsuarioDao : DataAccessBase
    {
        
        public virtual CUsuario getUsuario(DataRow dr)
        {
            return new CUsuario(Convert.ToString(dr["Cod_Usuario"]),Convert.ToString(dr["CodPersona"]),Convert.ToString(dr["Cod_Perfil"]),Convert.ToString(dr["Passwd"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Nombre_Usuario"]),Convert.ToString(dr["Email"]),Convert.ToBoolean(dr["flagActDir"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        public virtual CUsuario getUsuario(IDataReader dr)
        {
            return new CUsuario(Convert.ToString(dr["Cod_Usuario"]),Convert.ToString(dr["CodPersona"]),Convert.ToString(dr["Cod_Perfil"]),Convert.ToString(dr["Passwd"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Nombre_Usuario"]),Convert.ToString(dr["Email"]),Convert.ToBoolean(dr["flagActDir"]),Convert.ToString(dr["UserNew"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CUsuario oUsuario)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.spu_Usuario_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Usuario", DbType.String, oUsuario.Cod_Usuario);
            Db.AddInParameter(dbCmd, "CodPersona", DbType.String, oUsuario.CodPersona);
            Db.AddInParameter(dbCmd, "Cod_Perfil", DbType.String, oUsuario.Cod_Perfil);
            Db.AddInParameter(dbCmd, "Passwd", DbType.String, oUsuario.Passwd);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oUsuario.Estado);
            Db.AddInParameter(dbCmd, "Nombre_Usuario", DbType.String, oUsuario.Nombre_Usuario);
            Db.AddInParameter(dbCmd, "Email", DbType.String, oUsuario.Email);
            Db.AddInParameter(dbCmd, "flagActDir", DbType.Boolean, oUsuario.flagActDir);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oUsuario.UserNew);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oUsuario.DateNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oUsuario.UserEdit);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oUsuario.DateEdit);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Usuario)
        {
            return Db.ExecuteNonQuery("Seguridad.Usuario_Eliminar",Cod_Usuario);
        }
        
        public virtual CUsuario Recuperar(String Cod_Usuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar", Cod_Usuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getUsuario(dtDatos.Rows[0]);
            else
            return new CUsuario();
        }
        
        public virtual bool Existe(String Cod_Usuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar", Cod_Usuario).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Usuario, out CUsuario oUsuario)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.spu_Usuario_Recuperar", Cod_Usuario).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oUsuario = getUsuario(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oUsuario = new CUsuario();
            return false;
            }
        }
        
        public virtual IList<CUsuario> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Seguridad.spu_Usuario_Listar")){
            IList<CUsuario> list = new List<CUsuario>();
            while (dr.Read())
            list.Add(getUsuario(dr));
            return list;
            }
        }
        #endregion
    }
}
