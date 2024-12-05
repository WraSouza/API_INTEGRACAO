

namespace Domain.DTO.MagentoDTO
{
    public class ParentItemDTO
    {
        public double base_price { get; set; }
        public double base_row_total { get; set; }
        public int base_tax_amount { get; set; }
        public int base_tax_invoiced { get; set; }
        public string created_at { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public double price { get; set; }       
        public int qty_invoiced { get; set; }
        public int qty_ordered { get; set; }
        public int row_invoiced { get; set; }
        public double row_total { get; set; }
        public string sku { get; set; } = string.Empty;
        public int store_id { get; set; }   
        
    }
}