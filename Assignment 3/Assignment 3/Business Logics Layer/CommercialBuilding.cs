using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Business_Logics_Layer
{
    [Serializable]
    public class CommercialBuilding : Building
    {
        /// <summary>
        /// Deklarera variabler
        /// </summary>
        public Commercial CommercialType { get; set; }
        public override string BuildingType { get; set; }

        /// <summary>
        /// Returnera building commercial objekt
        /// </summary>
        /// <returns></returns>
        public override String GetBuildingCategory()
        {
            return Category.Commercial.ToString();
        }
    }
}
