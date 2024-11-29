

using Domain.DTO.MagentoDTO;
using Domain.Entities.MagentoEntities;
using Domain.Repositories.MagentoRepositories;
using MediatR;

namespace Application.Queries.QueriesMagento.GetAllSales
{
    public class GetAllSalesQueryHandler(IOrdersRepository ordersRepository) : IRequestHandler<GetAllSalesQuery, List<SalesDTO>>
    {
        public async Task<List<SalesDTO>> Handle(GetAllSalesQuery request, CancellationToken cancellationToken)
        {
            return await ordersRepository.GetAllOrdersAsync();
        }
    }
}