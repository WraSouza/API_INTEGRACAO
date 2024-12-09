using Domain.DTO.SAPDTO;
using MediatR;

namespace Application.Commands.CommandsSAP
{
    public class InsertBusinessPartnerCommandHandler : IRequestHandler<InsertBusinessPartnerCommand, BusinessPartnerDTO>
    {
        public Task<BusinessPartnerDTO> Handle(InsertBusinessPartnerCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}