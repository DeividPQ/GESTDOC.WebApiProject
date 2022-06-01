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

namespace GESTDOC.BusinessObjects.Config
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CConfiguracion_Usuario
    {
        
        [DataMember()]
        public String Cod_Usuario {get;set;}
        
        [DataMember()]
        public String Nombre_Variable {get;set;}
        
        [DataMember()]
        public String Valor_Variable {get;set;}
        
        #region Constructores
        // Constructores
        public CConfiguracion_Usuario()
        {
        }
        
        public CConfiguracion_Usuario(String Cod_Usuario_, String Nombre_Variable_, String Valor_Variable_)
        {
            Cod_Usuario = Cod_Usuario_;
            Nombre_Variable = Nombre_Variable_;
            Valor_Variable = Valor_Variable_;
        }
        #endregion
    }
}
