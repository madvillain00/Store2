using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Product")]
    public class Product
    {
        //public Product()
        //{
        //    this.Product_Orders = new HashSet<Product_Order>();
        //}
        [Key, Column(Order = 0)]
        ////[ForeignKey("Product")]
        //[Key]
        public int ProductID { get; set; }
        //[Key]//, Column(Order = 8)]
        //[ForeignKey("Delivery")]
        //[ForeignKey("Delivery")]
        [Key,Column(Order = 1)]
        public int DeliveryID { get; set; }
        //[Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string ShelfLife { get; set; }
        public int CountInStore { get; set; }

        //[Required]
        public virtual Delivery Delivery { get; set; }
        //[Required]

        public virtual ICollection<Product_Order> Product_Orders { get; set; }

    }
}