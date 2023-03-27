using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs.Managers
{
    public static class ActivitéeManager
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select Planification,Description,HeureDébut,Durée
                                                         from Activitées ", Global._Connection);
        


        public static DataTable Activitée()
        {
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select Planification,Description,Activitées.HeureDébut,Activitées.Durée,Club
                                                         from Activitées inner join Planifications
                                                              on   Planifications.IdPla = Activitées.Planification
                                                         where  Club ='{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;
        }
        public static DataTable Activitées()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Activitées"] == null)
            {
                sda.Fill(Global.Dataset, "Activitées");
            }
            return Global.Dataset.Tables["Activitées"];
        }

        public static void AjouterAct(Activitées activitée)
        {
            Activitées();
            Activitée();
            DataRow ligne = Global.Dataset.Tables["Activitées"].NewRow();

            ligne["Description"] = activitée.Description;

            ligne["Durée"] = activitée.Durée;
            ligne["HeureDébut"] = activitée.HeureDébut;
            ligne["Planification"] = activitée.Planification;

            Global.Dataset.Tables["Activitées"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Activitées");

        }


    }
}
