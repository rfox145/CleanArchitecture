using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
   public sealed class InMemoryBus : IMediator
    {
        private readonly IMediator mediator;

        public InMemoryBus(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task Publish(object notification, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task Publish<TNotification>(TNotification notification, CancellationToken cancellationToken = default) where TNotification : INotification
        {
            throw new NotImplementedException();
        }

        public Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<object> Send(object request, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
