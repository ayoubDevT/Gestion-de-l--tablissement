using System;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using La_tâche_Espace_des_clubs.Classes;
namespace La_tâche_Espace_des_clubs.Managers
{
    class RessourcesManager
    {
        public static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Ressources", Global._Connection);


        public static DataTable Ressources()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Ressources"] == null)
            {
                sda.Fill(Global.Dataset, "Ressources");
            }
            return Global.Dataset.Tables["Ressources"];
        }
        public static void AjouterImage(Ressources Ressource)
        {
            Ressources();

            DataRow ligne = Global.Dataset.Tables["Ressources"].NewRow();

            ligne["Images"] = Ressource.Images;


            Global.Dataset.Tables["Ressources"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Ressources");
        }


    } 
}
