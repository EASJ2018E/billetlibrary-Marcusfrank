using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : Transportmiddel
    {
        /// <summary>
        /// Pris for MC
        /// </summary>
        /// <returns>
        /// Returns Pris deci at 125
        /// </returns>
        public override decimal Pris()
        {
            return 125;
        }

        /// <summary>
        /// Køretøj MC
        /// </summary>
        /// <returns></returns>
        public override  string køretøj()
        {
            return "MC";
        }
    }
}
