using PatientInformationSystem.Client.Core.IServices;
using PatientInformationSystem.Client.WPF.Library.Abstract;

namespace PatientInformationSystem.Client.WPF.Library.Commands
{
    public class LoginCommand : BaseCommand
    {
        private IAuthenticationService _authenticationService;

        public LoginCommand(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public override void Execute(object? parameter)
        {
            throw new NotImplementedException();
        }
    }
}