using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Managers;

namespace La_tâche_Espace_des_clubs
{
    public partial class Liste_des_clubs_singin : UserControl
    {
        public Liste_des_clubs_singin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Liste_des_clubs_singin_Load(object sender, EventArgs e)
        {
            dataGridView_list_club.DataSource = ClubManager.Clubs();
            dataGridView_list_club.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_Crée_club_Click(object sender, EventArgs e)
        {

        }

        private void button_Trouver_club_Click(object sender, EventArgs e)
        {

        }
    }
}
