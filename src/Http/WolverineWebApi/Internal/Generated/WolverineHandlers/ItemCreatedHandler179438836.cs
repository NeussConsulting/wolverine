// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: ItemCreatedHandler179438836
    public class ItemCreatedHandler179438836 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            // The actual message body
            var itemCreated = (WolverineWebApi.ItemCreated)context.Envelope.Message;

            var itemCreatedHandler = new WolverineWebApi.ItemCreatedHandler();
            
            // The actual message execution
            itemCreatedHandler.Handle(itemCreated);

            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: ItemCreatedHandler179438836
    
    
}

