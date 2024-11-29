using Newtonsoft.Json;

namespace Domain.Entities.SAPEntities
{
    public class BusinessPartnerResponse
    {
        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; } = string.Empty;
        public List<Value> value { get; set; } = new();
    }

    public class Value
    {
        public BusinessPartner BusinessPartners { get; set; } = new();

        [JsonProperty("BusinessPartners/BPFiscalTaxIDCollection")]
        public BusinessPartnerFiscalTaxIDCollection BusinessPartnersBPFiscalTaxIDCollection { get; set; } = new();

        [JsonProperty("BusinessPartners/BPAddresses")]
        public BusinessPartnerAddress BusinessPartnersBPAddresses { get; set; } = new();
    }

}