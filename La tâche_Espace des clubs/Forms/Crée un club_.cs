using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Classes;
using La_tâche_Espace_des_clubs.Managers;

namespace La_tâche_Espace_des_clubs.Forms
{
    public partial class Crée_un_club_ : Form
    {
        public Crée_un_club_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton_Formateur.Checked || radioButton_Stagiaire.Checked)
                {
                    string variable = null;
                    if (radioButton_Stagiaire.Checked)
                    {
                        Club club = new Club(textBox1.Text, textBox2.Text, Acces().ToString(), textBox3.Text, comboBox_Stagiaire.Text, variable);
                        ClubManager.AjouterClub(club);
                        Participants p = new Participants(comboBox_Stagiaire.Text, comboBox_nomS.Text, comboBox_prenomS.Text, "Président", textBox1.Text);
                        ParticipantsManager.addparti(p);
                    }
                    else
                    {
                        Club club = new Club(textBox1.Text, textBox2.Text, Acces().ToString(), textBox3.Text, variable, comboBox_Formateur.Text);
                        ClubManager.AjouterClub(club);
                        Participants p = new Participants(comboBox_Formateur.Text, comboBox_nomF.Text, comboBox_prenomF.Text, "Président", textBox1.Text);
                        ParticipantsManager.addparti(p);
                    }
                    clear();
                    Program.l.Actualiser();
                    MessageBox.Show("Le club été crée avec succée");
                }
                else
                {
                    MessageBox.Show("Il faut que vous choisissez le président s'il vous plait");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Le nom du club a été déja utilisé"); ;
            }
         
            
            


            
        }
        private string Acces()
        {
            if (checkBox_Privée.Checked)
            {
                return "Ouverte";
            }
            else
                return "Fermer";
        }

        private void Crée_un_club__Load(object sender, EventArgs e)
        {
            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Hide();
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
            comboBox_Stagiaire.DisplayMember ="Id";
            
            comboBox_Formateur.DataSource = FormateurManager.Formateurs();
            comboBox_Formateur.DisplayMember = "Matricule";

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
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
        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton_Formateur.Checked = false;
            radioButton_Stagiaire.Checked = false;
            checkBox_Privée.Checked = false;
            comboBox_Formateur.Hide();
            comboBox_Stagiaire.Hide();
            comboBox_nomF.Hide();
            comboBox_nomS.Hide();
            comboBox_prenomF.Hide();
            comboBox_prenomS.Hide();
        }

        private void Crée_un_club__FormClosing(object sender, FormClosingEventArgs e)
        {
            //Liste_des_club l = new Liste_des_club();
            //l.dataGridView_list_club.DataSource = ClubManager.Affiche();
            //l.ShowDialog();
        }
        
    }
}
