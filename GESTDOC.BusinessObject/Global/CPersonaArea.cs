using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace GESTDOC.BusinessObjects.Global
{
    [DataContract()]
    [Serializable()]
    public partial class CPersonaArea
    {
        [DataMember()]
        public String CodPersona { get; set; }

        [DataMember()]
        public String NombresAp { get; set; }

        [DataMember()]
        public String CodArea { get; set; }

        [DataMember()]
        public String Nom_Area { get; set; }

        [DataMember()]
        public String Nivel { get; set; }
        CPersonaArea()
        { }

        public CPersonaArea(String CodPersona_, String NombresAp_, String CodArea_, String Nom_Area_,String Nivel_)
        {
            CodPersona = CodPersona_;
            NombresAp = NombresAp_;
            CodArea = CodArea_;
            Nom_Area = Nom_Area_;
            Nivel = Nivel_;
        }
    }
}
