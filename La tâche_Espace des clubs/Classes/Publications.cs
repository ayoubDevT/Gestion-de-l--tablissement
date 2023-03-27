using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class Publications
    {
        private string _IdPub;

        public string IdPub
        {
            get { return _IdPub; }
            set { _IdPub = value; }
        }

        private string _Statut;

        public string Statut
        {
            get { return _Statut; }
            set { _Statut = value; }
        }

        private string _Club;

        public string Club
        {
            get { return _Club; }
            set { _Club = value; }
        }

        private string _Etat;

        public string Etat
        {
            get { return _Etat; }
            set { _Etat = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        
        

        public Publications()
        {

        }

        public Publications( string statut, string club, string etat, DateTime date)
        {
            Statut = statut;
            Club = club;
            Etat = etat;
            Date = date;
        }
    }
}
