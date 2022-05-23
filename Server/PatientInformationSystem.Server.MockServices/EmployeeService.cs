using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.PersistenceModel.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        public AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest)
        {
            Employee? employee = _employees.FirstOrDefault(e => e.Username == authenticationRequest.Username && e.Password == authenticationRequest.Password);
            if (employee == null)
                return null;
            return new AuthenticationResponse(employee, "token");
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}