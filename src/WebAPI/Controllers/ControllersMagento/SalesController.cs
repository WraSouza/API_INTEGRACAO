

using Application.Queries.QueriesMagento.GetAllSales;
using MediatR;

namespace WebAPI.Controllers.ControllersMagento
{
    public static class SalesController
    {
        public static RouteGroupBuilder SalesEndpoint(this RouteGroupBuilder app)
        {
             app.MapGet("/sales", async (IMediator mediator) =>
            {
                var orders = new GetAllSalesQuery();

                var allOrders = await mediator.Send(orders);

                return Results.Ok(allOrders);
            });
            return app;
        }
    }
}