using Data_Access_Layer_DAL;
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
    public class BuildingManager : ListManager<Building>
    {
        /// <summary>
        /// Deklarara variabler
        /// </summary>
        private List<Building> buildingList = new List<Building>();
        private List<string> displayList = new List<string>();

        /// <summary>
        /// skapa ett unikt ID
        /// </summary>
        /// <returns></returns>
        public string CreateID()
        {
            return IDManager.CreateUniqueID();
        }

        /// <summary>
        /// returnerar byggnades index med hjälp av ID, om byggnaden inte finns returnera -1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetIndex(String id)
        {
            try
            {
                return list.FindIndex(x => x.BuildingID == id);
            }
            catch
            {
                return -1;
            }
        }

        /// <summary>
        /// Söker efter byggnaden med hjälp av stad och byggnadstyp
        /// </summary>
        /// <param name="city"></param>
        /// <param name="buildingType"></param>
        public void SearchCityAndBuildingType(string city, string buildingType)
        {
            buildingList.Clear();
            displayList.Clear();

            if (!String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city) && x.BuildingType.ToString().ToLower().Equals(buildingType));
            }
            else if (!String.IsNullOrEmpty(city) && String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.City.ToLower().Contains(city));
            }
            else if (String.IsNullOrEmpty(city) && !String.IsNullOrEmpty(buildingType))
            {
                buildingList = list.FindAll(x => x.BuildingType.ToString().ToLower().Equals(buildingType));
            }
            displayList = buildingList.ConvertAll(c => c.ToString());
        }

        /// <summary>
        /// lägger till bygnaderna i en lista från en databas
        /// </summary>
        public void SetDataFromDatabase()
        {
            DataTable dataTable = SQLQuery.RetrieveAllBuildings();
            string residentialCategory = new ResidentialBuilding().GetBuildingCategory();
            string category;
            Building building;

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                category = dataTable.Rows[row].Field<string>("Category");

                if (category.Equals(residentialCategory))
                {
                    building = SetResidentialBuilding(dataTable, row);
                }
                else
                {
                    building = SetCommercialBuilding(dataTable, row);
                }
                list.Add(building);
            }
            DisplayList();
        }

        /// <summary>
        /// Returnera byggnadsobjekt
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Building SetResidentialBuilding(DataTable dataTable, int row)
        {
            var building = (from rw in dataTable.AsEnumerable()
                        where dataTable.Rows.IndexOf(rw).Equals(row)
                        select new ResidentialBuilding()
                        {
                            BuildingID = (string)(rw["ID"]),
                            Country = (string)(rw["Country"]),
                            City = (string)(rw["City"]),
                            Street = (string)(rw["Street"]),
                            ZipCode = (string)(rw["Zip"]),
                            BuildingType = (string)(rw["Type"]),
                            LegalType = (string)(rw["Legal"])
                        }).First();
            return building;
        }

        /// <summary>
        /// Skapar ett CommercialBuilding object med hjälp av instanserna dataTable och row
        /// Returnera building objekt
        /// </summary>
        /// <param name="dataTable"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        private Building SetCommercialBuilding(DataTable dataTable, int row)
        {
            var building = (from rw in dataTable.AsEnumerable()
                        where dataTable.Rows.IndexOf(rw).Equals(row)
                        select new CommercialBuilding()
                        {
                            BuildingID = (string)(rw["ID"]),
                            Country = (string) (rw["Country"]),
                            City = (string)(rw["City"]),
                            Street = (string)(rw["Street"]),
                            ZipCode = (string)(rw["Zip"]),
                            BuildingType = (string)(rw["Type"]),
                            LegalType = (string)(rw["Legal"])
                        }).First();
            return building;
        }

        /// <summary>
        /// uppdatera databasen genom att ta bort allt innehåll och sedan lägga till de nya innehållen
        /// </summary>
        public void UpdateDatabase()
        {
            SQLQuery.DeleteAllObjects();

            foreach (Building building in list)
            {
                SQLQuery.AddBuilding(building);
            }
        }

        /// <summary>
        /// hämtar alla building objekt
        /// </summary>
        public void DisplayList()
        {
            displayList = ToStringList();
        }

        /// <summary>
        /// returnera displaylist
        /// </summary>
        /// <returns></returns>
        public List<string> GetDisplayList()
        {
            return displayList;
        }
    }
}