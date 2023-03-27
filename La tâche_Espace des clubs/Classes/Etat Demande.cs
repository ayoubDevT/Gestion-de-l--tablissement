using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Etat_Demande
    {
        private string _IdEtat;

        public string IdEtat
        {
            get { return _IdEtat; }
            set { _IdEtat = value; }
        }

        private string _Etat;

        public string Etat
        {
            get { return _Etat; }
            set { _Etat = value; }
        }

        public Etat_Demande()
        {

        }

        public Etat_Demande(string idEtat, string etat)
        {
            IdEtat = idEtat;
            Etat = etat;
        }
    }
}
