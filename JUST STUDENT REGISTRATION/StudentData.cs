using ComponentFactory.Krypton.Toolkit;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace JUST_STUDENT_REGISTRATION
{
    public partial class StudentData : KryptonForm
    {
        public SqlConnection Connection;
        public string gender;
        public string updatingID;
        public StudentData()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Close(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are You Sure To Exit?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message.HasFlag(DialogResult.No))
                return;
            else
            {
                Registration form = new Registration();
                form.Show();
                this.Hide();
            }
        }

        private void SaveData(object sender, EventArgs e)
        {
            // checking blank area
            if (Validations.IsBlank(id.Text, name.Text, Class.Text, mobile.Text))
                MessageBox.Show("Invalid Input\nPlz Enter the Information", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            // checking radioButtons
            else if (Validations.IsChecked(male, Female))
                MessageBox.Show("Please Select Gender", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (male.Checked) gender = "Male"; else gender = "Female";
                Container container = new Container();
                container.AddStudent(
                    id.Text,
                    name.Text,
                    gender,
                    date,
                    int.Parse(mobile.Text),
                    Class.Text
                    );
                container.ClearTextBox(id, name, mobile, male, Female, Class);
                container.GetStudents(StudentRecord);

            }

        }

        private void StudentData_Load(object sender, EventArgs e)
        {
            Container container = new Container();
            container.GetStudents(StudentRecord);
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updatingID = (string)StudentRecord.SelectedRows[0].Cells[0].Value;
            id.Text = (string)StudentRecord.SelectedRows[0].Cells[0].Value;
            name.Text = (string)StudentRecord.SelectedRows[0].Cells[1].Value;
            gender = (string)StudentRecord.SelectedRows[0].Cells[2].Value;
            if (gender == "Male") male.Checked = true; else Female.Checked = true;
            date.Value = (DateTime)StudentRecord.SelectedRows[0].Cells[3].Value;
            mobile.Text = StudentRecord.SelectedRows[0].Cells[4].Value.ToString();
            Class.Text = (string)StudentRecord.SelectedRows[0].Cells[5].Value;

        }

        private void UpdateStudent(object sender, EventArgs e)
        {
            if (Validations.IsBlank(id.Text, name.Text, Class.Text, mobile.Text))
                MessageBox.Show("Invalid Input\nPlz Select Student To Update", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else

            {
                Container container = new Container();
                if (male.Checked) gender = "Male"; else gender = "Female";
                container.UpdateStudent(
                     id.Text,
                        name.Text,
                        gender,
                        date,
                        int.Parse(mobile.Text),
                        Class.Text, updatingID);
                container.ClearTextBox(id, name, mobile, male, Female, Class);
                container.GetStudents(StudentRecord);
            }

        }

        private void DeleteStudent(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Are yiu Sure To Delete This student?",
                "Confirm To Access", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message != DialogResult.Yes)
            {

                return;
            }
            else
            {
                Container container = new Container();
                container.DeleteStudent(int.Parse(id.Text));
                container.GetStudents(StudentRecord);
                container.ClearTextBox(id, name, mobile, male, Female, Class);

            }
        }
    }
}
