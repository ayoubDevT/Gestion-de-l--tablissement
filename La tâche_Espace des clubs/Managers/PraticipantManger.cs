using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace La_tâche_Espace_des_clubs.Managers
{
    public static class PraticipantManger
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Participants", Global._Connection);

        public static DataTable Praticipants()
        {


            if (Global.Dataset.Tables["Praticipants"] == null)
            {
                sda.Fill(Global.Dataset, "Praticipants");
            }
            return Global.Dataset.Tables["Praticipants"];
        }
        public static void AjouterPla(Praticipants Praticipant)
        {
            Praticipants();
            DataRow ligne = Global.Dataset.Tables["Praticipants"].NewRow();

            ligne["Sujet"] = planification.Sujet;
            ligne["Date"] = planification.Date;
            ligne["Durée"] = planification.Durée;
            ligne["HeureDébut"] = planification.HeureDébut;
            ligne["Club"] = planification.Club;

            Global.Dataset.Tables["Planifications"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Planifications");

        }
    }
}
