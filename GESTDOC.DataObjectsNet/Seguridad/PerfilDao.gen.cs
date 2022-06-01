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
    
    
    public partial class PerfilDao : DataAccessBase
    {
        
        public virtual CPerfil getPerfil(DataRow dr)
        {
            return new CPerfil(Convert.ToString(dr["Cod_Perfil"]),Convert.ToString(dr["Des_Perfil"]),Convert.ToChar(dr["Estado"]));
        }
        
        public virtual CPerfil getPerfil(IDataReader dr)
        {
            return new CPerfil(Convert.ToString(dr["Cod_Perfil"]),Convert.ToString(dr["Des_Perfil"]),Convert.ToChar(dr["Estado"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CPerfil oPerfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.Perfil_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Perfil", DbType.String, oPerfil.Cod_Perfil);
            Db.AddInParameter(dbCmd, "Des_Perfil", DbType.String, oPerfil.Des_Perfil);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oPerfil.Estado);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Perfil)
        {
            return Db.ExecuteNonQuery("Seguridad.Perfil_Eliminar",Cod_Perfil);
        }
        
        public virtual CPerfil Recuperar(String Cod_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Perfil_Recuperar",Cod_Perfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPerfil(dtDatos.Rows[0]);
            else
            return new CPerfil();
        }
        
        public virtual bool Existe(String Cod_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Perfil_Recuperar",Cod_Perfil).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Perfil, out CPerfil oPerfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Perfil_Recuperar",Cod_Perfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPerfil = getPerfil(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPerfil = new CPerfil();
            return false;
            }
        }
        
        public virtual IList<CPerfil> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Seguridad.Perfil_Listar")){
            IList<CPerfil> list = new List<CPerfil>();
            while (dr.Read())
            list.Add(getPerfil(dr));
            return list;
            }
        }
        #endregion
    }
}
