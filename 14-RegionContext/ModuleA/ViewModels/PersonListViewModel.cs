using ModuleA.Business;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    public class PersonListViewModel : BindableBase
    {
        private ObservableCollection<Person>? _people;
        public ObservableCollection<Person>? People
        {
            get { return _people; }
            set { SetProperty(ref _people, value); }
        }

        public PersonListViewModel()
        {
            CreatePeople();
        }

        private void CreatePeople()
        {
            var people = new ObservableCollection<Person>();
            for (int i = 0; i < 10; i++)
            {
                people.Add(new Person()
                {
                    FirstName = string.Format("First {0}", i),
                    LastName = string.Format("Last {0}", i),
                    Age = i
                });
            }

            People = people;
        }
    }
}
