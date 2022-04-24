using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace MessengerService
{
    // класс для хранения настроек аутентификационного токена
    public class AuthOptions
    {
        public const string ISSUER = "MessengerService"; // издатель токена
        public const string AUDIENCE = "MessengerClient"; // потребитель токена
        const string KEY = "ecivreS!8regnesseM!1927_tneilC!8regnesseM!1927_!!4646_!!!92"; // ключ для шифрации
        public const int LIFETIME = 1; // время жизни токена - 1 минута

        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
