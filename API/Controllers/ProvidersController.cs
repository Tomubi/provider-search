using Application.Providers;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProvidersController : BaseApiController
    {
        [HttpGet] //api/provider
        public async Task<ActionResult<List<Provider>>> GetPhysicians()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/providers/fsfsfs
        public async Task<ActionResult<Provider>> GetPhysician(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }
    }
}