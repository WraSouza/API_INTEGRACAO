

namespace Domain.Entities.SAPEntities
{
     public class LoginRequest()
    {
        public LoginRequest(string userName, string password, string companyDB) : this()
        {
            UserName = userName;
            Password = password;
            CompanyDB = companyDB;
        }

        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;       
        public string CompanyDB { get; set; } = string.Empty;          
    }
}