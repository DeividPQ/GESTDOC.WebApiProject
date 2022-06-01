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
    public partial class CArea
    {
        
        [DataMember()]
        public String CodArea {get;set;}
        
        [DataMember()]
        public String Acronimo {get;set;}
        
        [DataMember()]
        public String Nom_Area {get;set;}
        
        [DataMember()]
        public Char Tipo {get;set;}
        
        [DataMember()]
        public String CodParent {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public DateTime FechaCrea {get;set;}
        
        [DataMember()]
        public String UsuarioCrea {get;set;}
        
        [DataMember()]
        public String UsuarioModif {get;set;}
        
        [DataMember()]
        public DateTime FechaModif {get;set;}
        
        #region Constructores
        // Constructores
        public CArea()
        {
        }
        
        public CArea(String CodArea_, String Acronimo_, String Nom_Area_, Char Tipo_, String CodParent_, Char Estado_, DateTime FechaCrea_, String UsuarioCrea_, String UsuarioModif_, DateTime FechaModif_)
        {
            CodArea = CodArea_;
            Acronimo = Acronimo_;
            Nom_Area = Nom_Area_;
            Tipo = Tipo_;
            CodParent = CodParent_;
            Estado = Estado_;
            FechaCrea = FechaCrea_;
            UsuarioCrea = UsuarioCrea_;
            UsuarioModif = UsuarioModif_;
            FechaModif = FechaModif_;
        }
        #endregion
    }
}
