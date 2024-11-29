using Domain.DTO.MagentoDTO;
using MediatR;

namespace Application.Queries.QueriesMagento.GetAllSales
{
    public class GetAllSalesQuery : IRequest<List<SalesDTO>>
    {
        
    }
}