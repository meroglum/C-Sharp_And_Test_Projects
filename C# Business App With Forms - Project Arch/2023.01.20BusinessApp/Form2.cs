using Business.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using LibBusiness = Business;

namespace _2023._01._20BusinessApp
{
    public partial class Form2 : Form
    {
        private readonly LibBusiness.Payment.Payment _payment = new LibBusiness.Payment.Payment();
        private readonly LibBusiness.Basket.Basket _basket = new LibBusiness.Basket.Basket();
        private readonly LibBusiness.User.UserAddress _address;
        private readonly LibBusiness.User.Country _country;
        private readonly LibBusiness.User.City _city;
        private readonly LibBusiness.User.User _user;
        private readonly LibBusiness.User.Phone _phone;
        private Dictionary<TextBox, Label> _creditCardFields = new Dictionary<TextBox, Label>();
        public Form2(
            LibBusiness.User.Country _country,
            LibBusiness.User.City _city,
            LibBusiness.User.User _user,
            LibBusiness.User.Phone _phone,
            LibBusiness.User.UserAddress _address
            )
        {
            this._address = _address;
            this._country = _country;
            this._city = _city;
            this._user = _user;
            this._phone = _phone;
            InitializeComponent();
            label1.Text = _user.Username;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Todo do not use controllers as parameters.
            cmbPaymentMethod.DataSource = Enum.GetValues(typeof(LibBusiness.Base.PaymentType));
            chcBuyIt.Checked = true;
            _creditCardFields = new Dictionary<TextBox, Label>(){
                { txtCardNumber,lblCardNumber },
                { txtSKTMonth,labelSkt },
                { txtSKTYear,lblSKTDivider },
                { txtSKT_CVC,lblCVC }
            };
            lblAddress.Text = _address.AddressLine1;
            lblName.Text = _user.Firstname;
            lblSurname.Text = _user.Lastname;
            lblPhone.Text = _phone.PhoneNumber;
            lblCity.Text = _city.Name;
            lblCountry.Text = _country.Name;
        }

        private void CmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            _payment.SetPaymentType(
                cmbPaymentMethod.Text,
                _creditCardFields,
                lblPaynentMethodDoesNotExist
                );
        }

        private void ChcBuyIt_CheckedChanged(object sender, EventArgs e)
        {
            if (chcBuyIt.Checked)
                lblBasketTotal.Text = _basket.BasketTotal().ToString();
            else
                lblBasketTotal.Text = "0";
        }

        private void btnSaveUserDetails_Click(object sender, EventArgs e)
        {
            if (chcBuyIt.Checked)
            {
                lblBuyBtnError.Hide();
                using (Form3 form3 = new Form3())
                {
                    this.Hide();
                    form3.ShowDialog();
                }
            }
            else
            {
                lblBuyBtnError.Show();
            }
        }
    }
}
