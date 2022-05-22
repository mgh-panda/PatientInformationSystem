using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Domain.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        public AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}