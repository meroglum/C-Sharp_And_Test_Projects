using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


// Created By Muhammed EROGLU.
namespace _2023._01._17_PizzaOrder
{
    public partial class Form1 : Form
    {
        private readonly Basket basket = new Basket(); // Initialize the basket object.

        ///TODO - This class is needed to be refactored.
        private readonly OrderInfo orderInfo = new OrderInfo();

        #region vars - Daha sonra kaldırılacak
        List<string> NameAndSurname = new List<string>();
        List<string> Phone = new List<string>();
        List<string> Address = new List<string>();
        List<string> PizzaSizeAndCount = new List<string>();
        List<string> Extras = new List<string>();
        List<string> DrinkTypeAndCount = new List<string>();
        List<string> Price = new List<string>();
        string DrinkName = "";
        string PizzaName = "";
        double TotalPrice = 0;
        #endregion

        public Form1()
        {
            InitializeComponent();
            FillTheForm();
            cmbDrinkType.SelectedValueChanged += CmbDrinkType_SelectedValueChanged;
            cmbPizzaType.SelectedValueChanged += CmbPizzaType_SelectedIndexChanged;
            btnOrder.Click += BtnOrder_Click;
        }

        /// <summary>
        /// It fills the form with requiered data.
        /// </summary>
        private void FillTheForm()
        {
                // Fills Pizza types sectio
                PizzaTypes pizzaTypes= new PizzaTypes(); 
                cmbPizzaType.DataSource = pizzaTypes.GetPizzaTypes();
                cmbPizzaType.DisplayMember = "Name";
                cmbPizzaType.ValueMember = "ID";
                // cmbPizzaType.SelectedIndex = 0;

            // Fills Pizza types section
                DrinkTypes drinkTypes = new DrinkTypes();
                cmbDrinkType.DataSource = drinkTypes.GetDrinkTypes();
                cmbDrinkType.DisplayMember = "Name";
                cmbDrinkType.ValueMember = "ID";
                // cmbDrinkType.SelectedIndex = 0;

            // Fills the checkbox section
            chcSucuk.Text = EnumExtrasTypes.Sucuk.ToString();
            chcSosis.Text = EnumExtrasTypes.Sosis.ToString();
            chcKasar.Text = EnumExtrasTypes.Kaşar.ToString();
            chcPeynir.Text = EnumExtrasTypes.Peynir.ToString();
            chcMantar.Text = EnumExtrasTypes.Mantar.ToString();
            chcSebze.Text = EnumExtrasTypes.Sebze.ToString();
            // lBookNameAndSurname.DataSource = list;
        }

        /// <summary>
        /// Use value to calculate the price of the drink.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbDrinkType_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox _cmb = (ComboBox)sender;
            DrinkTypes drink = new DrinkTypes(
            Convert.ToInt32(_cmb.SelectedValue)); // Create a drink according to the selection
            this.DrinkName = drink.ProductName;
            basket.RemoveComboBoxDrinkProduct();
            basket.Add(drink);
            //MessageBox.Show("Toplam Fiyat: " + basket.GetTotalPrice());
            LblTotalPrice(basket.GetTotalPrice());
            CheckPromotionRights();
        }

        /// <summary>
        /// Use it to calculate the price of the Pizza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbPizzaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox _cmb = (ComboBox)sender;
            PizzaTypes pizza = new PizzaTypes(
            Convert.ToInt32(_cmb.SelectedValue)); // Create a drink according to the selection
            this.PizzaName = pizza.ProductName; // TODO Change code structe
            basket.RemoveComboBoxPizzaProduct();
            basket.Add(pizza); /// TODO Multiple adding issue. Solve it.
            LblTotalPrice(basket.GetTotalPrice());
            CheckPromotionRights();
        }

        private void LblTotalPrice(double totalPrice)
        {
            lblTotalPrice.Text = totalPrice.ToString() + " TL";
        }

        /// <summary>
        /// Do required calculations for the extras section.
        /// </summary>
        /// <param name="checkBoxType"></param>
        /// <param name="isChecked"></param>
        private void GetCheckBoxType(EnumExtrasTypes checkBoxType,bool isChecked)
        {
            Extras extra = new Extras(checkBoxType); // Create a extra object according to the selection
            if (isChecked) ///Check If the checkbox is checked
                basket.Add(extra); /// TODO Multiple adding issue. Solve it.
            else
            basket.RemoveCheckBoxProduct(extra,checkBoxType.ToString());
            LblTotalPrice(basket.GetTotalPrice());
            CheckPromotionRights();
        }

        /// <summary>
        /// It adds promotion when the threshold is passed.
        /// </summary>
        private void CheckPromotionRights()
        {
            if(basket.GetTotalPrice() >=  100) // veri database den alınmalı
            {
                lblPromation.Text = "Promosyon Tatlı KAZANDINIZ!";
            }
            else
            {
                lblPromation.Text = "";
            }
        }

        private void ChcSucuk_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Sucuk, _chkBox.Checked);
        }

        private void ChcSosis_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Sosis, _chkBox.Checked);
        }

        private void ChcMantar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Mantar, _chkBox.Checked);
        }

        private void ChcKasar_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Kaşar, _chkBox.Checked);
        }

        private void ChcPeynir_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Peynir, _chkBox.Checked);
        }

        private void ChcSebze_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox _chkBox = (CheckBox)sender;
            GetCheckBoxType(EnumExtrasTypes.Sebze, _chkBox.Checked);
        }

        /// <summary>
        /// Button the save order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// TODO Use seperate class.
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            // Save the pizza order data.
            // Data validation -- search
            this.NameAndSurname.Add(txtNameSurname.Text);
            this.Phone.Add(txtPhone.Text);
            this.Address.Add(txtAddress.Text);
            this.PizzaSizeAndCount.Add(PizzaName);
            this.DrinkTypeAndCount.Add(DrinkName);
            this.Price.Add(basket.GetTotalPrice().ToString());

            lBookNameAndSurname.DataSource = this.NameAndSurname;
            lBoxPhone.DataSource = this.Phone;
            lBoxAddress.DataSource = this.Address;
            lBoxPizzaSizeAndCount.DataSource = this.PizzaSizeAndCount;
            lBoxDrinkAndCount.DataSource = this.DrinkTypeAndCount;
            lBoxOrderPrice.DataSource = this.Price;

            // For extras.
            string _extras = string.Empty;
            if (chcSucuk.Checked)
                _extras += "Sucuk ";
            if (chcSosis.Checked)
                _extras += "Sosis ";
            if (chcMantar.Checked)
                _extras += "Mantar ";
            if (chcKasar.Checked)
                _extras += "Kaşar ";
            if (chcPeynir.Checked)
                _extras += "Peynir ";
            if (chcSebze.Checked)
                _extras += "Sebze ";

            this.Extras.Add(_extras);
            lBoxExtra.DataSource = this.Extras;
        }

        private void clearFields()
        {
            // TODO Implement method
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
