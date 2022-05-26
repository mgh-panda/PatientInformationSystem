using PatientInformationSystem.Client.Core.Models.APIModels.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Client.Core.Models.APIModels.Authentication
{
    public record AuthenticationResponse
    {
        public EmployeeResponse Employee { get; set; }
        public string Token { get; init; }
        public AuthenticationResponse(EmployeeResponse employee, string token)
        {
            Employee = employee;
            Token = token;
        }
    }
}
