

using AutoMapper;
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
            private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var provider = await _context.Providers.FindAsync(request.Provider.Id);

                _mapper.Map(request.Provider, provider);

                await _context.SaveChangesAsync();
            }
        }
    }
}