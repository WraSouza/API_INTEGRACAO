
using Domain.Entities.MagentoEntities;

namespace Domain.DTO.MagentoDTO
{
    public class RootMagentoDTO
    {
        public List<SalesDTO> items { get; set; } = [];
        public SearchCriteria? search_criteria { get; set; }
        public int total_count { get; set; }
    }
}