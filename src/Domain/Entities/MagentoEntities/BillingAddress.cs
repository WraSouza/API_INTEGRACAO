

namespace Domain.Entities.MagentoEntities
{
    public class BillingAddress
    {
        public string city { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string postcode { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string region_code { get; set; } = string.Empty;
        public List<string> street { get; set; } = new();
        public string telephone { get; set; } = string.Empty;
        public string vat_id { get; set; } = string.Empty;
    }
}