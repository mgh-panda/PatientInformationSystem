using PatientInformationSystem.Client.Core.Models.APIModels.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Client.Core.Services
{
    public interface IEmployeeService
    {
        public Task<IEnumerable<EmployeeResponse>> GetAll();
        public Task<EmployeeResponse?> GetById(int id);
        public Task<EmployeeResponse?> GetByUsername(string username);
        public Task<EmployeeResponse?> CreateNewEmployee(NewEmployeeRequest newEmployeeRequest);
        public Task<EmployeeResponse?> DeleteById(int id);
        public Task<EmployeeResponse?> UpdateEmployee() 
    }
}
