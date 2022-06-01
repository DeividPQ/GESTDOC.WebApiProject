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

namespace GESTDOC.BusinessObjects.Global
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CTabla
    {
        
        [DataMember()]
        public String Cod_Tabla {get;set;}
        
        [DataMember()]
        public String Nom_Tabla {get;set;}
        
        [DataMember()]
        public String Cod_Padre {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String Des_Tabla {get;set;}
        
        #region Constructores
        // Constructores
        public CTabla()
        {
        }
        
        public CTabla(String Cod_Tabla_, String Nom_Tabla_, String Cod_Padre_, Char Estado_, String Des_Tabla_)
        {
            Cod_Tabla = Cod_Tabla_;
            Nom_Tabla = Nom_Tabla_;
            Cod_Padre = Cod_Padre_;
            Estado = Estado_;
            Des_Tabla = Des_Tabla_;
        }
        #endregion
    }
}
