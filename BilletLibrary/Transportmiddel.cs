using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public abstract class Transportmiddel
    {
        /// <summary>
        /// Nummerplade på et transportmiddel
        /// </summary>
        public string Nummerplade
        {
            get { return _nummerplade; }
            set {
                if (value.Length < 7)
                {
                    _nummerplade = value;
                }
                throw new ArgumentOutOfRangeException(_nummerplade, "Nummerpladen er for lang");
                }
        }

        public DateTime dato;
        private string _nummerplade;



        /// <summary>
        /// Pris for transportmiddel i deci
        /// </summary>
        /// <returns></returns>
        public virtual decimal Pris()
        {
            return 240;
        }

        /// <summary>
        /// køretøj, default Bil
        /// </summary>
        /// <returns></returns>
        public virtual string køretøj()
        {
            return "Bil";
        }
    }
}
