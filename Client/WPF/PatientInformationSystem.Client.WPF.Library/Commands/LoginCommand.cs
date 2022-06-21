using PatientInformationSystem.Client.Core.Services;
using PatientInformationSystem.Client.Core.Models.APIModels.Authentication;
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
            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }
            //TODO: Raise authentication event
            Console.WriteLine(_authenticationService.Authenticate((AuthenticationRequest)parameter));
        }
    }
}