//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeferredObjectMaterialization.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductPaymentGateway
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PaymentGatewayId { get; set; }
    
        public virtual PaymentGateway PaymentGateway { get; set; }
        public virtual Product Product { get; set; }
    }
}
