

using Domain.DTO.SAPDTO;
using Domain.Entities.SAPEntities;
using MediatR;

namespace Application.Commands.CommandsSAP
{
    public class InsertBusinessPartnerCommand : IRequest<BusinessPartnerDTO>
    {
        public string CardName { get; set; } = string.Empty;
        public string CardType { get; set; } = string.Empty;
        public int GroupCode { get; set; }
        public string Phone1 { get; set; } = string.Empty;    
        public string EmailAddress { get; set; } = string.Empty;         
        public int Series { get; set; }
        public List<BusinessPartnerFiscalTaxIDCollection>? BPFiscalTaxIDCollection { get; set; }      
        public List<BusinessPartnerAddress>? BPAddresses { get; set; }
    }
}