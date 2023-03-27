using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Appartenance
    {
        private string _IdClub;

        public string IdClub
        {
            get { return _IdClub; }
            set { _IdClub = value; }
        }

        private string _IdPar;

        public string IdPar
        {
            get { return _IdPar; }
            set { _IdPar = value; }
        }

        public Appartenance()
        {

        }

        public Appartenance(string idClub, string idPar)
        {
            IdClub = idClub;
            IdPar = idPar;
        }
        
        
    }
}
