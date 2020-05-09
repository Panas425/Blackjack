using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Business_Logics_Layer
{
    public class IDManager
    {
        /// <summary>
        /// Deklarera variabler
        /// </summary>
        private static string stringID = "1234567890";
        private const int lengthOfID = 4;
        public static List<string> UniqueIDList { get; set; } = new List<string>();
        private static Random random = new Random();

        /// <summary>
        /// skapar ett unikt ID
        /// </summary>
        /// <returns></returns>
        public static string CreateUniqueID()
        {
            string newUniqueID;

            while (true)
            {
                newUniqueID = idUnique(CreateRandomID());

                if (newUniqueID != null)
                {
                    break;
                }
            }
            UniqueIDList.Add(newUniqueID);
            return newUniqueID;
        }

        /// <summary>
        /// returnera id:et om den är unik
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string idUnique(string id)
        {
            for (int i = 0; i < UniqueIDList.Count; i++)
            {
                if (id.Equals(UniqueIDList[i]))
                {
                    return null;
                }
            }
            return id;
        }

        /// <summary>
        /// skapar ett slumpmässgit id
        /// </summary>
        /// <returns></returns>
        public static string CreateRandomID()
        {
            string randomID = "";

            for (int i = 0; i < lengthOfID; i++)
            {
                char n = stringID[random.Next(stringID.Length)];
                randomID += n;
            }
            return randomID;
        }
    }
}
