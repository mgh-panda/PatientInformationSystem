using PatientInformationSystem.Client.WPF.Library.Abstract;
using System.Windows.Input;

namespace PatientInformationSystem.Client.WPF.DesktopApplication.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username = string.Empty;

        public string Username
        {
            get { return _username; }
            set { _username = value; OnPropertyChanged(nameof(Username)); }
        }

        public ICommand LoginCommand { get; }
    }
}