using System;
using System.Text;
using System.Security.Cryptography;

namespace DAO
{
    public class PasswordUtility
    {
        public static string EncodePassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string encodedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return encodedPassword;
            }
        }
        public static bool ComparePasswords(string userInputPassword, string storedPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] userPasswordBytes = Encoding.UTF8.GetBytes(userInputPassword);
                byte[] userPasswordHash = sha256.ComputeHash(userPasswordBytes);

                string encodedUserPassword = BitConverter.ToString(userPasswordHash).Replace("-", "").ToLower();

                return string.Equals(encodedUserPassword, storedPassword, StringComparison.OrdinalIgnoreCase);
            }
        }
    }
}
