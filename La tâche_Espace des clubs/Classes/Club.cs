using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Club
    {
        

        private string _NomClub;

        public string NomClub
        {
            get { return _NomClub; }
            set { _NomClub = value; }
        }

        private string _Sujets;

        public string Sujets
        {
            get { return _Sujets; }
            set { _Sujets = value; }
        }

        private string _Accée;

        public string Accée
        {
            get { return _Accée; }
            set { _Accée = value; }
        }
        

        private string _Régles;

        public string Régles
        {
            get { return _Régles; }
            set { _Régles = value; }
        }

        private string _Stagiaire;

        public string Stagiaire
        {
            get { return _Stagiaire; }
            set { _Stagiaire = value; }
        }

        private string _Formateur;

        public string Formateur
        {
            get { return _Formateur; }
            set { _Formateur = value; }
        }
        
        

        public Club()
        {

        }

        public Club(string nomClub, string sujets, string accée, string régles, string stagiaire,string formateur)
        {
            NomClub = nomClub;
            Sujets = sujets;
            Accée = accée;
            Régles = régles;
            Stagiaire = stagiaire;
            Formateur = formateur;
        }
    }
}
