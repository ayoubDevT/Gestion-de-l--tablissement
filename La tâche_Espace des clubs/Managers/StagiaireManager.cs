using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace La_tâche_Espace_des_clubs.Managers
{
    class StagiaireManager
    {
        public static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Stagiaires", Global._Connection);


        public static DataTable Stagiaires()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Stagiaires"] == null)
            {
                sda.Fill(Global.Dataset, "Stagiaires");
            }
            return Global.Dataset.Tables["Stagiaires"];
        }
    }
}
