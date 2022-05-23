using Prism.Mvvm;

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