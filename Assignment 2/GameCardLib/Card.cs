using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilitiesLib;


namespace GameCardLib
{
    public class Card
    {
        /// <summary>
        /// Delecering variables
        /// </summary>
        public int Value { get; }
        public Image SuiteImage { get; set; }
        public Image BackImage { get; } = PlayingCards.GetCardBack();
        public bool FaceUp { get; set; } = false;

        /// <summary>
        /// takes in the value of the card and image to that value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="image"></param>
        public Card(int value, Image image)
        {
            Value = value;
            SuiteImage = image;
        }

        /// <summary>
        /// Returns the playing card image if the card is faced up otherwise the back card image is returned
        /// </summary>
        /// <returns></returns>
        public Image GetImage()
        {
            if (FaceUp)
            {
                return SuiteImage;
            }
            return BackImage;
        }
    }
}
