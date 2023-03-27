using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace La_tâche_Espace_des_clubs.Classes
{
    public class Planifications
    {
        private int _IdPla;

        public int IdPla
        {
            get { return _IdPla; }
            set { _IdPla = value; }
        }

        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        private string _Sujet;

        public string Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        private int _Durée;

        public int Durée
        {
            get { return _Durée; }
            set
            {
                if (value >= 1 && value <= 10)
                    _Durée = value;
                else
                    throw new Exception("La durée est longue");
            }
        }

        private string _Club;

        public string Club
        {
            get { return _Club; }
            set { _Club = value; }
        }

        private string _HeureDébut;

        public string HeureDébut
        {
            get { return _HeureDébut; }
            set
            {
                Regex r = new Regex(@"^(?:0?[8-9]|1[0-7]):?:[0-5]?[0-9]$");
                if (r.IsMatch(value))
                {
                    _HeureDébut = value;
                }
                else
                {
                    throw new Exception("Format d'HeureDébut est invalide");
                }
            }
        }
        public Planifications()
        {

        }

        public Planifications(DateTime date, string sujet, int durée, string heureDébut, string club)
        {

            Date = date;
            Sujet = sujet;
            Durée = durée;
            Club = club;
            HeureDébut = heureDébut;
        }
    }
}
