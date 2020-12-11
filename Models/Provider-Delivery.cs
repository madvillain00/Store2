using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Provider_Delivery")]
    public class Provider_Delivery
    {
        [Key, Column(Order = 0)]
        public int Provider_DeliveryID { get; set; }

        //[ForeignKey("Delivery")]
        [Key, Column(Order = 1)]
        
        public int DeliveryID { get; set; }

        //[ForeignKey("Provider")]
        [Key, Column(Order = 2)]
        //[ForeignKey("Provider")]
        public int ProviderID { get; set; }
        

        //[Required]
        
        public virtual Provider Provider { get; set; }
        //[Required]
        public virtual Delivery Delivery { get; set; }
    }
}