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
    
    
    public partial class Acceso_PerfilDao : DataAccessBase
    {
        
        public virtual CAcceso_Perfil getAcceso_Perfil(DataRow dr)
        {
            return new CAcceso_Perfil(Convert.ToString(dr["Cod_Acceso"]),Convert.ToString(dr["Cod_Perfil"]));
        }
        
        public virtual CAcceso_Perfil getAcceso_Perfil(IDataReader dr)
        {
            return new CAcceso_Perfil(Convert.ToString(dr["Cod_Acceso"]),Convert.ToString(dr["Cod_Perfil"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CAcceso_Perfil oAcceso_Perfil)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Seguridad.Acceso_Perfil_Guardar")){
            Db.AddInParameter(dbCmd, "Cod_Acceso", DbType.String, oAcceso_Perfil.Cod_Acceso);
            Db.AddInParameter(dbCmd, "Cod_Perfil", DbType.String, oAcceso_Perfil.Cod_Perfil);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String Cod_Acceso, String Cod_Perfil)
        {
            return Db.ExecuteNonQuery("Seguridad.Acceso_Perfil_Eliminar",Cod_Acceso,Cod_Perfil);
        }
        
        public virtual CAcceso_Perfil Recuperar(String Cod_Acceso, String Cod_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Perfil_Recuperar",Cod_Acceso,Cod_Perfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getAcceso_Perfil(dtDatos.Rows[0]);
            else
            return new CAcceso_Perfil();
        }
        
        public virtual bool Existe(String Cod_Acceso, String Cod_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Perfil_Recuperar",Cod_Acceso,Cod_Perfil).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String Cod_Acceso, String Cod_Perfil, out CAcceso_Perfil oAcceso_Perfil)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Seguridad.Acceso_Perfil_Recuperar",Cod_Acceso,Cod_Perfil).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oAcceso_Perfil = getAcceso_Perfil(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oAcceso_Perfil = new CAcceso_Perfil();
            return false;
            }
        }
        
        public virtual IList<CAcceso_Perfil> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Seguridad.Acceso_Perfil_Listar")){
            IList<CAcceso_Perfil> list = new List<CAcceso_Perfil>();
            while (dr.Read())
            list.Add(getAcceso_Perfil(dr));
            return list;
            }
        }
        #endregion
    }
}
