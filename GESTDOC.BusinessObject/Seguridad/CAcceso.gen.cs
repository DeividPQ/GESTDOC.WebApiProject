//------------------------------------------------------------------------------
// <Auto Generado: BSClassGenerator V2.0>
//     Generado por BRAIN SYSTEMS S.R.L.
//     Fecha: martes, 17 de mayo de 2022
// </Auto Generado>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GESTDOC.BusinessObjects.Seguridad
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CAcceso
    {
        
        [DataMember()]
        public String Cod_Acceso {get;set;}
        
        [DataMember()]
        public String Nombre_Acceso {get;set;}
        
        [DataMember()]
        public String Descripcion {get;set;}
        
        [DataMember()]
        public String Comando {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String Imagen {get;set;}
        
        [DataMember()]
        public Int16 Nivel {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso()
        {
        }
        
        public CAcceso(String Cod_Acceso_, String Nombre_Acceso_, String Descripcion_, String Comando_, Char Estado_, String Imagen_, Int16 Nivel_)
        {
            Cod_Acceso = Cod_Acceso_;
            Nombre_Acceso = Nombre_Acceso_;
            Descripcion = Descripcion_;
            Comando = Comando_;
            Estado = Estado_;
            Imagen = Imagen_;
            Nivel = Nivel_;
        }
        #endregion
    }
}
