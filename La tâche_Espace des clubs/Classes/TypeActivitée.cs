using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace La_tâche_Espace_des_clubs.Classes
{
    class TypeActivitée
    {
        private int _IdTActivitée;

        public int IdTActivitée
        {
            get { return _IdTActivitée; }
            set { _IdTActivitée = value; }
        }

        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        public TypeActivitée()
        {

        }

        public TypeActivitée(int idTActivitée, string type)
        {
            IdTActivitée = idTActivitée;
            Type = type;
        }
        
        
    }
}
