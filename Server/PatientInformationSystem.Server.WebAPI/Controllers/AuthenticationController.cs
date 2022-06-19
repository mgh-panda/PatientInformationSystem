using Microsoft.AspNetCore.Mvc;
using PatientInformationSystem.Server.Application.IServices;
using PatientInformationSystem.Server.Application.Models.Authentication;

namespace PatientInformationSystem.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IAuthenticationService _authenticationService;
        private readonly ILogger<EmployeeController> _logger;

        public AuthenticationController(IAuthenticationService authenticationService, ILogger<EmployeeController> logger)
        {
            _authenticationService = authenticationService;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Authenticate(AuthenticationRequest authenticationRequest)
        {
            AuthenticationResponse? response = _authenticationService.Authenticate(authenticationRequest);

            if (response == null)
                return BadRequest(new { message = "Invalid username or password" });

            return Ok(response);
        }
    }
}