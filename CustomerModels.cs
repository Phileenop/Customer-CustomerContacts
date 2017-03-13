using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerContactManager.Models
{
    public class Customer
    {
        public Customer()
        {
            this.ContactList = new List<CustomerContact>();
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Longitude { get; set; }
        [Required]
        public string Latitude { get; set; }
        [Required]
        public List<CustomerContact> ContactList { get; set; }
    }
}