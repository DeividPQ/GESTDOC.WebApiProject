using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GESTDOC.BusinessObjects.Global
{

    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CCertificaciones
    {
        
        [DataMember()]
        public String Cod_Certificacion { get; set; }

        [DataMember()]
        public String Descripcion { get; set; }

        [DataMember()]
        public Char Estado { get; set; }

        #region Constructores
        // Constructores
        public CCertificaciones()
        {
        }

        public CCertificaciones(String Cod_Certificacion_, String Descripcion_, Char Estado_)
        {
            Cod_Certificacion = Cod_Certificacion_;
            Descripcion = Descripcion_;
            Estado = Estado_;
        }
        #endregion
    }
}