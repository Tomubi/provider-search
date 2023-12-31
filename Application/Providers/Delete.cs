using MediatR;
using Persistence;

namespace Application.Providers
{
    public class Delete
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var provider = await _context.Providers.FindAsync(request.Id);

                _context.Remove(provider);

                await _context.SaveChangesAsync();
            }
        }
    }
}