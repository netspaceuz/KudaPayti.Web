using kudapoyti.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace kudapoyti.Service.Common.Attributes
{
    public class AuthenticationAttribute : IAuthenticationAttribute
    {
        public bool IsAuthed(List<string> rols, HttpContext httpContext)
        {
            var token = "";
            try
            {
                token = httpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadJwtToken(token);

                string role = jsonToken.Claims.FirstOrDefault(claim => claim.Type.ToLower().Contains("role"))?.Value;
                if (rols.Contains(role))
                    return true;
                return false;
            }
            catch
            {
                return false;
            }

        }
    }
}
