using Domain.DTO.SAPDTO;
using Domain.Repositories.SAPRepositories;
using MediatR;

namespace Application.Queries.QueriesSAP.GetAllItems
{
    public class GetAllItemsQueryHandler(IItemRepository repository) : IRequestHandler<GetAllItemsQuery, ItemSAPDTO>
    {
        public Task<ItemSAPDTO> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            return repository.GetAllItemsAsync(request.SkipValue.ToString());
        }
    }
}