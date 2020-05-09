using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    [Serializable]
    public abstract class Address
    {
        /// <summary>
        /// Deklarerar variabler
        /// </summary>
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        /// <summary>
        /// Returnerar länder
        /// </summary>
        /// <returns></returns>
        public string GetCountry()
        {
            return Country.ToString();
        }
    }
}
