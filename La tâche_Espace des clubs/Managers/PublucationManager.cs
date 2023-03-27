using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs.Managers
{
    class PublucationManager
    {
        static SqlDataAdapter sda = new SqlDataAdapter(@"select	* from	Publications", Global._Connection);

        

        public static DataTable Publications()
        {
            new SqlCommandBuilder(sda);

            if (Global.Dataset.Tables["Publications"] == null)
            {
                sda.Fill(Global.Dataset, "Publications");
            }
            return Global.Dataset.Tables["Publications"];
        }
        public static DataTable Publications1()
        {
            //new SqlCommandBuilder(sda1);

            //if (Global.Dataset.Tables["Publications1"] == null)
            //{
            //    sda1.Fill(Global.Dataset, "Publications1");
            //}
            //return Global.Dataset.Tables["Publications1"];
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select	Publications.Date,Publications.Statut,Ressources.Images
                                                          from	    Ressources  inner join Appartian
				                                                    on Ressources.IdRess = Appartian.IdRess
				                                                            inner join Publications
				                                                    on Publications.IdPub = Appartian.IdPub
                                                           where	Club = '{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;
        }
        public static DataTable Publications2()
        {
            //new SqlCommandBuilder(sda2);
            
            //if (Global.Dataset.Tables["Publications2"] == null)
            //{
            //    sda2.Fill(Global.Dataset, "Publications2");
            //}
            //return Global.Dataset.Tables["Publications2"];
            Global._Connection.Open();

            Global._Command.Connection = Global._Connection;

            SqlDataReader reader;
            DataTable table = new DataTable();

            Global._Command.CommandText = string.Format(@"select	Publications.Date,Publications.Statut,Ressources.Images
                                                          from	    Ressources  inner join Appartian
				                                                    on Ressources.IdRess = Appartian.IdRess
				                                                            inner join Publications
				                                                    on Publications.IdPub = Appartian.IdPub
                                                           where	Etat='Public' and Club = '{0}'", Global.variable);
            reader = Global._Command.ExecuteReader();

            table.Load(reader);

            reader.Close();

            Global._Connection.Close();

            return table;
        }
        public static void AjouterPub(Publications Pub)
        {
            Publications();
            Publications1();
            Publications2();
            DataRow ligne = Global.Dataset.Tables["Publications"].NewRow();

            ligne["Statut"] = Pub.Statut;
            ligne["Date"] = Pub.Date;
            ligne["Club"] = Pub.Club;
            ligne["Etat"] = Pub.Etat;


            Global.Dataset.Tables["Publications"].Rows.Add(ligne);
            sda.Update(Global.Dataset, "Publications");
        }
        

    }
}
