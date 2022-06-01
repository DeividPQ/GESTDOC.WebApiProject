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
    public partial class CPlantilla
    {
        
        [DataMember()]
        public String CodPlantilla {get;set;}
        
        [DataMember()]
        public String Des_Plantilla {get;set;}
        
        [DataMember()]
        public String Titulo {get;set;}

        [DataMember()]
        public byte[] BinArchivo {get;set;}
        
        [DataMember()]
        public String Nombre_Archivo {get;set;}
        
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
        public CPlantilla()
        {
        }
        
        public CPlantilla(String CodPlantilla_, String Des_Plantilla_, String Titulo_, byte[] BinArchivo_, String Nombre_Archivo_, Char Estado_, String UsuarioCrea_, DateTime FechaCrea_, String UsuarioModif_, DateTime FechaModif_)
        {
            CodPlantilla = CodPlantilla_;
            Des_Plantilla = Des_Plantilla_;
            Titulo = Titulo_;
            BinArchivo = BinArchivo_;
            Nombre_Archivo = Nombre_Archivo_;
            Estado = Estado_;
            UsuarioCrea = UsuarioCrea_;
            FechaCrea = FechaCrea_;
            UsuarioModif = UsuarioModif_;
            FechaModif = FechaModif_;
        }
        #endregion
    }
}
