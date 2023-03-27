using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Managers;
using La_tâche_Espace_des_clubs.Forms;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs
{
    public partial class Liste_des_club : Form
    {
        public Liste_des_club()
        {
            InitializeComponent();
        }

        private void Liste_des_club_Load(object sender, EventArgs e)
        {


            dataGridView_list_club.DataSource = ClubManager.Affiche();
            dataGridView_list_club.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //comboBox1.DataSource = ClubManager.Club();
            //comboBox1.DisplayMember = "NomClub";
            //comboBox1.Hide();


            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Hide();
            //comboBox_Accee.Hide();
            comboBox_Stagiaire.DataSource = StagiaireManager.Stagiaires();
            comboBox_Stagiaire.DisplayMember = "Id";

            comboBox_Formateur.DataSource = FormateurManager.Formateurs();
            comboBox_Formateur.DisplayMember = "Matricule";

            //comboBox_Accee.DataSource = ClubManager.Club();
            //comboBox_Accee.DisplayMember = "Acces";
        }

        private void button_Crée_club_Click(object sender, EventArgs e)
        {
            dataGridView_list_club.DataSource = ClubManager.Affiche();
            dataGridView_list_club.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Crée_un_club_ f = new Crée_un_club_();
            f.Show();
            

        }

        private void button_Trouver_club_Click(object sender, EventArgs e)
        {





            if (dataGridView_list_club.CurrentRow.Cells["Acces"].Value.ToString() == "Ouverte")
            {
                Global.variable = dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString();
                Accueil_club c = new Accueil_club();
                c.ShowDialog();
                //this.Close();

            }
            else if (dataGridView_list_club.CurrentRow.Cells["Acces"].Value.ToString() == "Fermer")
            {
                if (radioButton_Formateur.Checked || radioButton_Stagiaire.Checked)
                {
                    filterM();
                }
                else
                {
                    MessageBox.Show("selectionnée votre Numéro pour continuer");
                }
            }





        }

        public static string DX;
        public void filterM()
        {
            Global.variable = dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString();
            if (radioButton_Formateur.Checked)
            {
                DX = comboBox_Formateur.Text;

            }
            else if (radioButton_Stagiaire.Checked)
            {
                DX = comboBox_Stagiaire.Text;
            }

            if (ParticipantsManager.ParticipantsDVF(DX) == true)
            {

                Accueil_club c = new Accueil_club();
                c.Show();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Vous éte pas un member dans le club " + "" + dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString());

            }
        }


        public void filterM2()
        {
            Global.variable = dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString();
            if (radioButton_Formateur.Checked)
            {
                DX = comboBox_Formateur.Text;

            }
            else if (radioButton_Stagiaire.Checked)
            {
                DX = comboBox_Stagiaire.Text;
            }

            if (ParticipantsManager.ParticipantsDVF(DX) == true)
            {
                MessageBox.Show("Vous éte déja member dans le club " + "" + dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString());

            }
            else if (ParticipantsManager.ParticipantsDVF(DX) == false)
            {
                string variable = null;
                if (radioButton_Stagiaire.Checked)
                {
                    Demande_appartenance dm = new Demande_appartenance(comboBox_Stagiaire.Text, variable, dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString());
                    DMManager.AjouterDM(dm);
                }
                else
                {
                    Demande_appartenance dm = new Demande_appartenance(variable, comboBox_Formateur.Text, dataGridView_list_club.CurrentRow.Cells["NomClub"].Value.ToString());
                    DMManager.AjouterDM(dm);
                }

                MessageBox.Show("La demande a été envoyée avec succée");


            }
        }


        private void dataGridView_list_club_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Liste_des_club_FormClosed(object sender, FormClosedEventArgs e)
        {
            Accueil_club a = new Accueil_club();

            a.Close();
        }

        private void Liste_des_club_FormClosing(object sender, FormClosingEventArgs e)
        {
            Accueil_club a = new Accueil_club();
            a.Close();
        }

        private void button_login_club_Click(object sender, EventArgs e)
        {

            if (radioButton_Formateur.Checked || radioButton_Stagiaire.Checked)
            {
                try
                {
                    filterM2();

                }
                catch (Exception)
                {
                    throw new Exception("probleme");
                }
            }
            else
            {
                MessageBox.Show("selectionnée votre Numéro pour continuer");
            }
        }

        private void radioButton_Formateur_Click(object sender, EventArgs e)
        {
            comboBox_Stagiaire.Hide();
            comboBox_Formateur.Show();
        }

        private void radioButton_Stagiaire_Click(object sender, EventArgs e)
        {
            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Show();
        }



        internal void Actualiser()
        {
            dataGridView_list_club.DataSource = null; 
            dataGridView_list_club.DataSource = ClubManager.Affiche();
        }
    }
}

