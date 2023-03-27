using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using La_tâche_Espace_des_clubs.Classes;
using System.Data.SqlClient;
using System.Data;

namespace La_tâche_Espace_des_clubs.Managers
{
    class ParticipantsManager
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Participants", Global._Connection);
        


        public static DataTable Participantaff()
        {
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select	* 
                                                          from	Participants
                                                          where NomClub = '{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;
        }
        
        public static DataTable Participants()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Participants"] == null)
            {

                sda.Fill(Global.Dataset, "Participants");
            }
            return Global.Dataset.Tables["Participants"];
        }

        //public static void ParticipantsDV(string DV)
        //{
            
        //    //Participants();
        //    //new SqlCommandBuilder(sda);
        //    //Global._DataView.Table = Global.Dataset.Tables["Participant"];
        //    //Global._DataView.RowFilter = "0 = 1";

        //    // Global._DataView.RowFilter = string.Format("Nom = '{0}'", DV);
            
        //}
        public static bool ParticipantsDVF(string D)
        {
            Participants();
            Participantaff();
            

            
            
                foreach (DataRow Ligne in Global.Dataset.Tables["Participants"].Rows)
                {
                    if (Ligne["Numéro"].ToString() == D.ToString() && Ligne["NomClub"].ToString() == Global.variable)
                    {
                        return true;
                        break;
                    }
                    
                }
                return false;

                
                
            

        }

        public static void addparti(Participants parti)
        {
            Participantaff();
            Participants();
            DataRow ligne = Global.Dataset.Tables["Participants"].NewRow();

            ligne["Numéro"] = parti.Numéro;
            ligne["Nom"] = parti.Nom;
            ligne["Prenom"] = parti.Prénom;
            ligne["Type"] = parti.Type;
            ligne["NomClub"] = parti.Club;


            Global.Dataset.Tables["Participants"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Participants");

        }

        public static void supPar(int id)
        {
            Participants();
            Participantaff();

            foreach (DataRow Ligne in Global.Dataset.Tables["Participants"].Rows)
            {
                if (Ligne["IdPar"].ToString() == id.ToString())
                {
                    Ligne.Delete();

                    sda.Update(Global.Dataset, "Participants");

                    break;
                }
            }


        }
    }
}
