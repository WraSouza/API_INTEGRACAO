

using System.Net;
using Domain.DTO.SAPDTO;
using Domain.Entities.SAPEntities;
using Domain.Repositories.SAPRepositories;
using Infrastructure.Helpers;

namespace Infrastructure.Repositories.RepositoriesSAP
{
    public class BusinessPartnerRepository(LoginHelper loginHelper) : IBusinessPartnerRepository
    {
        public Task<BusinessPartner> CreateBusinessPartnerAsync(BusinessPartner businessPartner)
        {
            throw new NotImplementedException();
        }

        public Task<BusinessPartnerDTO> GetAllBusinessPartnerAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> VerifyIfBusinessPartnerExistsAsync(string cpf)
        {
            LoginResponse loginResponse = await loginHelper.RealizarLogin();

            bool bpExist = false;

            string url = $"https://linux-7lxj:50000/b1s/v1/$crossjoin(BusinessPartners,BusinessPartners/BPFiscalTaxIDCollection,BusinessPartners/BPAddresses)?$expand=BusinessPartners($select=CardCode, CardName),BusinessPartners/BPFiscalTaxIDCollection($select=BPCode,TaxId1,TaxId4),BusinessPartners/BPAddresses($select=BPCode,Street,Block,ZipCode, City, State,StreetNo)&$filter=BusinessPartners/CardCode eq BusinessPartners/BPFiscalTaxIDCollection/BPCode and BusinessPartners/BPFiscalTaxIDCollection/BPCode eq BusinessPartners/BPAddresses/BPCode and BusinessPartners/BPFiscalTaxIDCollection/TaxId4 eq '{cpf}'&$top=1";

            HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };            
                

            using (var client = new HttpClient(clientHandler))
            {
                CookieContainer cookie = new CookieContainer();              

                 client.DefaultRequestHeaders.Add("Cookie",$"B1SESSION={loginResponse.SessionId};ROUTEID=.node1");                   

                 var responseLogin = client.GetAsync(url);

                 string datasFromStore = await responseLogin.Result.Content.ReadAsStringAsync();

                 int quantidadeRegistro = datasFromStore.Count();

                 if(quantidadeRegistro > 0)
                 {
                    bpExist = true;

                    return bpExist;
                 }

                 return bpExist;
                 
            }
            
        }
    }
}