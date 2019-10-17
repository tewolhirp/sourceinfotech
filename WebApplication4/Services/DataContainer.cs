using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.Services
{
    public class DataContainer
    {
        public static List<ContactInfo> contacts = new List<ContactInfo>();
        public DataContainer()
        {
            contacts.Add(new ContactInfo()
            {
                Id = 10,
                name = new Name
                {
                    First = "Harold",
                    Middle = "Francis",
                    Last = "Gilkey"
                },
                address = new Address
                {
                    street = "8360 high autumn row",
                    city = "cannon",
                    state = "Delware",
                    zip = "19797"
                },
                phone = new List<Phone>() {
                    new Phone(){number="123",
                    type="home"},
                    new Phone()
                    {
                        number="234",
                        type="mobile"
                    }
                },
                email = "harold.gilkey@yahoo.com"
            });
        }

    }
}