using PatientInformationSystem.Server.Application.Models.Employee;

namespace PatientInformationSystem.Server.Application.IServices
{
    public interface IEmployeeService
    {
        public EmployeeResponse? GetById(int id);

        public IEnumerable<EmployeeResponse> GetAll();

        public EmployeeResponse CreateNewEmployee(NewEmployeeRequest newEmployeeRequest);
    }
}