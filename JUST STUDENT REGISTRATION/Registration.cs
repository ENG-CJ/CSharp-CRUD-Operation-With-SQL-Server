using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;
namespace JUST_STUDENT_REGISTRATION

{
    public partial class Registration : KryptonForm
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, System.EventArgs e)
        {
            DialogResult Message = MessageBox.Show("Are You Sure To Exite?",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Message.HasFlag(DialogResult.No))
            {
                return;
            }
            else
                this.Hide();
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void Error404(object sender, System.EventArgs e)
        {
            FullData data = new FullData();
            data.Show();
            this.Hide();
        }

        private void NextPage(object sender, System.EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
            this.Hide();
        }
    }
}
