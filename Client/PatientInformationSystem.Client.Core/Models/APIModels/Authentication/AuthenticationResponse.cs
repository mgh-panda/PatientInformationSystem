using PatientInformationSystem.Client.Core.Models.APIModels.Employee;

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