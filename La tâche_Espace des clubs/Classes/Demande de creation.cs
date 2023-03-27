using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Demande_de_creation
    {
        private string _Nom;

        public string Nom
        {
            get { return _Nom; }
            set { _Nom = value; }
        }

        private string _Sujets;

        public string Sujets
        {
            get { return _Sujets; }
            set { _Sujets = value; }
        }

        private string _Acces;

        public string Acces
        {
            get { return _Acces; }
            set { _Acces = value; }
        }

        private string _Régles;

        public string Régles
        {
            get { return _Régles; }
            set { _Régles = value; }
        }

        private string _Etat;

        public string Etat
        {
            get { return _Etat; }
            set { _Etat = value; }
        }

        private string _Participant;

        public string Participant
        {
            get { return _Participant; }
            set { _Participant = value; }
        }
        

        public Demande_de_creation()
        {

        }
        public Demande_de_creation(string nom,string sujets,string acces, string régles ,string etat ,string participant)
        {
            Nom = nom;
            Sujets = sujets;
            Acces = acces;
            Régles = régles;
            Etat = etat;
            Participant = participant;
        }
    }
}
