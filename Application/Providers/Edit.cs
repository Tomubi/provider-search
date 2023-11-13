

using Domain;
using MediatR;
using Persistence;

namespace Application.Providers
{
    public class Edit
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
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var Provider = await _context.Providers.FindAsync(request.Provider.Id);

                Provider.Name = request.Provider.Name ?? Provider.Name;

                await _context.SaveChangesAsync();
            }
        }
    }
}