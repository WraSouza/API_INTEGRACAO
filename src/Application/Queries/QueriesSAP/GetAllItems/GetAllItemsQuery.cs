using Domain.DTO.SAPDTO;
using MediatR;

namespace Application.Queries.QueriesSAP.GetAllItems
{
    public class GetAllItemsQuery : IRequest<ItemSAPDTO>
    {
        public GetAllItemsQuery(int skipValue)
        {
            SkipValue = skipValue;
        }

        public ItemSAPDTO? Value { get; set; }
         public int SkipValue { get; private set; }
    }
}