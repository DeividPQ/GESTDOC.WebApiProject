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
    public partial class CPerfil
    {
        
        [DataMember()]
        public String Cod_Perfil {get;set;}
        
        [DataMember()]
        public String Des_Perfil {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        #region Constructores
        // Constructores
        public CPerfil()
        {
        }
        
        public CPerfil(String Cod_Perfil_, String Des_Perfil_, Char Estado_)
        {
            Cod_Perfil = Cod_Perfil_;
            Des_Perfil = Des_Perfil_;
            Estado = Estado_;
        }
        #endregion
    }
}
