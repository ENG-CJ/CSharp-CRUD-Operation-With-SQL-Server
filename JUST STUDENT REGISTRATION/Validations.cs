using ComponentFactory.Krypton.Toolkit;
namespace JUST_STUDENT_REGISTRATION
{
    internal class Validations
    {

        public static bool IsBlank(string id, string name, string Class, string mobile)
        {
            return id == "" || name == "" || Class == "" || mobile == "";
        }
        public static bool IsChecked(KryptonRadioButton Male, KryptonRadioButton Female)
        {
            return !Male.Checked && !Female.Checked;
        }


    }
}
