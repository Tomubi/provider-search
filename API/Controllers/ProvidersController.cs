using Application.Providers;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProvidersController : BaseApiController
    {
        [HttpGet] //api/providers
        public async Task<ActionResult<List<Provider>>> GetProviders()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpGet("{id}")] //api/providers/fsfsfs
        public async Task<ActionResult<Provider>> GetProviders(Guid id)
        {
            return await Mediator.Send(new Details.Query { Id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateProvider(Provider provider)
        {
            await Mediator.Send(new Create.Command { Provider = provider });

            return Ok();
        }
    }
}