﻿using Evently.Common.Domain;
using Evently.Common.Presentation.ApiResults;
using Evently.Common.Presentation.Endpoints;
using Evently.Modules.Ticketing.Application.Abstractions.Authentication;
using Evently.Modules.Ticketing.Application.Carts.RemoveItemFromCart;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Ticketing.Presentation.Carts;
public class RemoveFromCart : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapPut("cart/remove", async (Request request, ICustomerContext customerContext, ISender sender) =>
        {
            Result result = await sender.Send(new RemoveItemFromCartCommand(
                customerContext.CustomerId,
                request.TicketTypeId,
                request.Quantity));

            return result.Match(() => Results.Ok(), ApiResults.Problem);
        })
        .RequireAuthorization(Permissions.RemoveFromCart)
        .WithTags(Tags.Carts);
    }

    internal sealed class Request
    {
        public Guid TicketTypeId { get; init; }

        public decimal Quantity { get; init; }
    }
}
