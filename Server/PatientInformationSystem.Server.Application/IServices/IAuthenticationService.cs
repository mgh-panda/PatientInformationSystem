using PatientInformationSystem.Server.Application.Models.Authentication;

namespace PatientInformationSystem.Server.Application.IServices
{
    public interface IAuthenticationService
    {
        public AuthenticationResponse? Authenticate(AuthenticationRequest authenticationRequest);
    }
}