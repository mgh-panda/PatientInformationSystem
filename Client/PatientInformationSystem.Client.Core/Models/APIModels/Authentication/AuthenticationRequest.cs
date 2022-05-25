using System.ComponentModel.DataAnnotations;

namespace PatientInformationSystem.Client.Core.Models.APIModels.Authentication
{
    public record AuthenticationRequest
    {
        [Required]
        public string Username { get; init; }
        [Required]
        public string Password { get; init; }

        public AuthenticationRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}