using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs.Managers
{
    class ClubManager
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Clubs ", Global._Connection);
        static SqlDataAdapter sda1 = new SqlDataAdapter(@"select	* from	Club ", Global._Connection);

        public static DataTable Club()
        {
            new SqlCommandBuilder(sda1);

            if (Global.Dataset.Tables["Club"] == null)
            {
                sda1.Fill(Global.Dataset, "Club");
            }
            return Global.Dataset.Tables["Club"];
        }

        public static DataTable Clubs()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Clubs"] == null)
            {
                sda.Fill(Global.Dataset, "Clubs");
            }
            return Global.Dataset.Tables["Clubs"];
        }

        public static void AjouterClub(Club club)
        {
            Clubs();
            Club();
            DataRow ligne = Global.Dataset.Tables["Clubs"].NewRow();

            ligne["NomClub"] = club.NomClub;
            ligne["Sujets"] = club.Sujets;
            ligne["Acces"] = club.Accée;
            ligne["Régles"] = club.Régles;
            ligne["Stagiaire"] = club.Stagiaire;
            ligne["Formateur"] = club.Formateur;

            Global.Dataset.Tables["Clubs"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Clubs");

        }

        public static void info(string v)
        {
            Clubs();
            Club();
            foreach (DataRow ligne in Global.Dataset.Tables["Club"].Rows)
            {

                if (ligne["NomClub"].ToString() == v)
                {
                    Global.variableNomClub = ligne["NomClub"].ToString();
                    Global.variableSujet = ligne["Sujets"].ToString();
                    Global.variableAccée = ligne["Acces"].ToString();
                    Global.variableRégles = ligne["Régles"].ToString();
                    Global.variableParti = ligne["Président"].ToString();
                }

            }

            //for (int i = 0; i < Global.Dataset.Tables["Clubs"].Rows.Count; i++)
            //{
            //    if (Global.Dataset.Tables["Clubs"].Rows[i]["NomClub"].ToString() == v)
            //    {
            //        Global.variableNomClub = Global.Dataset.Tables["Clubs"].Rows[i]["NomClub"].ToString();
            //        Global.variableSujet = Global.Dataset.Tables["Clubs"].Rows[i]["Sujets"].ToString();
            //        Global.variableAccée = Global.Dataset.Tables["Clubs"].Rows[i]["Acces"].ToString();
            //        Global.variableRégles = Global.Dataset.Tables["Clubs"].Rows[i]["Régles"].ToString();
            //        Global.variableParti = Global.Dataset.Tables["Clubs"].Rows[i]["Participant"].ToString();
            //        break;
            //    }
            //}
        }
        public static DataTable Affiche()
        {
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select	* from	Club ");
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;
        }
        
    }
}
