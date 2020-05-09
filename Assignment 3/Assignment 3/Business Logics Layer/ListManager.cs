using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Data_Access_Layer_DAL;

namespace Business_Logics_Layer
{
    [Serializable]
    public class ListManager<T> : IListManager<T>
    {
        /// <summary>
        /// Deklarerar variabler
        /// </summary>
        public List<T> list = new List<T>();
        public int Count { get => list.Count; }

        /// <summary>
        /// lägger till object till listan
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool Add(T type)
        {
            try
            {
                list.Add(type);
                return true;
            }
            catch { }
            return false;
        }

        /// <summary>
        /// kollar om indexen finns i listan
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool CheckIndex(int index)
        {
            return list[index].Equals(null);
        }

        /// <summary>
        /// tar bort alla objekt från listan
        /// </summary>
        public void DeleteAll()
        {
            list.Clear();
        }

        /// <summary>
        /// tar bort object från given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            if (!CheckIndex(index))
            {
                list.RemoveAt(index);
                return true;
            }
            return false;
        }

        /// <summary>
        /// tillägger objekt till listan
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool InsertAt(int index, T type)
        {
            try
            {
                list.Insert(index, type);
                return true;
            }
            catch { }
            return false;
        }

        /// <summary>
        /// redigera objekt 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool EditAt(int index, T type)
        {
            if (!CheckIndex(index))
            {
                list[index] = type;
                return true;
            }
            return false;
        }

        /// <summary>
        /// returnera objekt med hjälp av given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T GetAt(int index)
        {
            return list[index];
        }

        /// <summary>
        /// returnerar arrayer av building data
        /// </summary>
        /// <returns></returns>
        public string[] ToStringArray()
        {
            return list.ConvertAll(c => c.ToString()).ToArray();
        }

        /// <summary>
        /// Returnera building data från listan till arrat
        /// </summary>
        /// <returns></returns>
        public List<string> ToStringList()
        {
            try
            {
                return list.ConvertAll(c => c.ToString());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return null;
        }

        /// <summary>
        /// sparar listan till en fil
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void BinarySerialization(string fileName)
        {
            Serial.BinarySerialization(fileName, list);
        }

        /// <summary>
        /// öppnar fil och returnera listan
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void BinaryDeSerialization(string fileName)
        {
           list = Serial.BinaryDeSerialization<List<T>>(fileName);
        }

        /// <summary>
        /// Sparar data till en xml-fil
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public void XMLSerialize(string fileName)
        {
            Serial.XMLSerialize(fileName, list);
        }
    }
}
