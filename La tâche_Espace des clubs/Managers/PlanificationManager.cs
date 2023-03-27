using System.Data;
using System.Data.SqlClient;
using La_tâche_Espace_des_clubs.Classes;
namespace La_tâche_Espace_des_clubs.Managers
{
    public static class PlanificationManager
    {

        static string req = string.Format("select	IdPla,Sujet,Date,HeureDébut,Durée,Club from	Planifications where Club = '{0}'", Global.variable);
        static SqlDataAdapter sda = new SqlDataAdapter(req, Global._Connection);


        public static DataTable Planifications()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Planifications"] == null)
            {
                sda.Fill(Global.Dataset, "Planifications");
            }
            return Global.Dataset.Tables["Planifications"];
        }

        public static void AjouterPla(Planifications planification)
        {
            Planifications();
            DataRow ligne = Global.Dataset.Tables["Planifications"].NewRow();

            ligne["Sujet"] = planification.Sujet;
            ligne["Date"] = planification.Date;
            ligne["Durée"] = planification.Durée;
            ligne["HeureDébut"] = planification.HeureDébut;
            ligne["Club"] = planification.Club;

            Global.Dataset.Tables["Planifications"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Planifications");

        }
        public static DataTable Afficher()
        {
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format("select	IdPla,Sujet,Date,HeureDébut,Durée,Club from	Planifications where Club = '{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;


        }

    }
}
