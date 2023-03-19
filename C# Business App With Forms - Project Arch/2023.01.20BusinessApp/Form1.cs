using _2023._01._20BusinessApp.utils;
using Business.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LibBusiness = Business; //Custom library developed by us is used.


/// <summary>
//  Created By Muhammed EROGLU.
/// </summary>
namespace _2023._01._20BusinessApp
{
    /// <summary>
    /// In this project custom library Business which is develeped by us is used.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly LibBusiness.User.Country _country = new LibBusiness.User.Country();
        private readonly LibBusiness.User.City _city = new LibBusiness.User.City();
        private readonly LibBusiness.User.User _user = new LibBusiness.User.User();
        private readonly LibBusiness.User.Phone _phone = new LibBusiness.User.Phone();
        private readonly LibBusiness.User.UserAddress _address = new LibBusiness.User.UserAddress();
        private Dictionary<TextBoxBase, Label> _errorLabels = new Dictionary<TextBoxBase, Label>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO don't use controllers as parameters.
            cmbPhoneType.DataSource = Enum.GetValues(typeof(LibBusiness.Base.PhoneType));
            cmbCountry.DataSource = new BindingSource(_country.CountriesList, null);
            cmbCountry.ValueMember = "Key";
            cmbCountry.DisplayMember = "Value";
            _errorLabels = new Dictionary<TextBoxBase, Label>(){
                { txtUsername,lblUsernameError },
                { txtName,lblNameError },
                { txtSurname,lblSurnameError },
                { txtPassword,lblPasswordError },
                { txtPhoneNo,lblPhoneNoError },
                { txtAddressName,lblAddressNameError },
                { txtAddress,lblAdressError },
                { txtPosstalCode,lblPostalCodeError },
            };
        }

        /// <summary>
        /// Change selected cities depending on selected country.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get selected Key Value Pair and assign them.
            KeyValuePair<int, string> selectedEntry
                = (KeyValuePair<int, string>)cmbCountry.SelectedItem;
            _country.SetSelectedCountry(selectedEntry.Key, selectedEntry.Value);
            cmbCity.DataSource = new BindingSource(_city.GetSelectedCity(cmbCountry.Text), null);
            cmbCity.ValueMember = "Key";
            cmbCity.DisplayMember = "Value";
        }

        /// <summary>
        /// Check and perform requiered operations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSaveUserDetails_Click(object sender, EventArgs e)
        {
            if (!Utils.TextFieldCheck(_errorLabels)) // Check if the empty field exists.
            {
                ///Todo don't take the vars from controllers.
                Utils.SaveUserDetails(
                    _user: _user,
                    _phone: _phone,
                    _address: _address,
                    userName: txtUsername.Text,
                    name:txtName.Text,
                    password: txtPassword.Text,
                    phoneNo: txtPhoneNo.Text,
                    addressName: txtAddressName.Text,
                    address: txtAddress.Text,
                    surname:txtSurname.Text,
                    postalCode:txtPosstalCode.Text
                    );
                using (Form2 form2 = new Form2(
                    _country,
                    _city,
                    _user,
                    _phone,
                    _address
                    ))
                {
                    this.Hide();
                    form2.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Assign selected country.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            KeyValuePair<int, string> selectedEntry
                 = (KeyValuePair<int, string>)cmbCity.SelectedItem;
            _city.SetSelectedCountry(selectedEntry.Key, selectedEntry.Value);
        }

        /// <summary>
        /// Change PhoneTyoe according to the related combo box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbPhoneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _phone.SetPhoneType(cmbPhoneType.Text);
        }
    }
}
