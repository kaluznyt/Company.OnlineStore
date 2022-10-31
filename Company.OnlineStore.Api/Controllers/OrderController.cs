using System;
using System.Threading.Tasks;
using Company.OnlineStore.Application.Order.PlaceOrder;
using Microsoft.AspNetCore.Mvc;

namespace Company.OnlineStore.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        [HttpPost("place")]
        public async Task<IActionResult> PlaceOrder([FromServices] PlaceOrderUseCase placeOrderUseCase, [FromQuery] Guid basketId)
        {
            var result = await placeOrderUseCase.Execute(basketId);

            return Ok(result);
        }
    }
}
