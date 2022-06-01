using System;
using System.Collections.Generic;
using System.Configuration;
using LibreriaBSNetCore.InfoApp;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace GESTDOC.DataObjectsNet
{
    public class DataAccessBase
    {

        #region Atributos
        public Database Db;

        #endregion

        public DataAccessBase()
        {
            // -- Capturando de conexion
            ProcesarConexion("Conexion");

            // --- Conectando a la base de datos
            Db = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(stringConexion);
        }


        /// <summary>
        /// Variable que almacenará el tipo de aplicación: Web, Windows
        /// </summary>


        private static string TipoAplicacion = ConfigurationManager.AppSettings.Get("TipoAplicacion");
        public static string varConexionWindows="";


        private static IConfiguration _configuration;
        static string Conexion;


        /// <summary>
        /// cadena de conexión del archivo json
        /// </summary>
        public static string stringConexion
        {
            get
            {
                return _configuration.GetConnectionString(Conexion);
            }
        }

        public static void ProcesarConexion(string NameConnection)
        {
            Conexion = NameConnection;

            // --- Obteniendo variables de configuración del archivo json
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            configurationBuilder.AddJsonFile(path, false);

            _configuration = configurationBuilder.Build();

            //string _sqlConnection = _configuration.GetConnectionString(NameConnection);

            //var appSetting = root.GetSection("ApplicationSettings");
            //var test = appSetting["Sample"];

        }

        public static AplicacionBS.TipoApp Tipo_Aplicacion
        {
            get
            {
                if (TipoAplicacion != null)
                {
                    if (TipoAplicacion.ToUpper() == "WEB")
                        return AplicacionBS.TipoApp.Web;
                    else if (TipoAplicacion.ToUpper() == "WINDOWS")
                        return AplicacionBS.TipoApp.Windows;
                    else
                        return AplicacionBS.TipoApp.Windows;
                }
                else
                    return AplicacionBS.TipoApp.Web;
            }
        }

        public static string getVarConexion()
        { 
            /// --- Dependiendo del tipo de aplicación recuperamos los parametros
            if (Tipo_Aplicacion == AplicacionBS.TipoApp.Web)
            {
                // --- Cogemos los valores de la variable de session Conexion                
                return "Conexion";

            }
            else
            { 
                // --- Cogemos la variable de acuerdo a la empresa selecta
                //     es decir de una conexion especifica
                return varConexionWindows;
            }
        }

    }
}
