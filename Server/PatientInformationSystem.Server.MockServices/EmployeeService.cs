using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Employee;
using PatientInformationSystem.Server.MockServices.ExtensionMethods;
using PatientInformationSystem.Server.PersistenceModel.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>();

        public EmployeeResponse CreateNewEmployee(NewEmployeeRequest newEmployee)
        {
            throw new NotImplementedException();
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
    }
}