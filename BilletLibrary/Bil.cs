using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Bil : Transportmiddel
    {
        /// <summary>
        /// Pris for Bil
        /// </summary>
        /// <returns></returns>
        public decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// Køretøj Bil
        /// </summary>
        /// <returns></returns>
        public string køretøj()
        {
            return "Bil";
        }
    }
}
