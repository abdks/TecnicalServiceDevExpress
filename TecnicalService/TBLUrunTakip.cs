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
    
    public partial class TBLUrunTakip
    {
        public int TakipID { get; set; }
        public Nullable<int> Urun { get; set; }
        public string Durum { get; set; }
        public Nullable<int> Tarih { get; set; }
        public string TakipKodu { get; set; }
    
        public virtual TBLUrun TBLUrun { get; set; }
    }
}
