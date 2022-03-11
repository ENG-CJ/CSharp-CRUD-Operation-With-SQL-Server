using ComponentFactory.Krypton.Toolkit;
using System;
namespace JUST_STUDENT_REGISTRATION
{
    public partial class AboutForm : KryptonForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReadMore(object sender, EventArgs e)
        {

        }

        private void SkipForm(object sender, EventArgs e)
        {
            StudentData student = new StudentData();
            student.Show();
            this.Hide();
        }
    }
}
