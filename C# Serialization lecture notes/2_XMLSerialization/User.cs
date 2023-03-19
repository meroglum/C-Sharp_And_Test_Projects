using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _1_XMLSerialization
{
    // 1. örnek

    //[Serializable]
    //public class User
    //{
    //    private int userId;
    //    private string firstName;
    //    private string lastName;
    //    private string userName;
    //    private string email;
    //    private string password;

    //    [NonSerialized]
    //    private decimal maas;

    //    public int UserId
    //    {
    //        get { return userId; }
    //        set { userId = value; }
    //    }

    //    public string FirstName
    //    {
    //        get { return firstName; }
    //        set { firstName = value; }
    //    }

    //    public string LastName
    //    {
    //        get { return lastName; }
    //        set { lastName = value; }
    //    }

    //    public string UserName
    //    {
    //        get { return userName; }
    //        set { userName = value; }
    //    }

    //    public string Email
    //    {
    //        get { return email; }
    //        set { email = value; }
    //    }

    //    public string Password
    //    {
    //        get { return password; }
    //        set { password = value; }
    //    }

    //    [XmlIgnore]
    //    public decimal Maas
    //    {
    //        get { return maas; }
    //        set { maas = value; }
    //    }

    //    public User(int _userId, string _firstName, string _lastName, string _userName, string _email, string _password, decimal _maas)
    //    {
    //        UserId = _userId;
    //        FirstName = _firstName;
    //        LastName = _lastName;
    //        UserName = _userName;
    //        Email = _email;
    //        Password = _password;
    //        Maas = _maas;
    //    }

    //    public User()
    //    { }
    //}

    // 2.Örnek

    [Serializable]
    [XmlType(TypeName="User")]
    public class Kullanici
    {
        [XmlElement(ElementName="UserId", Type=typeof(int))]
        public int KullaniciId { get; set; }
        [XmlAttribute(AttributeName="Username")]
        public string KullaniciAd { get; set; }
        public string Email { get; set; }


        public Kullanici(int kullaniciId, string kullaniciAd, string email)
        {
            this.KullaniciId = kullaniciId;
            this.KullaniciAd = kullaniciAd;
            this.Email = email;
        }
        public Kullanici() { }
    }
}
