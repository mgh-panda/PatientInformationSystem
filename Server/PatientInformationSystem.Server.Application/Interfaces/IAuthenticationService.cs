using PatientInformationSystem.Server.Application.Models.Authentication;

namespace PatientInformationSystem.Server.Application.Interfaces
{
    public interface IAuthenticationService
    {
        public AuthenticationResponse? Authenticate(AuthenticationRequest authenticationRequest);
    }
}