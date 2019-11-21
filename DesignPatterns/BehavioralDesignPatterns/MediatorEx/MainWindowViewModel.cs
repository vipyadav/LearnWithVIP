using Common;
using MediatorEx.ViewModels;
using Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MediatorEx
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand AddNewUserCommand { get; private set; }

        public MainWindowViewModel()
        {
           Users = new ObservableCollection<User>();
           AddNewUserCommand = new RelayCommand(x => AddNewUser());
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; NotifyPropertyChanged(); }
        }

        public ObservableCollection<User> Users { get; set; }

        private void AddNewUser()
        {
            var user = new User { Name = Name };
            Users.Add(user);
            Mediator<User>.Instance.SendMessage("AddNewUser", user);
        }
    }
}
