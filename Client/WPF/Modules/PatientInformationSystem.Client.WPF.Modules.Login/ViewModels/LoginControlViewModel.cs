using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PatientInformationSystem.Client.WPF.Modules.Login.ViewModels
{
    public class LoginControlViewModel : BindableBase
    {
        private string _username;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        public LoginControlViewModel()
        {

        }
    }
}
