using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GESTDOC.BusinessObjects.Global
{

    [DataContract()]
    [Serializable()]
    public partial class CAprobador_X_Area
    {
        [DataMember()]
        public String CodArea { get; set; }

        [DataMember()]
        public String Nom_Area { get; set; }

        [DataMember()]
        public String Cod_Tipo { get; set; }

        [DataMember()]
        public String Des_Tipo { get; set; }

        [DataMember()]
        public int Nivel { get; set; }

        [DataMember()]
        public string NombresAp { get; set; }

        [DataMember()]
        public Char Estado { get; set; }

        CAprobador_X_Area()
        { }

        public CAprobador_X_Area(String CodArea_, String Nom_Area_, String Cod_Tipo_, String Des_Tipo_, int Nivel_, String NombresAp_,Char Estado_)
        {
            CodArea = CodArea_;
            Nom_Area = Nom_Area_;
            Cod_Tipo = Cod_Tipo_;
            Des_Tipo = Des_Tipo_;
            Nivel = Nivel_;
            NombresAp = NombresAp_;
            Estado = Estado_;
        }
    }
}
