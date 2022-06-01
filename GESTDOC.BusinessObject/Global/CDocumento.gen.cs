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
    public partial class CDocumento
    {
        
        [DataMember()]
        public String CodDocumento {get;set;}
        
        [DataMember()]
        public Int16 Version {get;set;}
        
        [DataMember()]
        public String CodPersona {get;set;}
        
        [DataMember()]
        public String CodArea {get;set;}
        
        [DataMember()]
        public String CodDocumentoFinal { get;set;}
        
        [DataMember()]
        public String Cod_Tipo {get;set;}
        
        [DataMember()]
        public String Titulo {get;set;}
        
        [DataMember()]
        public String Descripcion {get;set;}
        
        [DataMember()]
        public Boolean BinArchivo {get;set;}
        
        [DataMember()]
        public String ResumenDescripcion {get;set;}
        
        [DataMember()]
        public String Nombre_Archivo {get;set;}
        
        [DataMember()]
        public Int32 Vistas {get;set;}
        
        [DataMember()]
        public String TipoDocumento {get;set;}
        
        [DataMember()]
        public String DetalleCambios {get;set;}
        
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
        
        [DataMember()]
        public Char EstadoAprob {get;set;}
        
        [DataMember()]
        public String CodPlantilla {get;set;}
        
        #region Constructores
        // Constructores
        public CDocumento()
        {
        }
        
        public CDocumento(
                    String CodDocumento_, 
                    Int16 Version_, 
                    String CodPersona_, 
                    String CodArea_, 
                    String CodDocumentoFinal_, 
                    String Cod_Tipo_, 
                    String Titulo_, 
                    String Descripcion_, 
                    Boolean BinArchivo_, 
                    String ResumenDescripcion_, 
                    String Nombre_Archivo_, 
                    Int32 Vistas_, 
                    String TipoDocumento_, 
                    String DetalleCambios_, 
                    Char Estado_, 
                    String UsuarioCrea_, 
                    DateTime FechaCrea_, 
                    String UsuarioModif_, 
                    DateTime FechaModif_, 
                    Char EstadoAprob_, 
                    String CodPlantilla_)
        {
            CodDocumento = CodDocumento_;
            Version = Version_;
            CodPersona = CodPersona_;
            CodArea = CodArea_;
            CodDocumentoFinal = CodDocumentoFinal_;
            Cod_Tipo = Cod_Tipo_;
            Titulo = Titulo_;
            Descripcion = Descripcion_;
            BinArchivo = BinArchivo_;
            ResumenDescripcion = ResumenDescripcion_;
            Nombre_Archivo = Nombre_Archivo_;
            Vistas = Vistas_;
            TipoDocumento = TipoDocumento_;
            DetalleCambios = DetalleCambios_;
            Estado = Estado_;
            UsuarioCrea = UsuarioCrea_;
            FechaCrea = FechaCrea_;
            UsuarioModif = UsuarioModif_;
            FechaModif = FechaModif_;
            EstadoAprob = EstadoAprob_;
            CodPlantilla = CodPlantilla_;
        }
        #endregion
    }
}
