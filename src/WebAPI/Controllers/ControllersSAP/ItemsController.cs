

using Application.Queries.QueriesSAP.GetAllItems;
using MediatR;

namespace WebAPI.Controllers.ControllersSAP
{
    public static class ItemsController
    {
         public static RouteGroupBuilder ItemsEndpoint(this RouteGroupBuilder app)
         {
            app.MapGet("/items", async (IMediator mediator) =>
            {
                var items = new GetAllItemsQuery();

                var allItems = await mediator.Send(items);

                return Results.Ok(allItems);
            });

            return app;
         }
    }
}