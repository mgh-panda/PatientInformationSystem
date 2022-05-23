using System.Security.Cryptography;
using System.Text;

namespace PatientInformationSystem.Server.Application.Static
{
    public static class PasswordHelper
    {
        public static void CreateHashedPassword(string password, out byte[] hashedPassword, out byte[] passwordSalt)
        {
            using (var hashAlgorithm = new HMACSHA512())
            {
                passwordSalt = hashAlgorithm.Key;
                hashedPassword = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPasswordHash(string password, byte[] storedPasswordHash, byte[] storedPasswordSalt)
        {
            using (var hashAlgorithm = new HMACSHA512(storedPasswordSalt))
            {
                byte[] hashedPassword = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
                return hashedPassword.SequenceEqual(storedPasswordHash);
            }
        }
    }
}