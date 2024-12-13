

using Application.Queries.QueriesSAP.GetAllItems;
using Domain.DTO.SAPDTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers.ControllersSAP
{
    public static class ItemsController
    {
         public static RouteGroupBuilder ItemsEndpoint(this RouteGroupBuilder app)
         {
            app.MapPost("/items/", async (IMediator mediator,[FromBody]SkipDTO skipDTO) =>
            {
                var items = new GetAllItemsQuery(skipDTO.Skip);

                var allItems = await mediator.Send(items);

                return Results.Ok(allItems);
            });

            return app;
         }
    }
}