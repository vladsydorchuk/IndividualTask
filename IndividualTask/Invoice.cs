//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IndividualTask
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Invoice()
        {
            this.InvoicePayment = new HashSet<InvoicePayment>();
            this.InvoiceProduct = new HashSet<InvoiceProduct>();
        }
    
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public System.Guid AccountId { get; set; }
        public System.Guid ContactId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<System.Guid> StatusId { get; set; }
        public Nullable<System.Guid> OwnerId { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Contact Contact { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoicePayment> InvoicePayment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceProduct> InvoiceProduct { get; set; }
        public virtual Contact ContactOwner { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
    }
}
