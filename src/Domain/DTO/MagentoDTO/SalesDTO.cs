
using Domain.Entities.MagentoEntities;

namespace Domain.DTO.MagentoDTO
{
    public class SalesDTO
    {
        public string status { get; set; } = string.Empty;
        public int total_qty_ordered { get; set; }
        public List<SalesDTO> items { get; set; } = new();
        public BillingAddress billing_address { get; set; } = new();
        public Payment payment { get; set; } = new();
        public double? total_paid { get; set; }
        public double base_price { get; set; }
        public double price { get; set; }
        public string created_at { get; set; } = string.Empty;
        public int qty_ordered { get; set; }
        public double row_invoiced { get; set; }
        public string sku { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
    }
}