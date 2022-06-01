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
    public partial class CTipo_Documento
    {
        
        [DataMember()]
        public String Cod_Tipo {get;set;}
        
        [DataMember()]
        public String Des_Tipo {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        #region Constructores
        // Constructores
        public CTipo_Documento()
        {
        }
        
        public CTipo_Documento(String Cod_Tipo_, String Des_Tipo_, Char Estado_)
        {
            Cod_Tipo = Cod_Tipo_;
            Des_Tipo = Des_Tipo_;
            Estado = Estado_;
        }
        #endregion
    }
}
