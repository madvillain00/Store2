using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Store2.Models
{
    
    public class Provider
    {
        
        [Key]
        
        public int ProviderID { get; set; }
        //[Required]
        public string NameOfOrgfnization { get; set; }
        public string NameOfProducts { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        public virtual ICollection<Provider_Delivery> Provider_Deliveries { get; set; }
    }
}