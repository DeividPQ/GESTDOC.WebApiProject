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
    
    
    public partial class PersonaDao : DataAccessBase
    {
        
        public virtual CPersona getPersona(DataRow dr)
        {
            return new CPersona(Convert.ToString(dr["CodPersona"]),Convert.ToString(dr["Nombres"]),Convert.ToString(dr["Apellido_Paterno"]),Convert.ToString(dr["Apellido_Materno"]),Convert.ToString(dr["Nro_Doc_Iden"]),Convert.ToString(dr["Direccion"]),Convert.ToChar(dr["Sexo"]),Convert.ToString(dr["Obs_Persona"]),Convert.ToString(dr["Telefono"]),Convert.ToString(dr["Email"]),Convert.ToString(dr["CodArea"]),Convert.ToString(dr["Cargo"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UserNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        public virtual CPersona getPersona(IDataReader dr)
        {
            return new CPersona(Convert.ToString(dr["CodPersona"]),Convert.ToString(dr["Nombres"]),Convert.ToString(dr["Apellido_Paterno"]),Convert.ToString(dr["Apellido_Materno"]),Convert.ToString(dr["Nro_Doc_Iden"]),Convert.ToString(dr["Direccion"]),Convert.ToChar(dr["Sexo"]),Convert.ToString(dr["Obs_Persona"]),Convert.ToString(dr["Telefono"]),Convert.ToString(dr["Email"]),Convert.ToString(dr["CodArea"]),Convert.ToString(dr["Cargo"]),Convert.ToChar(dr["Estado"]),Convert.ToString(dr["UserNew"]),Convert.ToString(dr["UserEdit"]),Convert.ToDateTime(dr["DateNew"]),Convert.ToDateTime(dr["DateEdit"]));
        }
        
        #region Metodos Principales
        public virtual bool Grabar(CPersona oPersona)
        {
            using (DbCommand dbCmd = Db.GetStoredProcCommand("Global.Persona_Guardar")){
            Db.AddInParameter(dbCmd, "CodPersona", DbType.String, oPersona.CodPersona);
            Db.AddInParameter(dbCmd, "Nombres", DbType.String, oPersona.Nombres);
            Db.AddInParameter(dbCmd, "Apellido_Paterno", DbType.String, oPersona.Apellido_Paterno);
            Db.AddInParameter(dbCmd, "Apellido_Materno", DbType.String, oPersona.Apellido_Materno);
            Db.AddInParameter(dbCmd, "Nro_Doc_Iden", DbType.String, oPersona.Nro_Doc_Iden);
            Db.AddInParameter(dbCmd, "Direccion", DbType.String, oPersona.Direccion);
            Db.AddInParameter(dbCmd, "Sexo", DbType.String, oPersona.Sexo);
            Db.AddInParameter(dbCmd, "Obs_Persona", DbType.String, oPersona.Obs_Persona);
            Db.AddInParameter(dbCmd, "Telefono", DbType.String, oPersona.Telefono);
            Db.AddInParameter(dbCmd, "Email", DbType.String, oPersona.Email);
            Db.AddInParameter(dbCmd, "CodArea", DbType.String, oPersona.CodArea);
            Db.AddInParameter(dbCmd, "Cargo", DbType.String, oPersona.Cargo);
            Db.AddInParameter(dbCmd, "Estado", DbType.String, oPersona.Estado);
            Db.AddInParameter(dbCmd, "UserNew", DbType.String, oPersona.UserNew);
            Db.AddInParameter(dbCmd, "UserEdit", DbType.String, oPersona.UserEdit);
            Db.AddInParameter(dbCmd, "DateNew", DbType.DateTime, oPersona.DateNew);
            Db.AddInParameter(dbCmd, "DateEdit", DbType.DateTime, oPersona.DateEdit);
            // --- Ejecutando procedimiento almacenado
            return Db.ExecuteNonQuery(dbCmd) > 0;
            } 
        }
        
        public virtual int Eliminar(String CodPersona)
        {
            return Db.ExecuteNonQuery("Global.Persona_Eliminar",CodPersona);
        }
        
        public virtual CPersona Recuperar(String CodPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Persona_Recuperar",CodPersona).Tables[0];
            if (dtDatos.Rows.Count > 0)
            return getPersona(dtDatos.Rows[0]);
            else
            return new CPersona();
        }
        
        public virtual bool Existe(String CodPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Persona_Recuperar",CodPersona).Tables[0];
            return dtDatos.Rows.Count > 0;
        }
        
        public virtual bool Existe(String CodPersona, out CPersona oPersona)
        {
            DataTable dtDatos = Db.ExecuteDataSet("Global.Persona_Recuperar",CodPersona).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
            oPersona = getPersona(dtDatos.Rows[0]);
            return true;
             }
            else
            {
            oPersona = new CPersona();
            return false;
            }
        }
        
        public virtual IList<CPersona> Listar()
        {
            using (IDataReader dr = Db.ExecuteReader(CommandType.StoredProcedure,"Global.Persona_Listar")){
            IList<CPersona> list = new List<CPersona>();
            while (dr.Read())
            list.Add(getPersona(dr));
            return list;
            }
        }
        #endregion
    }
}
