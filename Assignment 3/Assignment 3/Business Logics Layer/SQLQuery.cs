using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer_DAL;

namespace Business_Logics_Layer
{
    public class SQLQuery
    {
        /// <summary>
        /// Deklarerar variabler
        /// </summary>
        private static DatabaseContext db = new DatabaseContext();

        /// <summary>
        /// hämtar building objekt från databasen
        /// </summary>
        /// <returns></returns>
        public static DataTable RetrieveAllBuildings()
        {
            var query = "SELECT ID, Country, City, Street, Zip, Category, Type, Legal FROM building";
            return db.ExecuteQuery(query);
        }

        /// <summary>
        /// lägger till building objekt till databasen
        /// </summary>
        /// <param name="building"></param>
        public static void AddBuilding(Building building)
        {
            var query = "INSERT INTO building(ID, Country, City, Street, Zip, Category, Type, Legal) " +
                "VALUES('" + building.BuildingID + "', '" + building.GetCountry() + "', '" + building.City + "', '" + building.Street + "', '" + building.ZipCode +
                "', '" + building.GetBuildingCategory() + "', '" + building.BuildingType + "', '" + building.LegalType + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// tar bort building objekt
        /// </summary>
        /// <param name="id"></param>
        public static void RemoveBuilding(string id)
        {
            var query = "DELETE FROM building WHERE ID = '" + id + "'";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// redigerar building objekt
        /// </summary>
        /// <param name="id"></param>
        /// <param name="building"></param>
        public static void EditBuilding(string id, Building building)
        {
            var query = "UPDATE building SET `Country` = '" + building.GetCountry() + "', `City` = '" + building.City + "', `Street` = '" + building.Street + "', " +
                "`Zip` = '" + building.ZipCode + "', `Category` = '" + building.GetBuildingCategory() +"', `Type` = '" + building.BuildingType + "', " +
                "`Legal` = '" + building.LegalType + "' WHERE(`ID` = '" + id + "')";
            db.ExecuteQuery(query);
        }

        /// <summary>
        /// Tar bort objekt från databasen
        /// </summary>
        public static void DeleteAllObjects()
        {
            var query = "DELETE FROM building";
            db.ExecuteQuery(query);
        }
    }
}
