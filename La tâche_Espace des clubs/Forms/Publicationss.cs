using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using La_tâche_Espace_des_clubs.Classes;
using La_tâche_Espace_des_clubs.Managers;

namespace La_tâche_Espace_des_clubs
{
    public partial class Publication : UserControl
    {
        public Publication()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Publicationss_Load(object sender, EventArgs e)
        {
            button1.Hide();
            panel1.Hide();
            button3.Show();
            button6.Hide();
            AfficherPic();

            comboBox1.DataSource = PublucationManager.Publications();
            comboBox1.DisplayMember = "IdPub";

            comboBox2.DataSource = RessourcesManager.Ressources();
            comboBox2.DisplayMember = "IdRess";


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 120;

            dataGridView1.AllowUserToAddRows = false;


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
            button6.Show();
            button3.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            button3.Show();
            button6.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        string imglocation = "";

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "All Images |*.JPG;*.PNG;*.BMP";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                imglocation = dialog.FileName.ToString();
                imglocation = openFileDialog.FileName;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            button1.Show();
            RessourcesManager.Ressources();
            byte[] Image = null;
            FileStream FS = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FS);
            Image = BR.ReadBytes((int)FS.Length);

            //Global._Connection.Open();
            //string sqlQuery = "insert into Ressources(Images)values(@Images)";
            //Global._Command = new SqlCommand(sqlQuery, Global._Connection);
            //Global._Command.Parameters.Add(new SqlParameter("@Images", Image));
            //Global._Command.ExecuteNonQuery();
            //Global._Connection.Close();

            //-----------------------------
            AjouterImage(Image);
            Publications publications = new Publications(textBox_statut.Text, Global.variable, Etat(), dateTimePicker1.Value);
            PublucationManager.AjouterPub(publications);

            Appartian app = new Appartian(comboBox1.Items.Count.ToString(), comboBox2.Items.Count.ToString());
            AppartienManager.infoapp(app);


            AfficherPic();
            MessageBox.Show("Ajoutée avec succée");


        }
        public static void AjouterImage(byte[] Ressource)
        {
            RessourcesManager.Ressources();

            DataRow ligne = Global.Dataset.Tables["Ressources"].NewRow();

            ligne["Images"] = Ressource;


            Global.Dataset.Tables["Ressources"].Rows.Add(ligne);
            RessourcesManager.sda.Update(Global.Dataset, "Ressources");
        }
        private void AfficherPic()
        {
            //            Global._Connection.Open();
            //            SqlDataReader reader;
            //            Global._Command.Connection = Global._Connection;
            //            Global._Command.CommandText = string.Format(@"select	Publications.Date,Publications.Statut,Ressources.Images
            //                                                          from	    Ressources  inner join Appartian
            //				                                                    on Ressources.IdRess = Appartian.IdRess
            //				                                                            inner join Publications
            //				                                                    on Publications.IdPub = Appartian.IdPub");

            //            reader = Global._Command.ExecuteReader();
            //            reader.Read();
            //            if (reader.HasRows)
            //            {




            //                byte[] Images = ((byte[])reader["Images"]);
            //                MemoryStream ms = new MemoryStream(Images);

            //                dataGridView1.Rows.Add(reader["Date"].ToString(),reader["Statut"].ToString(), Image.FromStream(ms));

            //                reader.Close();

            //            }
            //            Global._Connection.Close();
            dataGridView1.DataSource = PublucationManager.Publications1();

        }

        private string Etat()
        {
            if (checkBox_Public.Checked)
            {
                return "Public";
            }
            else
                return "Privée";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RessourcesManager.Ressources();
            byte[] Image = null;
            FileStream FS = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
            BinaryReader BR = new BinaryReader(FS);
            Image = BR.ReadBytes((int)FS.Length);
            AjouterImage(Image);

            Appartian app = new Appartian(comboBox1.Items.Count.ToString(), comboBox2.Items.Count.ToString());
            AppartienManager.infoapp(app);


            AfficherPic();
            MessageBox.Show("Ajoutée avec succée");
        }

    }
}
