using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTDOC.BusinessObjects.Global
{
    public partial class CArchivoProcesar
    {
        public IFormFile Files { get; set; }
        public String Name { get; set; }

        public CArchivoProcesar()
        { }

        public CArchivoProcesar(IFormFile Files_, String Name_)
        {
            Files= Files_;
            Name = Name_;
        }
    }
}
