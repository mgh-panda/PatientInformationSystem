using PatientInformationSystem.Server.Application.Models.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientInformationSystem.Server.Application.Interfaces
{
    public interface IAuthenticationService
    {
        public AuthenticationResponse? Authenticate(AuthenticationRequest authenticationRequest);
    }
}
