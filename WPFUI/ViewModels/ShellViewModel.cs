using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Screen
    {
        private string _firstName = "Mateus";
        private string _lastName = "Oliveira Brito";
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
            }
        }

    }
}
