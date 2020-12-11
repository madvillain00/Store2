using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Delivery")]
    public class Delivery
    {
        //public Delivery()
        //{
        //    this.Provider_Deliveries = new List<Provider_Delivery>();
        //}
        [Key]
        
        public int DeliveryID { get; set; }
        //[Required]
        public string DataOfDelivery { get; set; }
        public int SumOfDelivery { get; set; }
        public int CountOfDellivery { get; set; }
        //[Required]
        public virtual ICollection<Provider_Delivery> Provider_Deliveries { get; set; }
    }
}