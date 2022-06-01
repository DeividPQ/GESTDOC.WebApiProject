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
    public partial class CAprobador_Area
    {
        
        [DataMember()]
        public String CodArea {get;set;}
        
        [DataMember()]
        public Int16 Nivel {get;set;}
        
        [DataMember()]
        public String CodAprobador {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String UsuarioCrea {get;set;}
        
        [DataMember()]
        public DateTime FechaCrea {get;set;}
        
        [DataMember()]
        public String UsuarioModif {get;set;}
        
        [DataMember()]
        public DateTime FechaModif {get;set;}
        
        #region Constructores
        // Constructores
        public CAprobador_Area()
        {
        }
        
        public CAprobador_Area(String CodArea_, Int16 Nivel_, String CodAprobador_, Char Estado_, String UsuarioCrea_, DateTime FechaCrea_, String UsuarioModif_, DateTime FechaModif_)
        {
            CodArea = CodArea_;
            Nivel = Nivel_;
            CodAprobador = CodAprobador_;
            Estado = Estado_;
            UsuarioCrea = UsuarioCrea_;
            FechaCrea = FechaCrea_;
            UsuarioModif = UsuarioModif_;
            FechaModif = FechaModif_;
        }
        #endregion
    }
}
