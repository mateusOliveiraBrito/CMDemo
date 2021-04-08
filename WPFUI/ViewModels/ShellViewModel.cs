using Caliburn.Micro;
using WPFUI.Models;
using WPFUI.Views;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private string _firstName;
        private string _lastName;
        private BindableCollection<PersonModel> _people;
        private PersonModel _peopleSelected;

        public ShellViewModel()
        {
            _people = new BindableCollection<PersonModel>();

            People.Add(new PersonModel() { Name = "Mateus", LastName = "Oliveira Brito" });
            People.Add(new PersonModel() { Name = "Altair", LastName = "Garcia" });
            People.Add(new PersonModel() { Name = "André", LastName = "Baltieri" });
            People.Add(new PersonModel() { Name = "Marcos", LastName = "Paulo" });
            People.Add(new PersonModel() { Name = "Ana", LastName = "Clara" });
            People.Add(new PersonModel() { Name = "Jose", LastName = "Silva" });
            People.Add(new PersonModel() { Name = "Lúcio", LastName = "Malfoy" });
            People.Add(new PersonModel() { Name = "Alastor", LastName = "Moody" });
        }

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

        public BindableCollection<PersonModel> People
        {
            get { return _people; }
            set { _people = value; }
        }

        public PersonModel PeopleSelected
        {
            get { return _peopleSelected; }
            set
            {
                _peopleSelected = value;
                NotifyOfPropertyChange(() => PeopleSelected);

                if (PeopleSelected != null)
                {
                    FirstName = PeopleSelected.Name;
                    LastName = PeopleSelected.LastName;

                    NotifyOfPropertyChange(() => FirstName);
                    NotifyOfPropertyChange(() => LastName);
                }
            }
        }

        public bool CanClearText(string firstName, string lastName) => !string.IsNullOrWhiteSpace(firstName) || !string.IsNullOrWhiteSpace(lastName);

        public void ClearText(string firstName, string lastName)
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            PeopleSelected = null;

            NotifyOfPropertyChange(() => FirstName);
            NotifyOfPropertyChange(() => LastName);
            NotifyOfPropertyChange(() => PeopleSelected);
        }

        public void LoadPageOne()
        {
            ActivateItem(new FirstChildViewModel());
        }

        public void LoadPageTwo()
        {
            ActivateItem(new SecondChildViewModel());
        }
    }
}
