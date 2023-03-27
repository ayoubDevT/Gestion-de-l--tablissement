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
    public partial class Planification : UserControl
    {
        public Planification()
        {
            InitializeComponent();
        }

        private void Planifications_Load(object sender, EventArgs e)
        {
            dataGridView_Planification.DataSource = PlanificationManager.Afficher();
            dataGridView_Planification.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            


            comboBox_Planification.DataSource = PlanificationManager.Afficher();
            comboBox_Planification.DisplayMember = "IdPla";

            dataGridView_Activitée.DataSource = ActivitéeManager.Activitée();
            dataGridView_Activitée.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Supprimer_Click(object sender, EventArgs e)
        {

        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {

        }

        private void button_Ajouter_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Activitées activitée = new Activitées(textBox3.Text, textBox1.Text, int.Parse(textBox2.Text),int.Parse(dataGridView_Planification.SelectedRows[0].Cells["IdPla"].Value.ToString()) );
                
                ActivitéeManager.AjouterAct(activitée);
                dataGridView_Activitée.DataSource = ActivitéeManager.Activitée();

            }
            catch (Exception)
            {

                MessageBox.Show("Format d'HeureDébut est invalide (hh:mm)ou(h:m) ou bien La durée est longue (dépassée 10 heures)");
            }
        }

        private void button_Ajouter_Click_1(object sender, EventArgs e)
        {
            try
            {
                Planifications planification = new Planifications(dateTimePicker3.Value, textBox6.Text, int.Parse(textBox5.Text), textBox4.Text, Global.variable);
                PlanificationManager.AjouterPla(planification);
                comboBox_Planification.DataSource = PlanificationManager.Afficher();
                comboBox_Planification.DisplayMember = "IdPla";
                dataGridView_Planification.DataSource = PlanificationManager.Afficher();
            }
            catch (Exception)
            {

                MessageBox.Show("Format d'HeureDébut est invalide (hh:mm)ou(h:m) ou bien La durée est longue (dépassée 10 heures)");
            }
            dataGridView_Planification.DataSource = PlanificationManager.Afficher();

        }

        private void dataGridView_Planification_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_Planification.SelectedRows.Count != 0)
            {
                DataGridViewRow ligne = dataGridView_Planification.SelectedRows[0];

                comboBox_Planification.Text = ligne.Cells["IdPla"].Value.ToString();
                

            }

        }


    }
}
