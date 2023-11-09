using Domain;
using MediatR;
using Persistence;

namespace Application.Providers
{
    public class Create
    {
        public class Command : IRequest
        {
            public Provider Provider { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }
            public Task Handle(Command request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}