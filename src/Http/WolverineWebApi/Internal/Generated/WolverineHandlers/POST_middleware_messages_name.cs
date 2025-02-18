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
    // START: POST_middleware_messages_name
    public class POST_middleware_messages_name : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _wolverineHttpOptions;
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;
        private readonly Wolverine.Runtime.IWolverineRuntime _wolverineRuntime;

        public POST_middleware_messages_name(Wolverine.Http.WolverineHttpOptions wolverineHttpOptions, Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory, Wolverine.Runtime.IWolverineRuntime wolverineRuntime) : base(wolverineHttpOptions)
        {
            _wolverineHttpOptions = wolverineHttpOptions;
            _outboxedSessionFactory = outboxedSessionFactory;
            _wolverineRuntime = wolverineRuntime;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var messageContext = new Wolverine.Runtime.MessageContext(_wolverineRuntime);
            // Building the Marten session
            await using var documentSession = _outboxedSessionFactory.OpenSession(messageContext);
            Wolverine.Http.Runtime.RequestIdMiddleware.Apply(httpContext, messageContext);
            var name = (string)httpContext.GetRouteValue("name");
            var outgoingMessages101 = WolverineWebApi.CascadingEndpoint.Before(name);
            
            // Outgoing, cascaded message
            await messageContext.EnqueueCascadingAsync(outgoingMessages101).ConfigureAwait(false);

            
            // The actual HTTP request handler execution
            var result_of_Post = WolverineWebApi.CascadingEndpoint.Post(name, documentSession);

            await WolverineWebApi.CascadingEndpoint.After(messageContext, name).ConfigureAwait(false);
            
            // Save all pending changes to this Marten session
            await documentSession.SaveChangesAsync(httpContext.RequestAborted).ConfigureAwait(false);

            await WriteString(httpContext, result_of_Post);
            
            // Have to flush outgoing messages just in case Marten did nothing because of https://github.com/JasperFx/wolverine/issues/536
            await messageContext.FlushOutgoingMessagesAsync().ConfigureAwait(false);

        }

    }

    // END: POST_middleware_messages_name
    
    
}

