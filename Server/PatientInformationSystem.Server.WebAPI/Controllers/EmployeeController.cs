using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatientInformationSystem.Server.Application.Interfaces;
using PatientInformationSystem.Server.Application.Models.Authentication;
using PatientInformationSystem.Server.Domain.Entities;

namespace PatientInformationSystem.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService _employeeService;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeService employeeService, ILogger<EmployeeController> logger)
        {
            _employeeService = employeeService;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_employeeService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Employee employee = _employeeService.GetById(id);

            if (employee == null)
                return BadRequest(new { message = "Employee not found" });

            return Ok(employee);
        }
    }
}
