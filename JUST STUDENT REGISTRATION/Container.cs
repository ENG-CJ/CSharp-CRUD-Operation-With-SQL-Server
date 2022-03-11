using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace JUST_STUDENT_REGISTRATION
{
    internal class Container
    {
        public static SqlConnection Connection;

        public void GetStudents(KryptonDataGridView dataGridView)
        {
            Connection = Connections.GetSqlConnection();
            SqlCommand command = new SqlCommand("getStudents", Connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataAdapter reader = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            reader.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }

        public void AddStudent(string id, string name, string gender, KryptonDateTimePicker date,
            int mobile, string Class)
        {
            try
            {
                Connection = Connections.GetSqlConnection();
                Connection.Open();
                SqlCommand command = new SqlCommand("addStudent", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birth", date.Value.ToShortDateString());
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@class", Class);
                command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Sucessfully Added", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"error Occured Due\n{e}", "DbERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        public void UpdateStudent(
            string id, string name, string gender, KryptonDateTimePicker date,
            int mobile, string Class, string upID)
        {
            try
            {
                Connection = Connections.GetSqlConnection();
                Connection.Open();
                SqlCommand command = new SqlCommand("updateStudent", Connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@birth", date.Value.ToShortDateString());
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@class", Class);
                command.Parameters.AddWithValue("@upid", upID);
                command.ExecuteNonQuery();
                Connection.Close();
                MessageBox.Show("Sucessfully updated", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show($"error Occured Due\n{e}", "DbERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DeleteStudent(int id)
        {
            Connection = Connections.GetSqlConnection();
            Connection.Open();
            SqlCommand command = new SqlCommand("deleteStudent", Connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            MessageBox.Show("Sucessfully Deleted", "Database", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Connection.Close();
        }

        public void ClearTextBox(KryptonTextBox id, KryptonTextBox name,
            KryptonTextBox mobile,
             KryptonRadioButton male, KryptonRadioButton female,
            KryptonComboBox comobo)
        {
            if (male.Checked)
                male.Checked = false;
            else if (female.Checked)
                female.Checked = false;

            id.Clear();
            name.Clear();
            mobile.Clear();
            comobo.Text = "";

        }
    }
}
