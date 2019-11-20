using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEx.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        public UserViewModel()
        {
            Mediator<User>.Instance.Register("AddNewUser", OnNewUserAdded);
        }

        private void OnNewUserAdded(User user)
        {
            Message = "Hey, I am new user and my name is " + user.Name;
        }

        private string message = "Hello from UserViewModel";
        public string Message
        {
            get { return message; }
            set { message = value; NotifyPropertyChanged(); }
        }
    }
}
