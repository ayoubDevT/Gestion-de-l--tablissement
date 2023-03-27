using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace La_tâche_Espace_des_clubs.Classes
{
    public class Activitées
    {
        private int _IdActi;

        public int IdActi
        {
            get { return _IdActi; }
            set { _IdActi = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
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

        private int _Planification;

        public int Planification
        {
            get { return _Planification; }
            set { _Planification = value; }
        }



        public Activitées()
        {

        }

        public Activitées(string description, string heureDébut, int durée, int planification)
        {
            Description = description;
            Planification = planification;
            HeureDébut = heureDébut;
            Durée = durée;

        }
    }
}
