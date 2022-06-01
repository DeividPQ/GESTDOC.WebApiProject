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
    public partial class CPersona
    {
        
        [DataMember()]
        public String CodPersona {get;set;}
        
        [DataMember()]
        public String Nombres {get;set;}
        
        [DataMember()]
        public String Apellido_Paterno {get;set;}
        
        [DataMember()]
        public String Apellido_Materno {get;set;}
        
        [DataMember()]
        public String Nro_Doc_Iden {get;set;}
        
        [DataMember()]
        public String Direccion {get;set;}
        
        [DataMember()]
        public Char Sexo {get;set;}
        
        [DataMember()]
        public String Obs_Persona {get;set;}
        
        [DataMember()]
        public String Telefono {get;set;}
        
        [DataMember()]
        public String Email {get;set;}
        
        [DataMember()]
        public String CodArea {get;set;}
        
        [DataMember()]
        public String Cargo {get;set;}
        
        [DataMember()]
        public Char Estado {get;set;}
        
        [DataMember()]
        public String UserNew {get;set;}
        
        [DataMember()]
        public String UserEdit {get;set;}
        
        [DataMember()]
        public DateTime DateNew {get;set;}
        
        [DataMember()]
        public DateTime DateEdit {get;set;}
        
        #region Constructores
        // Constructores
        public CPersona()
        {
        }
        
        public CPersona(
                    String CodPersona_, 
                    String Nombres_, 
                    String Apellido_Paterno_, 
                    String Apellido_Materno_, 
                    String Nro_Doc_Iden_, 
                    String Direccion_, 
                    Char Sexo_, 
                    String Obs_Persona_, 
                    String Telefono_, 
                    String Email_, 
                    String CodArea_, 
                    String Cargo_, 
                    Char Estado_, 
                    String UserNew_, 
                    String UserEdit_, 
                    DateTime DateNew_, 
                    DateTime DateEdit_)
        {
            CodPersona = CodPersona_;
            Nombres = Nombres_;
            Apellido_Paterno = Apellido_Paterno_;
            Apellido_Materno = Apellido_Materno_;
            Nro_Doc_Iden = Nro_Doc_Iden_;
            Direccion = Direccion_;
            Sexo = Sexo_;
            Obs_Persona = Obs_Persona_;
            Telefono = Telefono_;
            Email = Email_;
            CodArea = CodArea_;
            Cargo = Cargo_;
            Estado = Estado_;
            UserNew = UserNew_;
            UserEdit = UserEdit_;
            DateNew = DateNew_;
            DateEdit = DateEdit_;
        }
        #endregion
    }
}
