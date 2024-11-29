using Domain.DTO.SAPDTO;
using MediatR;

namespace Application.Queries.QueriesSAP.GetAllItems
{
    public class GetAllItemsQuery : IRequest<ItemSAPDTO>
    {
         public ItemSAPDTO? Value { get; set; }
    }
}