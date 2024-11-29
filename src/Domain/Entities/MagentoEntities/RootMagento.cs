

namespace Domain.Entities.MagentoEntities
{
    public class RootMagento
    {
        public List<Sales> items { get; set; } = [];
        public SearchCriteria? search_criteria { get; set; }
        public int total_count { get; set; }
    }
}