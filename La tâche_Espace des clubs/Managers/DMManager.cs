using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs.Managers
{
    class DMManager
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	[Demande appartenance] ", Global._Connection);
        
        public static DataTable DM()
        {
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select * from	DMA 
                                                           where    Club = '{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;

        }

        public static DataTable Demande_appartenance()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["[Demande appartenance]"] == null)
            {
                sda.Fill(Global.Dataset, "[Demande appartenance]");
            }
            return Global.Dataset.Tables["[Demande appartenance]"];
        }

        public static void AjouterDM(Demande_appartenance demande_appartenance)
        {
            Demande_appartenance();
            DataRow ligne = Global.Dataset.Tables["[Demande appartenance]"].NewRow();
            
            ligne["Club"] = demande_appartenance.IdClub;
            ligne["Formateur"] = demande_appartenance.Formateur;
            ligne["Stagiaire"] = demande_appartenance.Stagiaire;


            Global.Dataset.Tables["[Demande appartenance]"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "[Demande appartenance]");

        }

        public static void supDM(int id)
        {
            Demande_appartenance();
            System.Windows.Forms.MessageBox.Show(id.ToString());
            foreach (DataRow Ligne in Global.Dataset.Tables["[Demande appartenance]"].Rows)
            {
                if (Ligne["IdDA"].ToString() ==  id.ToString())
                {
                    Ligne.Delete();
                    System.Windows.Forms.MessageBox.Show("Test2");
                    sda.Update(Global.Dataset, "[Demande appartenance]");
   
                    break;
                }
            }


        }
    }
}
