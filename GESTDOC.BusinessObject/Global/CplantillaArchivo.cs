using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace GESTDOC.BusinessObjects.Global
{


    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CplantillaArchivo
    {

        [DataMember()]
        public String CodPlantilla { get; set; }

        [DataMember()]
        public String Des_Plantilla { get; set; }

        [DataMember()]
        public String Titulo { get; set; }

        [DataMember()]
        public IFormFile Files { get; set; }

        [DataMember()]
        public byte[] BinArchivo { get; set; }

        [DataMember()]
        public String Nombre_Archivo { get; set; }

        [DataMember()]
        public Char Estado { get; set; }

        [DataMember()]
        public String UsuarioCrea { get; set; }

        [DataMember()]
        public String UsuarioModif { get; set; }

        #region Constructores
        // Constructores
        public CplantillaArchivo()
        {
        }

        public CplantillaArchivo(String CodPlantilla_, String Des_Plantilla_, String Titulo_, IFormFile Files_, byte[] BinArchivo_, String Nombre_Archivo_, Char Estado_, String UsuarioCrea_, String UsuarioModif_)
        {
            CodPlantilla = CodPlantilla_;
            Des_Plantilla = Des_Plantilla_;
            Titulo = Titulo_;
            Files = Files_;
            BinArchivo = BinArchivo_;
            Nombre_Archivo = Nombre_Archivo_;
            Estado = Estado_;
            UsuarioCrea = UsuarioCrea_;
            UsuarioModif = UsuarioModif_;
        }
        #endregion
    }
}