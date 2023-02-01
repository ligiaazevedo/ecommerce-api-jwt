using Ligia.Ecommerce.API.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Ligia.Ecommerce.API.Application
{
    public class TokenService
    {
        public string GenerateToken(Customer customer)
        {
            var key = Encoding.ASCII.GetBytes("8b54477a-10d0-471c-925e-eb57f77d25de");

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, customer.UserName)
                }),
                Expires = DateTime.UtcNow.AddSeconds(3600),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
