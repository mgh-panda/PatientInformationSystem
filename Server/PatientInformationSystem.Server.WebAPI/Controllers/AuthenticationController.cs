using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;

namespace PatientInformationSystem.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public AuthenticationController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticationRequest authenticationRequest)
        {
            AuthenticationResponse response = _employeeService.Authenticate(authenticationRequest);

            if (response == null)
                return BadRequest(new { message = "Invalid username or password" });

            return Ok(response);
        }
    }
}
