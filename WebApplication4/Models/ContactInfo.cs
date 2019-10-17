using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }
        public Name name { get; set; }
        public Address address { get; set; }
        public List<Phone> phone { get; set; }
        public string email { get; set; }

    }

    public class Name
    {
        public string First { get; set; }
        public string Middle { get; set; }
        public string Last { get; set; }
    }

    public class Address
    {
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }

    public class Phone
    {
        public string number { get; set; }
        public string type { get; set; }
    }

}