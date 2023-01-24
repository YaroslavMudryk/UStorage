using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace UStorage.Helpers
{
    public class TokenOptions
    {
        public const string Issuer = "UStorage ID";
        public const string Audience = "UStorage Client";
        const string SecretKey = "418b66dc05714f90b3fdc246ecc2dd371ca30e632f1744649f1df0cef16e2222"; // temp
        public const int LifeTimeInDays = 45;
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
    }
}
