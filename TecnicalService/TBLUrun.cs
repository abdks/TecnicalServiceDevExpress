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
    
    public partial class TBLUrun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLUrun()
        {
            this.TBLFaturaDetay = new HashSet<TBLFaturaDetay>();
            this.TBLUrunKabul = new HashSet<TBLUrunKabul>();
            this.TBLUrunTakip = new HashSet<TBLUrunTakip>();
        }
    
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Marka { get; set; }
        public Nullable<decimal> AlısFiyat { get; set; }
        public Nullable<decimal> SatisFiyat { get; set; }
        public Nullable<short> Stok { get; set; }
        public Nullable<byte> Kategori { get; set; }
        public Nullable<bool> Durum { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLFaturaDetay> TBLFaturaDetay { get; set; }
        public virtual TBLKategori TBLKategori { get; set; }
        public virtual TBLUrunHareket TBLUrunHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUrunKabul> TBLUrunKabul { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLUrunTakip> TBLUrunTakip { get; set; }
    }
}
