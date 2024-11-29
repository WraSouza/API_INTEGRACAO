

using System.Text;
using Domain.Entities.SAPEntities;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Infrastructure.Helpers
{
    public class LoginHelper(IOptions<LoginRequest> option, IMemoryCache memoryCache)
    {               
        private readonly string LOGIN_TOKEN = "SAPToken";
        private string? responseBody = string.Empty;  
        
        public async Task<LoginResponse> RealizarLogin()
        {
            if(memoryCache.TryGetValue(LOGIN_TOKEN, out LoginResponse? tokenSAP))
            {
                if(tokenSAP is not null)
                return tokenSAP;
            }

            LoginResponse? newResponse = new LoginResponse("","",0);

            HttpClientHandler clientHandler = new HttpClientHandler();
            
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };                      

            var login = new LoginRequest(option.Value.UserName, option.Value.Password, option.Value.CompanyDB);           

            string json = JsonConvert.SerializeObject(login);

            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

              using (var client = new HttpClient(clientHandler))
              {
                   HttpResponseMessage response = await client.PostAsync("https://linux-7lxj:50000/b1s/v1/Login", content);
             
                   responseBody = await response.Content.ReadAsStringAsync();

                   newResponse =  JsonConvert.DeserializeObject<LoginResponse>(responseBody);
              } 

            var memoryCacheEntryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(1800),
                SlidingExpiration = TimeSpan.FromSeconds(1500)
            };

             memoryCache.Set(LOGIN_TOKEN, newResponse,memoryCacheEntryOptions);            

           return newResponse ?? throw new ArgumentNullException();
        }
    }
}