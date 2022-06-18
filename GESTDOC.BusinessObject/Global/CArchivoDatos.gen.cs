using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTDOC.BusinessObjects.Global
{
    public partial class CArchivoDatos
    {
        public string NombreArchivo { get; set; }
        public String CodigoFinal { get; set; }
        public String Version { get; set; }
        public String Cod_Area { get; set; }
        public String Cod_TipoDocumento { get; set; }
        public Byte[] ArchivoBinary { get; set; }
        public CArchivoDatos()
        {

        }

        public CArchivoDatos(string nombreArchivo_, string codigoFinal_, string version_, string cod_Area_, string cod_TipoDocumento_, byte[] archivoBinary_)
        {
            NombreArchivo = nombreArchivo_;
            CodigoFinal = codigoFinal_;
            Version = version_;
            Cod_Area = cod_Area_;
            Cod_TipoDocumento = cod_TipoDocumento_;
            ArchivoBinary = archivoBinary_;
        }
    }
}
