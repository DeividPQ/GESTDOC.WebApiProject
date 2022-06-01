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
    public partial class CDocumento_Aprob
    {
        
        [DataMember()]
        public Int16 Version {get;set;}
        
        [DataMember()]
        public String CodDocumento {get;set;}
        
        [DataMember()]
        public Int16 Nivel {get;set;}
        
        [DataMember()]
        public Char EstadoAprob {get;set;}
        
        [DataMember()]
        public String UsuarioCrea {get;set;}
        
        [DataMember()]
        public DateTime FechaCrea {get;set;}
        
        [DataMember()]
        public String UsuarioModif {get;set;}
        
        [DataMember()]
        public DateTime FechaModif {get;set;}
        
        [DataMember()]
        public String CodAprobador {get;set;}
        
        #region Constructores
        // Constructores
        public CDocumento_Aprob()
        {
        }
        
        public CDocumento_Aprob(Int16 Version_, String CodDocumento_, Int16 Nivel_, Char EstadoAprob_, String UsuarioCrea_, DateTime FechaCrea_, String UsuarioModif_, DateTime FechaModif_, String CodAprobador_)
        {
            Version = Version_;
            CodDocumento = CodDocumento_;
            Nivel = Nivel_;
            EstadoAprob = EstadoAprob_;
            UsuarioCrea = UsuarioCrea_;
            FechaCrea = FechaCrea_;
            UsuarioModif = UsuarioModif_;
            FechaModif = FechaModif_;
            CodAprobador = CodAprobador_;
        }
        #endregion
    }
}
