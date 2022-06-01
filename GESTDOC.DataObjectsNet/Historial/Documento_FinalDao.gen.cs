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
using GESTDOC.BusinessObjects.Historial;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace GESTDOC.DataObjectsNet.Historial
{
    
    
    public partial class Documento_FinalDao : DataAccessBase
    {
        
        public virtual CDocumento_Final getDocumento_Final(DataRow dr)
        {
            return new CDocumento_Final(Convert.ToInt32(dr["IDDoc_Final"]),Convert.ToString(dr["CodDocumento"]),Convert.ToInt16(dr["Version"]), Convert.ToString(dr["Titulo"]),Convert.ToString(dr["Descripcion"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["Nombre_Archivo"]), Convert.ToString(dr["Ruta_Almacenamiento"]), Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaModif"]),Convert.ToString(dr["UsuarioModif"]));
        }
        
        public virtual CDocumento_Final getDocumento_Final(IDataReader dr)
        {
            return new CDocumento_Final(Convert.ToInt32(dr["IDDoc_Final"]), Convert.ToString(dr["CodDocumento"]), Convert.ToInt16(dr["Version"]), Convert.ToString(dr["Titulo"]), Convert.ToString(dr["Descripcion"]), Convert.ToChar(dr["Estado"]), Convert.ToString(dr["Nombre_Archivo"]), Convert.ToString(dr["Ruta_Almacenamiento"]), Convert.ToDateTime(dr["FechaCrea"]), Convert.ToString(dr["UsuarioCrea"]), Convert.ToDateTime(dr["FechaModif"]), Convert.ToString(dr["UsuarioModif"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CDocumento_Final oDocumento_Final)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Historial.Documento_Final_Guardar")){
            Db.AddInParameter(dbCmd, "IDDoc_Final", DbType.Int32, oDocumento_Final.IDDoc_Final);
            Db.AddInParameter(dbCmd, "CodDocumento", DbType.String, oDocumento_Final.CodDocumento);
            Db.AddInParameter(dbCmd, "Version", DbType.Int16, oDocumento_Final.Version);
            Db.AddInParameter(dbCmd, "ResumenDoc", DbType.String, oDocumento_Final.Titulo);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oDocumento_Final.Descripcion);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oDocumento_Final.Estado);
            Db.AddInParameter(dbCmd, "Nombre_Archivo", DbType.String, oDocumento_Final.Nombre_Archivo);
            Db.AddInParameter(dbCmd, "Ruta_Almacenamiento", DbType.String, oDocumento_Final.Ruta_Almacenamiento);
            Db.AddInParameter(dbCmd, "FechaCrea", DbType.DateTime, oDocumento_Final.FechaCrea);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oDocumento_Final.UsuarioCrea);
            Db.AddInParameter(dbCmd, "FechaModif", DbType.DateTime, oDocumento_Final.FechaModif);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oDocumento_Final.UsuarioModif);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(Int32 IDDoc_Final)
        {
            return Db.ExecuteNonQuery("Historial.Documento_Final_Eliminar",IDDoc_Final);
        }
        
        public virtual CDocumento_Final Recuperar(Int32 IDDoc_Final)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Historial.Documento_Final_Recuperar",IDDoc_Final).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getDocumento_Final(dtDatos.Rows[0]);
            else
            return new CDocumento_Final();
        }
        
        public virtual bool Existe(Int32 IDDoc_Final)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Historial.Documento_Final_Recuperar",IDDoc_Final).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(Int32 IDDoc_Final, out CDocumento_Final oDocumento_Final)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Historial.Documento_Final_Recuperar",IDDoc_Final).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oDocumento_Final = getDocumento_Final(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oDocumento_Final = new CDocumento_Final();
            return false;
            }
        }
        
        public virtual IList<CDocumento_Final> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Historial.Documento_Final_Listar")){
            IList<CDocumento_Final> list = new List<CDocumento_Final>();
            while (dr.Read())
            list.Add(getDocumento_Final(dr));
            return list;
            }
        }
        #endregion
    }
}
