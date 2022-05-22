using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Models.Authentication
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
