//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OtelYeniProje.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblKasa
    {
        public int KasaID { get; set; }
        public string KasaAdi { get; set; }
        public Nullable<decimal> Bakiye { get; set; }
        public Nullable<decimal> Giren { get; set; }
        public Nullable<decimal> Çıkan { get; set; }
        public Nullable<int> Durum { get; set; }
    
        public virtual TblDurum TblDurum { get; set; }
    }
}
