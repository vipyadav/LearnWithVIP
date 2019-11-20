﻿using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorEx.ViewModels
{
    public class AppNotificationViewModel : BaseViewModel
    {
        public AppNotificationViewModel()
        {
            Mediator.Instance.Register("AddNewUser", OnNewUserAdded);
        }

        private void OnNewUserAdded(object _user)
        {
            var user = _user as User;
            Message = "Hey, I am send App Notification to new user whoese my name is " + user.Name;
        }

        private string message = "Hello from AppNotificationViewModel";
        public string Message
        {
            get { return message; }
            set { message = value; NotifyPropertyChanged(); }
        }

    }
}
