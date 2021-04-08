using Caliburn.Micro;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }
    }
}
