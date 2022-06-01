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

namespace GESTDOC.BusinessObjects.Seguridad
{
    
    
    // Propiedades AutoImplementadas
    [DataContract()]
    [Serializable()]
    public partial class CUsuario
    {
        
        [DataMember()]
        public String Cod_Usuario {get;set;}
        
        [DataMember()]
        public String CodPersona {get;set;}
        
        [DataMember()]
        public String Cod_Perfil {get;set;}
        
        [DataMember()]
        public String Passwd {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String Nombre_Usuario {get;set;}
        
        [DataMember()]
        public String Email {get;set;}
        
        [DataMember()]
        public Boolean flagActDir {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        #region Constructores
        // Constructores
        public CUsuario()
        {
        }
        
        public CUsuario(String Cod_Usuario_, String CodPersona_, String Cod_Perfil_, String Passwd_, Char Estado_, String Nombre_Usuario_, String Email_, Boolean flagActDir_, String UserNew_, DateTime DateNew_, String UserEdit_, DateTime DateEdit_)
        {
            Cod_Usuario = Cod_Usuario_;
            CodPersona = CodPersona_;
            Cod_Perfil = Cod_Perfil_;
            Passwd = Passwd_;
            Estado = Estado_;
            Nombre_Usuario = Nombre_Usuario_;
            Email = Email_;
            flagActDir = flagActDir_;
            UserNew = UserNew_;
            DateNew = DateNew_;
            UserEdit = UserEdit_;
            DateEdit = DateEdit_;
        }
        #endregion
    }
}
