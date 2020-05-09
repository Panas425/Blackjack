using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Data_Access_Layer_DAL
{
    public class Serial
    {
        /// <summary>
        /// sparar data till fil
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="type"></param>
        public static void BinarySerialization<T>(string fileName, T type)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();
                bformatter.Serialize(stream, type);
            }
        }

        /// <summary>
        /// öppnar data med hjälp av en fil
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T BinaryDeSerialization<T>(string fileName)
        {
            using (Stream stream = File.Open(fileName, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                return (T)bformatter.Deserialize(stream);
            }
        }


        /// <summary>
        /// sparar data till xml
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="type"></param>
        public static void XMLSerialize<T>(string fileName, T type)
        {
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var formatter = new XmlSerializer(typeof(T));
                formatter.Serialize(stream, type);

            }
        }
    }
}
