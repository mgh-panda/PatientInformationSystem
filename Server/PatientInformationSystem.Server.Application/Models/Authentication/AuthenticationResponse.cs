
using PatientInformationSystem.Server.PersistenceModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Models.Authentication
{
    public record AuthenticationResponse
    {
        public int Id { get; set; }
        public string Username { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public List<string> Roles { get; set; }
        public string Token { get; init; }
        public AuthenticationResponse(Employee employee, string token)
        {
            Id = employee.Id;
            Username = employee.Username;
            FirstName = employee.FirstName;
            LastName = employee.LastName;
            Roles = employee.Roles;
            Token = token;
        }
    }
}
