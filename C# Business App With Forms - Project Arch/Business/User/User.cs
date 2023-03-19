using Business.Base;
using System;
using System.Collections.Generic;

namespace Business.User
{
    public class User : IBase, IActivity
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<UserAddress> Addresses { get; set; } = new List<UserAddress>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }
    }
}
