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
    public partial class CPersonaXAr
    {
        [DataMember()]
        public String CodPersona { get; set; }

        [DataMember()]
        public String NombresAp { get; set; }

        [DataMember()]
        public String CodArea { get; set; }

        [DataMember()]
        public String Nom_Area { get; set; }

        CPersonaXAr()
        { }

        public CPersonaXAr(String CodPersona_, String NombresAp_, String CodArea_, String Nom_Area_)
        {
            CodPersona = CodPersona_;
            NombresAp = NombresAp_;
            CodArea = CodArea_;
            Nom_Area = Nom_Area_;
        }
    }
}
