using Business.Base;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Business.User
{
    public class Phone : IID
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType Type { get; set; }

        public void SetPhoneType(string SelectedPhoneType)
        {
            switch (SelectedPhoneType)
                {
                case nameof(PhoneType.Home):
                    this.Type = PhoneType.Home;
                    break;
                case nameof(PhoneType.Work):
                    this.Type = PhoneType.Work;
                    break;
                default:
                    this.Type = PhoneType.Home;
                    break;
                }
            }
        }
    }

