//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Komentarz
    {
        public int IDkomentarz { get; set; }
        public int IDmieszkanie { get; set; }
        public int IDuzytkownik { get; set; }
        public System.DateTime Data { get; set; }
        public string Tresc { get; set; }
        public Nullable<decimal> Ocena { get; set; }
    
        public virtual Mieszkanie Mieszkanie { get; set; }
        public virtual Uzytkownik Uzytkownik { get; set; }
    }
}
