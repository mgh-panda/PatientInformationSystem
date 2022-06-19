using PatientInformationSystem.Client.Core.Models.APIModels.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Client.Core.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;
        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<AuthenticationResponse?> Authenticate(AuthenticationRequest authenticationRequest)
        {
            var response = await _httpClient.PostAsJsonAsync("Authentication", authenticationRequest);
            return await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
        }
    }
}
