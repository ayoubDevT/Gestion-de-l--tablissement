using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using La_tâche_Espace_des_clubs.Classes;

namespace La_tâche_Espace_des_clubs.Forms
{
    public partial class InfoClub : Form
    {
        public InfoClub()
        {
            InitializeComponent();
        }

        private void InfoClub_Load(object sender, EventArgs e)
        {
            Club club = new Club();
        }
    }
}
