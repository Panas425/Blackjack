using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    [Serializable]
    public class ResidentialBuilding : Building
    {
        /// <summary>
        /// Deklararea variabler
        /// </summary>
        public Residential ResidentialType { get; set; }
        public override string BuildingType { get; set; }

        /// <summary>
        /// Returnerar kategorier
        /// </summary>
        /// <returns></returns>
        public override String GetBuildingCategory()
        {
            return Category.Residential.ToString();
        }
    }
}
