using Business.Base;
using System.Collections.Generic;

namespace Business.User
{
    public class Country : IID, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Dictionary<int, string> CountriesList = new Dictionary<int, string>()
        {
            {1,"Turkiye" },
            {2,"Almanya" }
         };
        
        /// <summary>
        /// Set the selected country.
        /// </summary>
        /// <param name="selectedCountryID"></param>
        /// <param name="selectedCountry"></param>
        public void SetSelectedCountry(int selectedCountryID, string selectedCountry)
        {
            this.ID = selectedCountryID;
            this.Name = selectedCountry;
        }
    }
}
