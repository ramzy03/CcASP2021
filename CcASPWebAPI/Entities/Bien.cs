//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CcASPWebAPI.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bien
    {
        public decimal IdBien { get; set; }
        public System.DateTime DateCreationBien { get; set; }
        public string NomBien { get; set; }
        public Nullable<decimal> IdPro { get; set; }
    
        public virtual Proprietaire Proprietaire { get; set; }
    }
}
