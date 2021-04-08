using Caliburn.Micro;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Mateus";
        private string _lastName = "Oliveira Brito";

        public string FullName { get => $"{FirstName} {LastName}"; }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;

            }

            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => FullName);
            }
        }
    }
}
