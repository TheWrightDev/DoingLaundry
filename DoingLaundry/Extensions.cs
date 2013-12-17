using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoingLaundry
{
    public static class Extensions
    {
        /// <summary>
        /// Determines if character entered is an allowed numeric key character
        /// </summary>
        /// <param name="character">The character to check</param>
        /// <returns>True if key entered is number, otherwise false.</returns>
        public static bool IsNumeric(this char character)
        {
            return (char.IsControl(character) || char.IsDigit(character));
        }
    }
}
