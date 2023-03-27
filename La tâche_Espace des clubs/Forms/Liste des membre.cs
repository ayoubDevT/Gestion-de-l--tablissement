using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Managers;
using System.Data.SqlClient;

namespace La_tâche_Espace_des_clubs
{
    public partial class Liste_des_membress : UserControl
    {
        public Liste_des_membress()
        {
            InitializeComponent();
        }

        private void Liste_des_membress_Load(object sender, EventArgs e)
        {
            dataGridView_liste.DataSource = null;
            dataGridView_liste.DataSource = ParticipantsManager.Participantaff();
            dataGridView_liste.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView_liste.DataSource = Global._DataView;
            
        }

        private void textBox_Numero_rech_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Numero_rech.Text ==string.Empty)
            {


                dataGridView_liste.DataSource = null;
                dataGridView_liste.DataSource = ParticipantsManager.Participantaff();


            }
            else
            {
                //ParticipantsManager.ParticipantsDV(textBox_Numero_rech.Text);
                //            dataGridView_liste.DataSource = Global._DataView;
                #region Affiché Ville
                Global._Connection.Open();
                SqlDataReader reader;
                DataTable DataTable = new DataTable();

                
                Global._Command.CommandText = string.Format(@" select	* 
                                                          from	Participants
                                                          where Nom = '{0}'", textBox_Numero_rech.Text);
                reader = Global._Command.ExecuteReader();
                DataTable.Load(reader);
                reader.Close();
                dataGridView_liste.DataSource = null;
                dataGridView_liste.DataSource = DataTable;
                
                
                Global._Connection.Close();
                #endregion
            }

            
        }



        public void Actualiser()
        {
            dataGridView_liste.DataSource = null;
            dataGridView_liste.DataSource = ParticipantsManager.Participantaff();
        }
    }
}
