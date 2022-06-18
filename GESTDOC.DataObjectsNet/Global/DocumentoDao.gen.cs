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
    
    
    public partial class DocumentoDao : DataAccessBase
    {
        
        public virtual CDocumento getDocumento(DataRow dr)
        {
            return new CDocumento(Convert.ToString(dr["CodDocumento"]), Convert.ToInt16(dr["Version"]), Convert.ToString(dr["CodPersona"]), Convert.ToString(dr["CodArea"]), Convert.ToString(dr["CodDocumentoFinal"]), Convert.ToString(dr["Cod_Tipo"]), Convert.ToString(dr["Titulo"]), Convert.ToString(dr["Descripcion"]), (byte[])(dr["BinArchivo"]),Convert.ToString(dr["ResumenDescripcion"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToInt32(dr["Vistas"]),Convert.ToString(dr["TipoDocumento"]),Convert.ToString(dr["DetalleCambios"]), Convert.ToString(dr["CodSist_Gest"]), Convert.ToString(dr["Cod_Certificacion"]), Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]),Convert.ToChar(dr["EstadoAprob"]),Convert.ToString(dr["CodPlantilla"]));
        }
        
        public virtual CDocumento getDocumento(IDataReader dr)
        {
            return new CDocumento(Convert.ToString(dr["CodDocumento"]),Convert.ToInt16(dr["Version"]),Convert.ToString(dr["CodPersona"]),Convert.ToString(dr["CodArea"]),Convert.ToString(dr["CodDocumentoFinal"]),Convert.ToString(dr["Cod_Tipo"]),Convert.ToString(dr["Titulo"]),Convert.ToString(dr["Descripcion"]), (byte[])(dr["BinArchivo"]),Convert.ToString(dr["ResumenDescripcion"]),Convert.ToString(dr["Nombre_Archivo"]),Convert.ToInt32(dr["Vistas"]),Convert.ToString(dr["TipoDocumento"]),Convert.ToString(dr["DetalleCambios"]), Convert.ToString(dr["CodSist_Gest"]), Convert.ToString(dr["Cod_Certificacion"]), Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UsuarioCrea"]),Convert.ToDateTime(dr["FechaCrea"]),Convert.ToString(dr["UsuarioModif"]),Convert.ToDateTime(dr["FechaModif"]),Convert.ToChar(dr["EstadoAprob"]),Convert.ToString(dr["CodPlantilla"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CDocumento oDocumento)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.Documento_Guardar")){
            Db.AddInParameter(dbCmd, "CodDocumento", DbType.String, oDocumento.CodDocumento);
            Db.AddInParameter(dbCmd, "Version", DbType.Int16, oDocumento.Version);
            Db.AddInParameter(dbCmd, "CodPersona", DbType.String, oDocumento.CodPersona);
            Db.AddInParameter(dbCmd, "CodArea", DbType.String, oDocumento.CodArea);
            Db.AddInParameter(dbCmd, "CodDocumentoFinal", DbType.String, oDocumento.CodDocumentoFinal);
            Db.AddInParameter(dbCmd, "Cod_Tipo", DbType.String, oDocumento.Cod_Tipo);
            Db.AddInParameter(dbCmd, "Titulo", DbType.String, oDocumento.Titulo);
            Db.AddInParameter(dbCmd, "Descripcion", DbType.String, oDocumento.Descripcion);
            Db.AddInParameter(dbCmd, "BinArchivo", DbType.Boolean, oDocumento.BinArchivo);
            Db.AddInParameter(dbCmd, "ResumenDescripcion", DbType.String, oDocumento.ResumenDescripcion);
            Db.AddInParameter(dbCmd, "Nombre_Archivo", DbType.String, oDocumento.Nombre_Archivo);
            Db.AddInParameter(dbCmd, "Vistas", DbType.Int32, oDocumento.Vistas);
            Db.AddInParameter(dbCmd, "TipoDocumento", DbType.String, oDocumento.TipoDocumento);
            Db.AddInParameter(dbCmd, "DetalleCambios", DbType.String, oDocumento.DetalleCambios);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oDocumento.Estado);
            Db.AddInParameter(dbCmd, "UsuarioCrea", DbType.String, oDocumento.UsuarioCrea);
            Db.AddInParameter(dbCmd, "FechaCrea", DbType.DateTime, oDocumento.FechaCrea);
            Db.AddInParameter(dbCmd, "UsuarioModif", DbType.String, oDocumento.UsuarioModif);
            Db.AddInParameter(dbCmd, "FechaModif", DbType.DateTime, oDocumento.FechaModif);
            Db.AddInParameter(dbCmd, "EstadoAprob", DbType.String, oDocumento.EstadoAprob);
            Db.AddInParameter(dbCmd, "CodPlantilla", DbType.String, oDocumento.CodPlantilla);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodDocumento, Int16 Version)
        {
            return Db.ExecuteNonQuery("Global.Documento_Eliminar",CodDocumento,Version);
        }
        
        public virtual CDocumento Recuperar(String CodDocumento, Int16 Version)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Recuperar",CodDocumento,Version).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getDocumento(dtDatos.Rows[0]);
            else
            return new CDocumento();
        }
        
        public virtual bool Existe(String CodDocumento, Int16 Version)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Recuperar",CodDocumento,Version).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodDocumento, Int16 Version, out CDocumento oDocumento)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Documento_Recuperar",CodDocumento,Version).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oDocumento = getDocumento(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oDocumento = new CDocumento();
            return false;
            }
        }
        
        public virtual IList<CDocumento> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.Documento_Listar")){
            IList<CDocumento> list = new List<CDocumento>();
            while (dr.Read())
            list.Add(getDocumento(dr));
            return list;
            }
        }
        public virtual string MaxDocumento()
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.MaxDocumento").Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                DataRow dr = dtDatos.Rows[0];
                return Convert.ToString(dr["MaxDocumento"]);
            }
            else
                return "";
        }
        #endregion
    }
}
