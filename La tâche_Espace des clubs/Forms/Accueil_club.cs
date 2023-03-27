using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using La_tâche_Espace_des_clubs.Classes;
using La_tâche_Espace_des_clubs.Managers;

namespace La_tâche_Espace_des_clubs
{
    public partial class Accueil_club : Form
    {
        public Accueil_club()
        {
            InitializeComponent();
        }

        

        //private void load_Next_Image()
        //{
        //    if (ImageNumber == 10)
        //    {
        //        ImageNumber = 1;
        //    }

        //    SlidePic.ImageLocation = string.Format(@"Images\{0}",ImageNumber);
        //    ImageNumber++;
        //}

        private void Accueil_du_club_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource =

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.AllowUserToAddRows = false;

            AfficherPic();
            button1.Hide();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();
            liste_des_membress1.Hide();
            inviter1.Hide();
            #endregion
            ClubManager.info(Global.variable);

            label1.Text = Global.variableNomClub;
            label3.Text = Global.variableSujet;
            label5.Text = Global.variableAccée;
            label6.Text = Global.variableRégles;
            label4.Text = Global.variableParti;
            //foreach (DataRow ligne in Global.Dataset.Tables["Clubs"].Rows)
            //{

            //    if (ligne["NomClub"].ToString() == Global.variable)
            //    {
            //        label1.Text = ligne["NomClub"].ToString();
            //        label3.Text = ligne["Sujets"].ToString();
            //        label5.Text = ligne["Acces"].ToString();
            //        label6.Text = ligne["Régles"].ToString();
            //        label4.Text = ligne["Participant"].ToString();
            //    }

            //}

        }


        private void button_Quiter_groupe_Click(object sender, EventArgs e)
        {

        }

        private void button_Notifications_Click_1(object sender, EventArgs e)
        {
            button1.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();
            inviter1.Hide();
            liste_des_membress1.Hide();

            #endregion


        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }



        private void button3_Click_1(object sender, EventArgs e)
        {
            //Liste_des_club list = new Liste_des_club();
            //list.ShowDialog();
            this.Close();
            

        }



        private void button_liste_m_Click_1(object sender, EventArgs e)
        {
            liste_des_membress1.Actualiser();
            liste_des_membress1.Show();
            button1.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();
            inviter1.Hide();
            panel4.Hide();

            #endregion


        }

        private void Planification_Click_1(object sender, EventArgs e)
        {
            planification1.Show();
            button1.Show();
            #region Hide

            publication1.Hide();
            modifier_membres1.Hide();

            liste_des_membress1.Hide();
            inviter1.Hide();
            panel4.Hide();
            #endregion


        }

        private void Publication_Click_1(object sender, EventArgs e)
        {
            publication1.Show();
            button1.Show();
            #region Hide
            planification1.Hide();
            inviter1.Hide();

            modifier_membres1.Hide();

            liste_des_membress1.Hide();
            panel4.Hide();
            #endregion


        }

        private void button_modifier_m_Click(object sender, EventArgs e)
        {
            modifier_membres1.Show();
            button1.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            inviter1.Hide();


            liste_des_membress1.Hide();
            panel4.Hide();
            #endregion


        }

        private void Rapport_Click_1(object sender, EventArgs e)
        {
            button1.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();
            inviter1.Hide();
            panel4.Hide();
            liste_des_membress1.Hide();

            #endregion


        }

        private void button_Quiter_groupe_Click_1(object sender, EventArgs e)
        {
            

            DialogResult dialog = MessageBox.Show("Vous-voulez vraiment Quittez ce club", "Quitter le club", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //private int ImageNumber =1;
        //private void loadNextImage()
        //{
        //    Global._Connection.Open();
        //    SqlDataReader reader;
        //    if ()
        //    {
        //        ImageNumber = 1;
        //    }
        //    SlidePic.ImageLocation = string.Format("select * from Ressources where IdRess ='{0}'",Image);
        //    ImageNember++;
        //}

        private void SlidePic_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AfficherPic();
            button1.Hide();
            panel4.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();

            liste_des_membress1.Hide();
            inviter1.Hide();

            #endregion
        }

        private void button_Inviter_Click(object sender, EventArgs e)
        {
         
            inviter1.Show();
            button1.Show();
            #region Hide
            planification1.Hide();
            publication1.Hide();
            modifier_membres1.Hide();

            liste_des_membress1.Hide();
            panel4.Hide();
            #endregion
        }

        private void Accueil_club_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Liste_des_club list = new Liste_des_club();
            //list.ShowDialog();

        }

        private void Accueil_club_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void AfficherPic()
        {

            
            BindingSource bs = new BindingSource();

            bs.DataSource = PublucationManager.Publications2();

            dataGridView1.DataSource = bs;
            
            //dataGridView1.DataSource = null;
            //dataGridView1.Refresh();
            ////PublucationManager.Publications2();
            //dataGridView1.DataSource = PublucationManager.Publications2();

            //            Global._Connection.Open();
            //            SqlDataReader reader;
            //            Global._Command.Connection = Global._Connection;
            //            Global._Command.CommandText = string.Format(@"  select Ressources.Images
            //                                                            from	Publications inner join Appartian
            //			
            //			                                                        on	Publications.IdPub = Appartian.IdPub	
            //				                                                                 inner join Ressources	
            //			                                                        on	Ressources.IdRess = Appartian.IdRess
            //                                                            where	Etat='Public'");

            //            reader = Global._Command.ExecuteReader();
            //            reader.Read();
            //            if (reader.HasRows)
            //            {

            //                byte[] Images = ((byte[])reader["Images"]);


            //                MemoryStream ms = new MemoryStream(Images);
            //                pictureBox2.Image = Image.FromStream(ms);

            //                reader.Close();

            //            }
            //            Global._Connection.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        

        
    }
}
