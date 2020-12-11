using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Store2.Models
{
    
    public class Client
    {
        [Key]
        
        public int ClientID { get; set; }
        //[Required]
        public string NameOfClient { get; set; }
        public string AddressOfClient { get; set; }
        public string PhoneOfClient { get; set; }
        public string EmailOfClient { get; set; }
    }
}