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

        [HttpPut("{id}")]
        public async Task<IActionResult> EditProvider(Guid id, Provider provider)
        {
            provider.Id = id;

            await Mediator.Send(new Edit.Command { Provider = provider });

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProvider(Guid id)
        {
            await Mediator.Send(new Delete.Command { Id = id });

            return Ok();
        }
    }
}