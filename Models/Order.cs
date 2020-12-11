using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    //[Table("Order")]
    public class Order
    {
        //public Order()
        //{
        //    this.Product_Orders = new HashSet<Product_Order>();
        //}
        [Key,Column(Order = 0)]
        //// [ForeignKey("Order")]
        public int OrderID { get; set; }

        //[ForeignKey("Client")]
        [Key, Column(Order = 1)]
        public int ClientID { get; set; }

        //[ForeignKey("Employee")]
        [Key, Column(Order = 2)]
        public int EmployeeID { get; set; }
        //[Required]
        public string DataOfOrder { get; set; }
        public int CountOfProduct { get; set; }
        //[Required]
        public virtual ICollection<Product_Order> Product_Orders { get; set; }
        //[/*Required]*/
        public virtual Employee Employee { get; set; }
        //[Required]
        public virtual Client Client { get; set; }

    }
}