

namespace Domain.Entities.SAPEntities
{
    public class BusinessPartnerAddress
    {
        public BusinessPartnerAddress()
        {
            
        }
        
        public BusinessPartnerAddress(string addressName, string street, string block, string zipCode, string city, string state, string streetNo)
        {
            AddressName = addressName;
            Street = street;
            Block = block;
            ZipCode = zipCode;
            City = city;
            State = state;
            StreetNo = streetNo;
        }

        public string AddressName { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Block { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;        
        public string State { get; set; } = string.Empty;       
        public string StreetNo { get; set; } = string.Empty;  
    }
}