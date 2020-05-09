using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logics_Layer
{
    public class DataController
    {
        /// <summary>
        /// Deklarera variabler
        /// </summary>
        private BuildingManager buildingManager;
        private int index;

        /// <summary>
        /// En konstruktor
        /// </summary>
        /// <param name="table"></param>
        public DataController(BuildingManager buildingManager)
        {
            this.buildingManager = buildingManager;
        }

        /// <summary>
        /// lägger till building objekt i listan
        /// </summary>
        /// <param name="newBuilding"></param>
        public bool AddBuilding(Building newBuilding)
        {
            newBuilding.BuildingID = buildingManager.CreateID();
            return buildingManager.Add(newBuilding);
        }

        /// <summary>
        /// uppdaterar informationen
        /// </summary>
        /// <param name="buildingID"></param>
        /// <param name="building"></param>
        public bool EditBuilding(string buildingID, Building editedBuilding)
        {
            if (CheckID(buildingID))
            {
                return buildingManager.EditAt(index, editedBuilding);
            }
            return false;
        }

        /// <summary>
        /// Ta bort objekt
        /// </summary>
        /// <param name="buildingID"></param>
        public bool RemoveBuildingWithID(string buildingID)
        {
            if (CheckID(buildingID))
            {
                return buildingManager.DeleteAt(index);
            }
            return false;
        }

        /// <summary>
        /// Söker efter byggnaden som matchar samma stad och/eller typ
        /// </summary>
        /// <param name="city"></param>
        /// <param name="buildingType"></param>
        public void Search(string city, string buildingType)
        {
            buildingManager.SearchCityAndBuildingType(city, buildingType);
        }

        /// <summary>
        /// Kollar om ID:et finns, om den finns returnera true annars false
        /// </summary>
        /// <param name="buildingID"></param>
        /// <returns></returns>
        private bool CheckID(string buildingID)
        {
            index = buildingManager.GetIndex(buildingID);

            if (index != -1)
            {
                return true;
            }
            return false;
        }
    }
}
