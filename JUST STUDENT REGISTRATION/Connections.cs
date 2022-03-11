using System.Data.SqlClient;
namespace JUST_STUDENT_REGISTRATION
{
    internal class Connections
    {

        // returning Connection From SQL SERVER
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conection = new SqlConnection("Data Source=DESKTOP-N9PT8FH\\SQLEXPRESS;Initial Catalog=JamhuuriyaUniv;Integrated Security=True");
            return conection;
        }

    }
}
