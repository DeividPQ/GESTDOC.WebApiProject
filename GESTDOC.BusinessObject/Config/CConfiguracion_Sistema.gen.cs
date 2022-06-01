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
    public partial class CConfiguracion_Sistema
    {
        
        [DataMember()]
        public String Variable {get;set;}
        
        [DataMember()]
        public String Valor_Variable {get;set;}
        
        #region Constructores
        // Constructores
        public CConfiguracion_Sistema()
        {
        }
        
        public CConfiguracion_Sistema(String Variable_, String Valor_Variable_)
        {
            Variable = Variable_;
            Valor_Variable = Valor_Variable_;
        }
        #endregion
    }
}
