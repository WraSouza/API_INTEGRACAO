using Newtonsoft.Json;

namespace Domain.DTO.SAPDTO
{
    public class BusinessPartnerDTO
    {
         [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; } = string.Empty;
        public List<BusinessPartnerViewModel>? value { get; set; }

        [JsonProperty("odata.nextLink")]
        public string odatanextLink { get; set; } = string.Empty;
    }

    public class BusinessPartnerViewModel
    {
        public string CardCode { get; set; } = string.Empty;
        public string CardName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Phone1 { get; set; } = string.Empty;     
        public string City { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;    
        public string Block { get; set; } = string.Empty;   
    }
}