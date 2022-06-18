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
using System.Data.SqlClient;
using System.Data.Common;
using GESTDOC.BusinessObjects.Global;
using Microsoft.Practices.EnterpriseLibrary.Data;
using LibreriaBSNet;

namespace GESTDOC.DataObjectsNet.Global
{
    public partial class PlantillaDao : DataAccessBase
    {
        
        public virtual CPlantilla getPlantilla(DataRow dr)
        {
            return new CPlantilla(Convert.ToString(dr["CodPlantilla"]),Convert.ToString(dr["Des_Plantilla"]),Convert.ToString(dr["Titulo"]),(byte[])(dr["BinArchivo"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]), Convert.ToString(dr["Cod_Tipo"]));
        }
        
        public virtual CPlantilla getPlantilla(IDataReader dr)
        {
            return new CPlantilla(Convert.ToString(dr["CodPlantilla"]),Convert.ToString(dr["Des_Plantilla"]),Convert.ToString(dr["Titulo"]),(byte[])(dr["BinArchivo"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]), Convert.ToString(dr["Cod_Tipo"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CPlantilla oPlantilla)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.spu_Plantilla_Guardar")){
            Db.AddInParameter(dbCmd, "CodPlantilla", DbType.String, oPlantilla.CodPlantilla);
            Db.AddInParameter(dbCmd, "Des_Plantilla", DbType.String, oPlantilla.Des_Plantilla);
            Db.AddInParameter(dbCmd, "Titulo", DbType.String, oPlantilla.Titulo);
            Db.AddInParameter(dbCmd, "BinArchivo", DbType.Binary, oPlantilla.BinArchivo);
            Db.AddInParameter(dbCmd, "Nombre_Archivo", DbType.String, oPlantilla.Nombre_Archivo);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oPlantilla.Estado);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oPlantilla.UsuarioCrea);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oPlantilla.UsuarioModif);
            Db.AddInParameter(dbCmd, "Cod_Tipo", DbType.String, oPlantilla.Cod_Tipo);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodPlantilla)
        {
            return Db.ExecuteNonQuery("Global.spu_Plantilla_Eliminar",CodPlantilla);
        }
        
        public virtual CPlantilla Recuperar(String CodPlantilla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Plantilla_Recuperar", CodPlantilla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPlantilla(dtDatos.Rows[0]);
            else
            return new CPlantilla();
        }
        
        public virtual bool Existe(String CodPlantilla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Plantilla_Recuperar", CodPlantilla).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodPlantilla, out CPlantilla oPlantilla)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Plantilla_Recuperar", CodPlantilla).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPlantilla = getPlantilla(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPlantilla = new CPlantilla();
            return false;
            }
        }
        
        public virtual IList<CPlantilla> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure, "Global.spu_Plantilla_Listar")){
            IList<CPlantilla> list = new List<CPlantilla>();
                while (dr.Read())
                list.Add(getPlantilla(dr));
                return list;
            }
        }
        public virtual string MaxValor()
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.spu_Plantilla_MaxValor").Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                DataRow dr = dtDatos.Rows[0];
                return Convert.ToString(dr["MaxValor"]);
            }
            else
                return "";
        }
        #endregion
    }
}
