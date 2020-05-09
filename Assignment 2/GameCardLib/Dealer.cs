using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Dealer : Hand
    {
        /// <summary>
        /// Delecering variables
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// takes a string and stores it 
        /// </summary>
        /// <param name="name"></param>
        public Dealer(string name)
        {
            Name = name;
        }
    }
}
