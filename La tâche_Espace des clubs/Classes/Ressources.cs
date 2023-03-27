using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Ressources
    {
        private string _IdRess;

        public string IdRess
        {
            get { return _IdRess; }
            set { _IdRess = value; }
        }

        private byte[] _Images;

        public byte[] Images
        {
            get { return _Images; }
            set { _Images = value; }
        }

        public Ressources()
        {

        }

        public Ressources(byte[] image)
        {
            Images = image;
        }
        
    }
}
