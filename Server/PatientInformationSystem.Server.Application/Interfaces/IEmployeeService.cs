using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Interfaces
{
    public interface IEmployeeService
    {
        public AuthenticationResponse Authenticate(AuthenticationRequest authenticationRequest);
        public Employee? GetById(int id);
        public IEnumerable<Employee> GetAll();
    }
}
