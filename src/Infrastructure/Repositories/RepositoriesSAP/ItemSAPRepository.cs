
using System.Net;
using Domain.DTO.SAPDTO;
using Domain.Entities.SAPEntities;
using Domain.Repositories.SAPRepositories;
using Infrastructure.Helpers;
using Newtonsoft.Json;

namespace Infrastructure.Repositories.RepositoriesSAP
{
    public class ItemSAPRepository(LoginHelper loginHelper) : IItemRepository
    {
      
        public async Task<ItemSAPDTO> GetAllItemsAsync()
        {
            LoginResponse loginResponse = await loginHelper.RealizarLogin();

            string url = "https://linux-7lxj:50000/b1s/v1/Items?$select=ItemCode,ItemName,BarCode,QuantityOnStock&$filter=startswith(ItemCode,'4')";

           HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };            
                

            using (var client = new HttpClient(clientHandler))
            {
                CookieContainer cookie = new CookieContainer();              

                 client.DefaultRequestHeaders.Add("Cookie",$"B1SESSION={loginResponse.SessionId};ROUTEID=.node1");                   

                 var responseLogin = client.GetAsync(url);

                 string datasFromStore = await responseLogin.Result.Content.ReadAsStringAsync();

                 ItemSAPDTO? allItems = JsonConvert.DeserializeObject<ItemSAPDTO>(datasFromStore);

                 return allItems ?? new ItemSAPDTO(null);                  

            }
        }
    }
}