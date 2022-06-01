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
    public partial class CAcceso_Perfil
    {
        
        [DataMember()]
        public String Cod_Acceso {get;set;}
        
        [DataMember()]
        public String Cod_Perfil {get;set;}
        
        #region Constructores
        // Constructores
        public CAcceso_Perfil()
        {
        }
        
        public CAcceso_Perfil(String Cod_Acceso_, String Cod_Perfil_)
        {
            Cod_Acceso = Cod_Acceso_;
            Cod_Perfil = Cod_Perfil_;
        }
        #endregion
    }
}
