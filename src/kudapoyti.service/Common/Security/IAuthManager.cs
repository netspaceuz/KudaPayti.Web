namespace kudapoyti.Service.Common.Security
{
    public interface IAuthManager
    {
        public string GenerateToken(dynamic admin);
    }
}
