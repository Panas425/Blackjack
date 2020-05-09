using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    [Serializable]
    [XmlInclude(typeof(ResidentialBuilding))]
    [XmlInclude(typeof(CommercialBuilding))]
    public abstract class Building : Address
    {
        /// <summary>
        /// Deklarera variabler
        /// </summary>
        public string BuildingID { get; set; }
        public abstract string GetBuildingCategory();
        public abstract string BuildingType { get; set; }
        public string LegalType { get; set; }

        /// <summary>
        /// Returera building object till strängar
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return BuildingID + ", " + GetCountry() + ", " + City + ", " + Street + ", " + ZipCode + ", " + GetBuildingCategory() + ", " 
                + BuildingType + ", " + LegalType.ToString();
        }
    }
}
