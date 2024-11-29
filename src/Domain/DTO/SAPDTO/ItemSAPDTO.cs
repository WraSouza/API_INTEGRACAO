

using Newtonsoft.Json;

namespace Domain.DTO.SAPDTO
{
    public class ItemSAPDTO
    {
        public ItemSAPDTO(List<DTOItemSAP>? value)
        {
            this.value = value;
        }

        [JsonProperty("odata.metadata")]
        public string odatametadata { get; set; } = string.Empty;
        public List<DTOItemSAP>? value { get; set; } 
    }

     public class DTOItemSAP
    {
        public string ItemCode { get; set; } = string.Empty;
        public string ItemName { get; set; } = string.Empty;
        public object BarCode { get; set; } = string.Empty;
        public double QuantityOnStock { get; set; }
    }
}