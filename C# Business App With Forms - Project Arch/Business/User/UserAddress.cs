using Business.Base;
using System;
using System.Collections.Generic;

namespace Business.User
{
    public class UserAddress : IBase, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public List<Phone> Phones { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
