using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Managers;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs
{
    public partial class Modifier_membres : UserControl
    {
        public Modifier_membres()
        {
            InitializeComponent();
        }

        private void Modifier_membres_Load(object sender, EventArgs e)
        {
            dataGridView_listem.DataSource = ParticipantsManager.Participantaff();
            dataGridView_listem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Hide();
            comboBox_Stagiaire.DataSource = StagiaireManager.Stagiaires();
            comboBox_Stagiaire.DisplayMember = "Id";

            comboBox_Formateur.DataSource = FormateurManager.Formateurs();
            comboBox_Formateur.DisplayMember = "Matricule";

            comboBox1.DataSource = ParticipantsManager.Participantaff();
            comboBox1.DisplayMember = "IdPar";
            comboBox_nomF.Hide();
            comboBox_nomS.Hide();
            comboBox_prenomF.Hide();
            comboBox_prenomS.Hide();

            comboBox_nomS.DataSource = StagiaireManager.Stagiaires();
            comboBox_nomS.DisplayMember = "Nom";

            comboBox_prenomS.DataSource = StagiaireManager.Stagiaires();
            comboBox_prenomS.DisplayMember = "Prenom";

            comboBox_nomF.DataSource = FormateurManager.Formateurs();
            comboBox_nomF.DisplayMember = "Nom";

            comboBox_prenomF.DataSource = FormateurManager.Formateurs();
            comboBox_prenomF.DisplayMember = "Prenom";

            comboBox_Stagiaire.DataSource = StagiaireManager.Stagiaires();
            comboBox_Stagiaire.DisplayMember = "Id";

            comboBox_Formateur.DataSource = FormateurManager.Formateurs();
            comboBox_Formateur.DisplayMember = "Matricule";
        }

        private void radioButton_Formateur_Click(object sender, EventArgs e)
        {
            comboBox_Stagiaire.Hide();
            comboBox_Formateur.Show();
            comboBox_nomF.Show();
            comboBox_nomS.Hide();
            comboBox_prenomF.Show();
            comboBox_prenomS.Hide();
        }

        private void radioButton_Stagiaire_Click(object sender, EventArgs e)
        {
            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Show();
            comboBox_nomF.Hide();
            comboBox_nomS.Show();
            comboBox_prenomF.Hide();
            comboBox_prenomS.Show();
        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {
             try
            {
                
                if (radioButton_Stagiaire.Checked)
                {
                    Participants p = new Participants(comboBox_Stagiaire.Text, comboBox_nomS.Text, comboBox_prenomS.Text, "Membre", Global.variable);
                    ParticipantsManager.addparti(p);
                }
                else
                {
                    Participants p = new Participants(comboBox_Formateur.Text, comboBox_nomF.Text, comboBox_prenomF.Text, "Membre", Global.variable);
                    ParticipantsManager.addparti(p);
                }
                dataGridView_listem.DataSource = ParticipantsManager.Participantaff();
                dataGridView_listem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Liste_des_membress f = new Liste_des_membress();
                f.dataGridView_liste.DataSource = null;

                //f.dataGridView_liste.DataSource = ParticipantsManager.Participantaff();
                MessageBox.Show("Ajoutée avec succée");
                
            }
            catch (Exception exc)
            {
                throw new Exception(exc.ToString());
            }
             
        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                ParticipantsManager.supPar(int.Parse(dataGridView_listem.CurrentRow.Cells["IdPar"].Value.ToString()));
                dataGridView_listem.DataSource = ParticipantsManager.Participantaff();
                dataGridView_listem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Liste_des_membress f = new Liste_des_membress();
                f.dataGridView_liste.DataSource = ParticipantsManager.Participantaff();
                MessageBox.Show("Suppression avec succée");
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.ToString());
            }
            
        }

       
    }
}
