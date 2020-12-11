using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Product_Order")]
    public class Product_Order
    {
        [Key,Column(Order = 0)]
        
        public int Product_OrderID { get; set; }
        //[ForeignKey("Order")]
        [Key,Column(Order = 1)]
        public int OrderID { get; set; }
        //[ForeignKey("Product")]
        [Key, Column(Order = 2)]
        public int ProductID { get; set; }

        //[Required]
        public virtual Product Product { get; set; }
        //[Required]
        public virtual Order Order { get; set; }
    }
}