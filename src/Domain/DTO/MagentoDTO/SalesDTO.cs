
using Domain.Entities.MagentoEntities;

namespace Domain.DTO.MagentoDTO
{
    public class SalesDTO
    {
        public string? status { get; set; } 
        public List<SalesDTO>? items { get; set; } 
        public BillingAddress? billing_address { get; set; }
        public Payment? payment { get; set; }
        public double price { get; set; }
        public string created_at { get; set; } = string.Empty;
        public int qty_ordered { get; set; }
        public double row_invoiced { get; set; }
        public string? sku { get; set; }
        public string? name { get; set; } 
    }
}