//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace main
{
    using System;
    using System.Collections.Generic;
    
    public partial class CustomerProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerProduct()
        {
            this.Bills = new HashSet<Bill>();
        }
    
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public int CustomerPhone { get; set; }
        public string typeproduct { get; set; }
        public int Customer_ID { get; set; }
    
        public virtual Customer Customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill> Bills { get; set; }
        accessContext context=new accessContext();
        public bool update(int id, string product, int CPhone, int quantity, string typeproduct, int idcust)
        {
            try
            {
                CustomerProduct dataobject = new CustomerProduct() { ID = id, ProductName = product, CustomerPhone = CPhone, Quantity = quantity, typeproduct = typeproduct, Customer_ID = idcust };
                context.CustomerProducts.Attach(dataobject);
                context.Entry(dataobject).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
