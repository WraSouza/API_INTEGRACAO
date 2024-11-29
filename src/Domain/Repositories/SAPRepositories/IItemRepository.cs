
using Domain.DTO.SAPDTO;

namespace Domain.Repositories.SAPRepositories
{
    public interface IItemRepository
    {
       Task<ItemSAPDTO> GetAllItemsAsync();
    }
}