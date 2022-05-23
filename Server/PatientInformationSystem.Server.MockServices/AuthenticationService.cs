using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Application.Models.Employee;

namespace PatientInformationSystem.Server.MockServices
{
    public class AuthenticationService : IAuthenticationService
    {
        private IEmployeeService _employeeService;

        public AuthenticationService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public AuthenticationResponse? Authenticate(AuthenticationRequest authenticationRequest)
        {
            EmployeeResponse? employee = _employeeService.GetAll().FirstOrDefault(e => e.Username == authenticationRequest.Username);
            if (employee == null)
                return null;

            return new AuthenticationResponse(employee, "token");
        }
    }
}