using PatientInformationSystem.Server.Application.Models.Employee;

namespace PatientInformationSystem.Server.Application.Interfaces
{
    public interface IEmployeeService
    {
        public EmployeeResponse? GetById(int id);

        public IEnumerable<EmployeeResponse> GetAll();

        public EmployeeResponse CreateNewEmployee(NewEmployeeRequest newEmployeeRequest);
    }
}