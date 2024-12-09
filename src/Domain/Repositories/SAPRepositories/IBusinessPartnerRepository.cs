

using Domain.DTO.SAPDTO;
using Domain.Entities.SAPEntities;

namespace Domain.Repositories.SAPRepositories
{
    public interface IBusinessPartnerRepository
    {
        Task<BusinessPartner> CreateBusinessPartnerAsync(BusinessPartner businessPartner);
        Task<BusinessPartnerDTO> GetAllBusinessPartnerAsync();
        Task<bool> VerifyIfBusinessPartnerExistsAsync(string cpf);
    }
}