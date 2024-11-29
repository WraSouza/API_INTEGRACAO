using Application.Commands.CommandsSAP;
using MediatR;

namespace WebAPI.Controllers.ControllersSAP
{
    public static class BusinessPartnerController
    {
         public static RouteGroupBuilder BusinessPartnerEndpoint(this RouteGroupBuilder app)
         {
          /*
            app.MapGet("/businesspartner", async (IMediator mediator) =>
            {
                

            }).Produces<InsertBusinessPartnerCommand>(statusCode: StatusCodes.Status200OK)
              .Produces<InsertBusinessPartnerCommand>(statusCode: StatusCodes.Status400BadRequest)
              .WithName("Get-BusinessPartner-SAP")
              .WithOpenApi();
              */

            return app;
         }
    }
}