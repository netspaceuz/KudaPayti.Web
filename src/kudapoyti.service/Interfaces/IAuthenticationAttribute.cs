using Microsoft.AspNetCore.Http;

namespace kudapoyti.Service.Interfaces
{
    public interface IAuthenticationAttribute
    {
        public bool IsAuthed(List<string> rols, HttpContext httpContext);
    }
}
