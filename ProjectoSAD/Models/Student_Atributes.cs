//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectoSAD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Atributes
    {
        public string AtributeValue { get; set; }
        public int AtributesId { get; set; }
        public string Id { get; set; }
    
        public virtual Atributes Atributes { get; set; }
        public virtual Student Student { get; set; }
    }
}