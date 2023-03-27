using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Appartian
    {
        private string _IdPub;

        public string IdPub
        {
            get { return _IdPub; }
            set { _IdPub = value; }
        }

        private string _IdRess;

        public string IdRess
        {
            get { return _IdRess; }
            set { _IdRess = value; }
        }

        public Appartian()
        {

        }

        public Appartian(string idPub, string idRess)
        {
            IdPub = idPub;
            IdRess = idRess;
        }
    }
}
