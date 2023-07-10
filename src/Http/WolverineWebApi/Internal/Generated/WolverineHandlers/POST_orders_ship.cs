// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;
using Wolverine.Marten.Publishing;
using Wolverine.Runtime;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_orders_ship
    public class POST_orders_ship : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public POST_orders_ship(Wolverine.Http.WolverineHttpOptions options, Wolverine.Runtime.IWolverineRuntime wolverineRuntime, Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory) : base(options)
        {
            _options = options;
            _wolverineRuntime = wolverineRuntime;
            _outboxedSessionFactory = outboxedSessionFactory;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            var (command, jsonContinue) = await ReadJsonAsync<WolverineWebApi.Marten.ShipOrder>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            await using var documentSession = _outboxedSessionFactory.OpenSession(messageContext);
            var eventStore = documentSession.Events;
            
            // Loading Marten aggregate
            var eventStream = await eventStore.FetchForWriting<WolverineWebApi.Marten.Order>(command.OrderId, httpContext.RequestAborted).ConfigureAwait(false);

            var orderShipped = WolverineWebApi.Marten.MarkItemEndpoint.Ship(command, eventStream.Aggregate);
            eventStream.AppendOne(orderShipped);
            await documentSession.SaveChangesAsync(httpContext.RequestAborted).ConfigureAwait(false);
            // Wolverine automatically sets the status code to 204 for empty responses
            httpContext.Response.StatusCode = 204;
        }

    }

    // END: POST_orders_ship
    
    
}

