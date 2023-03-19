using Business.Base;
using System.Collections.Generic;

namespace Business.User
{
    public class City : IID, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Dictionary<int, string> TurkishCities { get; set; } = new Dictionary<int, string>()
        {
             {1,"Istanbul" },
             {2,"Ankara" },
             {3,"Izmir" },
        };

        public Dictionary<int, string> GermanCities { get; set; } = new Dictionary<int, string>()
        {
             {1,"Berlin" },
             {2,"Munih" },
             {3,"Frankfurt" },
        };

        public Dictionary<int, string> NoSelectedCounty { get; set; } = new Dictionary<int, string>()
        {
             {-1,"Lutfen ulke seciniz" },
        };

        /// <summary>
        /// Get the selected city list according to the country
        /// </summary>
        /// <param name="selectedCountry"></param>
        public Dictionary<int, string> GetSelectedCity(string selectedCountry)
        {
            switch (selectedCountry)
            {
                case nameof(Countries.Turkiye):
                    return TurkishCities;
                case nameof(Countries.Almanya):
                    return GermanCities;
                default:
                    return NoSelectedCounty;
            }
        }

        /// <summary>
        /// Set the selected citu.
        /// </summary>
        /// <param name="selectedCityID"></param>
        /// <param name="selectedCity"></param>
        public void SetSelectedCountry(int selectedCityID, string selectedCity)
        {
            this.ID = selectedCityID;
            this.Name = selectedCity;
        }
    }
}
