using Business.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Business.Payment
{
    public class Payment : IBase, IActivity
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public Provider Provider { get; set; }
        public PaymentType Type { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }

        /// <summary>
        /// Sets payment type and updates ui accordingly.
        /// </summary>
        /// <param name="SelectedPhoneType"></param>
        public void SetPaymentType(
            string SelectedPhoneType,
            Dictionary<TextBox, Label> creditCardFields,
            Label paymentMethodError
            )
        {
            bool hideField = true; // Change UI according to the selection
            switch (SelectedPhoneType)
            {
                case nameof(PaymentType.CC):
                    this.Type = PaymentType.CC;
                    hideField = false;
                    break;
                case nameof(PaymentType.Transfer):
                    this.Type = PaymentType.Transfer;
                    break;
                case nameof(PaymentType.OnlinePaymentProvider):
                    this.Type = PaymentType.OnlinePaymentProvider;
                    break;
                case nameof(PaymentType.Cash):
                    this.Type = PaymentType.Transfer;
                    break;
                default:
                    this.Type = PaymentType.CC;
                    break;
            }
                if (hideField)
            {
                paymentMethodError.Show();
                foreach (var item in creditCardFields)
                {
                    item.Key.Hide();
                    item.Value.Hide();
                }
            }
            else
            {
                paymentMethodError.Hide();
                foreach (var item in creditCardFields)
                {
                    item.Key.Show();
                    item.Value.Show();
                }
            }
        }
    }
}

