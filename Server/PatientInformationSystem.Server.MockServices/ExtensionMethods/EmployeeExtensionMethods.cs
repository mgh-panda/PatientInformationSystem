using PatientInformationSystem.Server.Application.Models.Employee;
using PatientInformationSystem.Server.PersistenceModel.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.MockServices.ExtensionMethods
{
    internal static class EmployeeExtensionMethods
    {
        public static  EmployeeResponse ToEmployeeResponse(this Employee employee)
        {
            return new EmployeeResponse
            {
                Id = employee.Id,
                Username = employee.Username,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Roles = employee.Roles
            };
        }
    }
}
