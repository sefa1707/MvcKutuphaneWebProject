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
    
    public partial class TblHareket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblHareket()
        {
            this.TblCeza = new HashSet<TblCeza>();
        }
    
        public int HareketID { get; set; }
        public Nullable<int> HareketKitap { get; set; }
        public Nullable<int> HareketUye { get; set; }
        public Nullable<int> HareketPersonel { get; set; }
        public Nullable<System.DateTime> HareketAlisTarihi { get; set; }
        public Nullable<System.DateTime> HareketiadeTarihi { get; set; }
        public Nullable<System.DateTime> HareketVerilisTarihi { get; set; }
        public Nullable<bool> HareketDurum { get; set; }
        public string HareketAciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblCeza> TblCeza { get; set; }
        public virtual TblKitap TblKitap { get; set; }
        public virtual TblPersonel TblPersonel { get; set; }
        public virtual TblUye TblUye { get; set; }
    }
}