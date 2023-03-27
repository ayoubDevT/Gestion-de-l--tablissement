using System.Data.SqlClient;
using System.Data;

namespace La_tâche_Espace_des_clubs
{
    public static class Global
    {
        public static SqlConnection _Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Club;Integrated Security=True");
        public static DataSet Dataset = new DataSet();
        public static DataView _DataView = new DataView();

        public static SqlCommand _Command = new SqlCommand();

        public static string variable = "";
        public static string variableNomClub = "";
        public static string variableSujet = "";
        public static string variableAccée = "";
        public static string variableParti = "";
        public static string variableRégles = ""; 
    }
}
