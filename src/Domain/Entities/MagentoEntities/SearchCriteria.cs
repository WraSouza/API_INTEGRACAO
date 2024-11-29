

namespace Domain.Entities.MagentoEntities
{
    public class SearchCriteria
    {
        public List<object>? filter_groups { get; set; }
        public int current_page { get; set; }
    }
}