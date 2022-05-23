using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Application.Models.Employee;
using PatientInformationSystem.Server.PersistenceModel.Entities;

namespace PatientInformationSystem.Server.MockServices
{
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> _employees = new List<Employee>();
        public Employee CreateNewEmployee(NewEmployeeRequest newEmployee)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
        public Employee? GetByUsername(string username)
        {
            return _employees.FirstOrDefault(e => e.Username == username);
        }
    }
}