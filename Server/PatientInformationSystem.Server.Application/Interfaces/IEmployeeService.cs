using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Application.Models.Employee;
using PatientInformationSystem.Server.PersistenceModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Interfaces
{
    public interface IEmployeeService
    {
        public EmployeeResponse? GetById(int id);
        public IEnumerable<EmployeeResponse> GetAll();
        public EmployeeResponse CreateNewEmployee(NewEmployeeRequest newEmployeeRequest);
    }
}
