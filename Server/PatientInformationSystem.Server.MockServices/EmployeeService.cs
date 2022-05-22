using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Domain.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEnumerable<Employee> _employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Username = "Doctor",
                Password = "password",
                FirstName = "Steven",
                LastName = "Strange",
                Roles = new List<string>
                {
                    "Doctor"
                }
            },
            new Employee
            {
                Id = 2,
                Username = "Nurse",
                Password = "password2",
                FirstName = "Wanda",
                LastName = "Maximoff",
                Roles = new List<string>
                {
                    "Nurse"
                }
            }
        };
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