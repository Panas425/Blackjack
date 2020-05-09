using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logics_Layer
{
    public class InputData
    {
        /// <summary>
        /// Deklara variabler
        /// </summary>
        private DataController controller;
        private Building building;
        public static int selectedindex;

        /// <summary>
        /// En kontruktor
        /// </summary>
        /// <param name="controller"></param>
        public InputData(DataController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// hämtar enum Countries
        /// </summary>
        /// <returns></returns>
        public static string[] GetCountries()
        {
            string[] countries = Enum.GetNames(typeof(Countries));

            for (int i = 0; i < countries.Length; i++)
            {
                countries[i] = countries[i].Replace("_", " ");
            }
            return countries;
        }

        /// <summary>
        /// hämtar enum kategori
        /// </summary>
        /// <returns></returns>
        public static string[] GetCategories()
        {
            return Enum.GetNames(typeof(Category));
        }

        /// <summary>
        /// Hämtar enum legalType
        /// </summary>
        /// <returns></returns>
        public static string[] GetOwnerships()
        {
            return Enum.GetNames(typeof(LegalType));
        }

        /// <summary>
        /// ändrar alternativ till BuildingType
        /// </summary>
        public static string[] GetBuildingTypes(int isCommercialBuilding)
        {
            selectedindex = isCommercialBuilding;
            string[] buildingType;

            if (isCommercialBuilding == 0)
            {
                buildingType = Enum.GetNames(typeof(Residential));
            }
            else
            {
                buildingType = Enum.GetNames(typeof(Commercial));
            }
            return buildingType;
        }

        /// <summary>
        /// Hämtar alla typer av byggnader
        /// </summary>
        /// <returns></returns>
        public static string[] GetBothBuildingTypes()
        {
            List<string> typeList = new List<string>();
            typeList.Add("");
            typeList.AddRange(Enum.GetNames(typeof(Residential)));
            typeList.AddRange(Enum.GetNames(typeof(Commercial)));
            return typeList.ToArray();
        }

        /// <summary>
        /// läser in användarens input om allting stämmer returneras true annars false
        /// </summary>
        /// <param name="typeComboBox"></param>
        /// <param name="countriesComboBox"></param>
        /// <param name="city"></param>
        /// <param name="street"></param>
        /// <param name="zipcode"></param>
        /// <param name="legalComboBox"></param>
        /// <returns></returns>
        public bool ReadBuildningInput(ComboBox typeComboBox, ComboBox countriesComboBox, string city, string street, string zipcode, ComboBox legalComboBox)
        {
            if (selectedindex == 1)
            {
                building = new CommercialBuilding();
                building.BuildingType = ((Commercial) typeComboBox.SelectedIndex).ToString(); 
            }
            else
            {
                building = new ResidentialBuilding();
                building.BuildingType = ((Residential) typeComboBox.SelectedIndex).ToString(); 
            }

            if (!CheckBuildingCity(city) || !CheckBuildingStreet(street) || !CheckBuildingZipCode(zipcode))
            {
                return false;
            }
            building.Country = ((Countries)countriesComboBox.SelectedIndex).ToString();
            building.LegalType = ((LegalType)legalComboBox.SelectedIndex).ToString(); 
            return true;
        }

        /// <summary>
        /// Om strängen stad är tom returnerar den false och meddelanderutan poppar fram annars true och lagrar variablen i tembuilding
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        private bool CheckBuildingCity(string city)
        {
            if (!String.IsNullOrEmpty(city))
            {
                building.City = city;
                return true;
            }
            MessageBox.Show("Please fill in City");
            return false;
        }

        /// <summary>
        /// Om strängen är tom returnerar den false och meddelanderutan poppar fram annars true och lagrar variablen i tembuilding
        /// </summary>
        /// <param name="street"></param>
        /// <returns></returns>
        private bool CheckBuildingStreet(string street)
        {
            if (!String.IsNullOrEmpty(street))
            {
                building.Street = street;
                return true;
            }
            MessageBox.Show("Please fill in Street");
            return false;
        }

        /// <summary>
        /// Om strängen är tom returnerar den false och meddelanderutan poppar fram annars true och lagrar variablen i tembuilding
        /// </summary>
        /// <param name="zipCode"></param>
        /// <returns></returns>
        private bool CheckBuildingZipCode(string zipCode)
        {
            if (zipCode.Length == 5)
            {
                building.ZipCode = zipCode;
                return true;
            }
            MessageBox.Show("Please fill in Zip Code");
            return false;
        }

        /// <summary>
        /// lägger till building object i listan
        /// </summary>
        public bool AddBuilding()
        {
            if (controller.AddBuilding(building))
            {
                SQLQuery.AddBuilding(building);
                return true;
            }
            return false;
        }

        /// <summary>
        /// redigerar building objekt
        /// </summary>
        /// <param name="buildingID"></param>
        public bool EditBuilding(string buildingID)
        {
            building.BuildingID = buildingID;

            if (controller.EditBuilding(buildingID, building))
            {
                SQLQuery.EditBuilding(buildingID, building);
                return true;
            }
            return false;
        }

        /// <summary>
        /// tar bort building object
        /// </summary>
        /// <param name="buildingID"></param>
        public bool RemoveBuilding(string buildingID)
        {
            if (controller.RemoveBuildingWithID(buildingID))
            {
                SQLQuery.RemoveBuilding(buildingID);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Söker efter building objekt
        /// </summary>
        /// <param name="city"></param>
        /// <param name="BuildingType"></param>
        public void Search(string city, string BuildingType)
        {
            if (String.IsNullOrEmpty(city) && String.IsNullOrEmpty(BuildingType))
            {
                MessageBox.Show("Please fill in the searchboxes");
            }
            else
            {
                city = city.ToLower();
                BuildingType = BuildingType.ToLower();
                controller.Search(city, BuildingType);
            }
        }

    }
}