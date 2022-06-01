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

namespace GESTDOC.BusinessObjects.Historial
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CDocumento_Final
    {
        
        [DataMember()]
        public Int32 IDDoc_Final {get;set;}
        
        [DataMember()]
        public String CodDocumento {get;set;}
        
        [DataMember()]
        public Int16 Version {get;set;}

        [DataMember()]
        public String Titulo { get; set; }

        [DataMember()]
        public String Descripcion {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        [DataMember()]
        public String Nombre_Archivo { get; set; }

        [DataMember()]
        public String Ruta_Almacenamiento { get; set; }

        [DataMember()]
        public DateTime FechaCrea {get;set;}
        
        [DataMember()]
        public String UsuarioCrea {get;set;}
        
        [DataMember()]
        public DateTime FechaModif {get;set;}
        
        [DataMember()]
        public String UsuarioModif {get;set;}
        
        
        #region Constructores
        // Constructores
        public CDocumento_Final()
        {
        }
        
        public CDocumento_Final(Int32 IDDoc_Final_, String CodDocumento_, Int16 Version_, String _Titulo, String Descripcion_, Char Estado_, String Nombre_Archivo_, String Ruta_Almacenamiento_, DateTime FechaCrea_, String UsuarioCrea_, DateTime FechaModif_, String UsuarioModif_)
        {
            IDDoc_Final = IDDoc_Final_;
            CodDocumento = CodDocumento_;
            Version = Version_;
            Titulo = _Titulo;
            Descripcion = Descripcion_;
            Estado = Estado_;
            Nombre_Archivo = Nombre_Archivo_;
            Ruta_Almacenamiento = Ruta_Almacenamiento_;
            FechaCrea = FechaCrea_;
            UsuarioCrea = UsuarioCrea_;
            FechaModif = FechaModif_;
            UsuarioModif = UsuarioModif_;       
        }
        #endregion
    }
}
