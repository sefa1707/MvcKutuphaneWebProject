//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcKutuphaneWebProject.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblYazar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblYazar()
        {
            this.TblKitap = new HashSet<TblKitap>();
        }
    
        public int YazarID { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public string YazarDetay { get; set; }
        public Nullable<bool> YazarDurum { get; set; }
        public Nullable<System.DateTime> YazarEklenmeTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblKitap> TblKitap { get; set; }
    }
}
