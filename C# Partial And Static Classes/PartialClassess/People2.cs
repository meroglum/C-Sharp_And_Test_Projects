using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassess
{
    /// <summary>
    /// This class work with the People.cs
    /// </summary>
    partial class People
    {
        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public string GetEmail(int peopleID)
        {
            string result = string.Empty;
            if (peopleID > 0)
            {
                result = this.Email;
            }
            else
            {
                result = "Email is not found";
            }
            return result;
        }
    }
}
