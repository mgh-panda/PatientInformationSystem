using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Models.Employee
{
    public record EmployeeResponse
    {
        public int Id { get; init; }
        public string Username { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public List<string> Roles { get; init; } = new List<string>();
    }
}
