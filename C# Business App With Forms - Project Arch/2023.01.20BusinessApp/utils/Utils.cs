using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibBusiness = Business;

namespace _2023._01._20BusinessApp.utils
{
    static class Utils
    {
        /// <summary>
        /// Controls if the string is empty or null for label list.
        /// other control parametes like length and RegEx.
        /// </summary>
        /// <param name="labels"></param>
        /// TODO Do not take TextBoxBae as a reference.
        public static bool TextFieldCheck(Dictionary<TextBoxBase, Label> labels)
        {
            bool errorExist = false;
            foreach (var label in labels)
            {
                if (string.IsNullOrEmpty(label.Key.Text))
                {
                    label.Value.Text = "Boş";
                    errorExist = true;
                }
                else
                    label.Value.Text = "";
            }
            return errorExist;
        }

        /// <summary>
        /// Saves the required user info.
        /// </summary>
        /// <param name="_user"></param>
        /// <param name="_phone"></param>
        /// <param name="_address"></param>
        /// <param name="userName"></param>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="password"></param>
        /// <param name="phoneNo"></param>
        /// <param name="addressName"></param>
        /// <param name="address"></param>
        /// <param name="postalCode"></param>
        public static void SaveUserDetails(
            LibBusiness.User.User _user,
            LibBusiness.User.Phone _phone,
            LibBusiness.User.UserAddress _address,
            string userName,
            string name,
            string surname,
            string password,
            string phoneNo,
            string addressName,
            string address,
            string postalCode
            )
        {
            _user.Username = userName;
            _user.Firstname = name;
            _user.Lastname = surname;
            _user.Password = password;
            _phone.PhoneNumber = phoneNo;
            _address.Name = addressName;
            _address.AddressLine1 = address;
            _address.PostalCode = postalCode;
        }
    }
}
