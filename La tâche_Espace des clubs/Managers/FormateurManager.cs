using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace La_tâche_Espace_des_clubs.Managers
{
    class FormateurManager
    {
        public static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Formateurs", Global._Connection);


        public static DataTable Formateurs()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Formateurs"] == null)
            {
                sda.Fill(Global.Dataset, "Formateurs");
            }
            return Global.Dataset.Tables["Formateurs"];
        }
    }
}
