using ComponentFactory.Krypton.Toolkit;
namespace JUST_STUDENT_REGISTRATION
{
    public partial class FullData : KryptonForm
    {
        public FullData()
        {
            InitializeComponent();
        }

        private void BackBtn(object sender, System.EventArgs e)
        {
            Registration data = new Registration();
            data.Show();
            this.Hide();
        }
    }
}
