using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCardLib
{
    public class Player : Hand
    {
        /// <summary>
        /// Delecering variable
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// takes in a string and stores it in the instance variable name
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            Name = name;
        }
    }
}
