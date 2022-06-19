namespace PatientInformationSystem.Client.Core.Models.APIModels.Employee
{
    public record NewEmployeeRequest
    {
        public string Username { get; init; } = string.Empty;
        public string Password { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public List<string> Roles { get; init; } = new List<string>();
    }
}