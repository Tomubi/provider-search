using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Providers
{
    public class List
    {
        public class Query : IRequest<List<Provider>> { }
        public class Handler : IRequestHandler<Query, List<Provider>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;

            }
            public async Task<List<Provider>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Providers.ToListAsync();
            }
        }

    }
}