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
    public partial class Inviter : UserControl
    {
        public Inviter()
        {
            InitializeComponent();
        }

        private void Inviter_Load(object sender, EventArgs e)
        {
            dataGridView_dm.DataSource = DMManager.DM();
            dataGridView_dm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            //comboBox_Num.DataSource = DMManager.DM();
            //comboBox_Num.DisplayMember = "Matricule";

            //comboBox_nom.DataSource = DMManager.DM();
            //comboBox_nom.DisplayMember = "Nom";

            //comboBox_prenom.DataSource = DMManager.DM();
            //comboBox_prenom.DisplayMember = "Prenom";
           
            //comboBox_IdDA.DataSource = DMManager.DM();
            //comboBox_IdDA.DisplayMember = "IdDA";

            //comboBox_IdDA.Hide();
            //comboBox_nom.Hide();
            //comboBox_Num.Hide(); 
            //comboBox_prenom.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Participants p = new Participants(dataGridView_dm.CurrentRow.Cells["Matricule"].Value.ToString(), dataGridView_dm.CurrentRow.Cells["Nom"].Value.ToString(), dataGridView_dm.CurrentRow.Cells["Prenom"].Value.ToString(), "Membre", Global.variable);
            ParticipantsManager.addparti(p);

            MessageBox.Show("Test1");
            DMManager.supDM(int.Parse(dataGridView_dm.CurrentRow.Cells["IdDA"].Value.ToString()));
            MessageBox.Show("Test3");
            dataGridView_dm.DataSource = null;
            dataGridView_dm.DataSource = DMManager.DM();


            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
