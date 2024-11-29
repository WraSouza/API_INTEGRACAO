
namespace Domain.Entities.SAPEntities
{
    public class BusinessPartnerFiscalTaxIDCollection
    {
        public BusinessPartnerFiscalTaxIDCollection()
        {
            
        }
        
        public BusinessPartnerFiscalTaxIDCollection(string taxId0, string taxId4, string bPCode)
        {
            TaxId0 = taxId0;
            TaxId4 = taxId4;
            BPCode = bPCode;
        }

        public string TaxId0 { get; set; } = string.Empty;
        public string TaxId4 { get; set; } = string.Empty;       
        public string BPCode { get; set; } = string.Empty;
    }
}