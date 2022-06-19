using PatientInformationSystem.Server.Application.IServices;
using PatientInformationSystem.Server.Application.Models.Employee;
using PatientInformationSystem.Server.Application.Static;
using PatientInformationSystem.Server.MockServices.ExtensionMethods;
using PatientInformationSystem.Server.PersistenceModel.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> _employees = new List<Employee>();

        public EmployeeResponse CreateNewEmployee(NewEmployeeRequest newEmployee)
        {
            Employee employee = new Employee();
            employee.Id = _employees.Count;
            employee.Username = newEmployee.Username;
            SetPassword(newEmployee.Password, employee);
            employee.FirstName = newEmployee.FirstName;
            employee.LastName = newEmployee.LastName;
            employee.Roles = newEmployee.Roles;
            _employees.Add(employee);
            return employee.ToEmployeeResponse();
        }

        public IEnumerable<EmployeeResponse> GetAll()
        {
            var employees = new List<EmployeeResponse>();
            foreach (var employee in _employees)
            {
                employees.Add(employee.ToEmployeeResponse());
            }
            return employees;
        }

        public EmployeeResponse? GetById(int id)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == id);
            if (employee == null)
                return null;
            return employee.ToEmployeeResponse();
        }

        public EmployeeResponse? GetByUsername(string username)
        {
            var employee = _employees.FirstOrDefault(e => e.Username == username);
            if (employee == null)
                return null;
            return employee.ToEmployeeResponse();
        }

        private void SetPassword(string password, Employee employee)
        {
            byte[] passwordHash;
            byte[] passwordSalt;
            PasswordHelper.CreateHashedPassword(password, out passwordHash, out passwordSalt);
            employee.PasswordHash = passwordHash;
            employee.PasswordSalt = passwordSalt;
        }
    }
}