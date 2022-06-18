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
    public partial class CSistema_Gestion
    {
       
        [DataMember()]
        public String CodSist_Gest { get; set; }

        [DataMember()]
        public String Descripcion { get; set; }

        [DataMember()]
        public Char Estado { get; set; }

        #region Constructores
        // Constructores
        public CSistema_Gestion()
        {
        }

        public CSistema_Gestion(String CodSist_Gest_, String Descripcion_, Char Estado_)
        {
            CodSist_Gest = CodSist_Gest_;
            Descripcion = Descripcion_;
            Estado = Estado_;
        }
            #endregion
        }
}
