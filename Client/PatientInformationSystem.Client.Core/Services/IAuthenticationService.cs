using PatientInformationSystem.Client.Core.Models.APIModels.Authentication;

namespace PatientInformationSystem.Client.Core.Services
{
    public interface IAuthenticationService
    {
        public Task<AuthenticationResponse?> Authenticate(AuthenticationRequest authenticationRequest);
    }
}