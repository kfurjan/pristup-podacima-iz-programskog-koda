//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ORM
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Service
    {
        public int IDService { get; set; }
        public string Description { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> CarID { get; set; }
    
        public virtual Car Car { get; set; }

        public override string ToString() => $"{Date.ToString()} {Description}";
    }
}