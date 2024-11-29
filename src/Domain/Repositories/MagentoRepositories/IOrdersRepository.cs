

using Domain.DTO.MagentoDTO;
using Domain.Entities.MagentoEntities;

namespace Domain.Repositories.MagentoRepositories
{
    public interface IOrdersRepository
    {
         Task<List<SalesDTO>> GetAllOrdersAsync();
    }
}