//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TecnicalService
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLFaturaDetay
    {
        public int ID { get; set; }
        public Nullable<int> Urun { get; set; }
        public Nullable<short> Adet { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public Nullable<int> FaturaID { get; set; }
    
        public virtual TBLUrun TBLUrun { get; set; }
    }
}
