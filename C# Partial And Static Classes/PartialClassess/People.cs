using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassess
{
    /// <summary>
    /// This class work with the People2.cs
    /// </summary>
    partial class People
    {
        //Fields
        private int peopleId;
        private string firstName;
        private string lastName;
        private string password;
        private string email;
        private DateTime birthday;

        //Properties (CTRL + R + C)
        public int PeopleId
        {
            get => peopleId;
            set => peopleId = value;
        }

        public string FirstName { get => firstName; set => firstName = value;}
        public string LastName { get => lastName; set => lastName = value;}
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public DateTime BirthDay { get => birthday;set=> birthday = value; }

    }
}
