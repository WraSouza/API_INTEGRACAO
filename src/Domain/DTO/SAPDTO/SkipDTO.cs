

namespace Domain.DTO.SAPDTO
{
    public class SkipDTO
    {
        public SkipDTO(int skip)
        {
            Skip = skip;
        }

        public int Skip { get; private set; }
    }
}