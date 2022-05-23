namespace PatientInformationSystem.Server.Application.Models.Employee
{
    public class NewEmployeeRequest
    {
        public string Username { get; init; }
        public string Password { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public List<string> Roles { get; init; }
    }
}