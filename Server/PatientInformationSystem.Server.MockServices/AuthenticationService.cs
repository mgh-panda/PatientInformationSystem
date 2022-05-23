using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.PersistenceModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.MockServices
{
    internal class AuthenticationService : IAuthenticationService
    {
        IEmployeeService _employeeService;
        public AuthenticationService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest)
        {
            Employee? employee = _employeeService.GetAll().FirstOrDefault(e => e.Username == authenticationRequest.Username);
            if (employee == null)
                return null;
            return new AuthenticationResponse(employee, "token");
        }
    }
}
