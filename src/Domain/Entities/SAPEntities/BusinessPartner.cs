

namespace Domain.Entities.SAPEntities
{
    public class BusinessPartner
    {
        public BusinessPartner()
        {
            
        }
        
        public BusinessPartner(string cardName, string cardCode, string phone1, string emailAddress, List<BusinessPartnerFiscalTaxIDCollection>? bPFiscalTaxIDCollection, List<BusinessPartnerAddress>? bPAddresses)
        {
            CardName = cardName;
            CardCode = cardCode;
            CardType = "cCustomer";
            GroupCode = 109;
            Phone1 = phone1;
            EmailAddress = emailAddress;
            Series = 74;
            BPFiscalTaxIDCollection = bPFiscalTaxIDCollection;
            BPAddresses = bPAddresses;
        }

        public string CardName { get; set; } = string.Empty;
        public string CardCode { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public int GroupCode { get; set; }
        public string Phone1 { get; set; } = string.Empty;    
        public string EmailAddress { get; set; } = string.Empty;         
        public int Series { get; set; }
        public List<BusinessPartnerFiscalTaxIDCollection>? BPFiscalTaxIDCollection { get; set; }      
        public List<BusinessPartnerAddress>? BPAddresses { get; set; }
    }
}