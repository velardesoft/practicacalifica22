using pc27429u20211c221.Shared.Domain.Model.Events;
using Cortex.Mediator.Notifications;

namespace pc27429u20211c221.Shared.Application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
    
}