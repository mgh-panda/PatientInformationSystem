﻿using Prism.Mvvm;

namespace PatientInformationSystem.Client.WPF.Modules.Login.ViewModels
{
    public class ViewAViewModel : BindableBase
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewAViewModel()
        {
            Message = "View A from your Prism Module";
        }
    }
}