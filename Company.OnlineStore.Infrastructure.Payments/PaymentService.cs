using System.Threading.Tasks;
using Company.OnlineStore.Domain;
using Microsoft.Extensions.Logging;

namespace Company.OnlineStore.Infrastructure.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly ILogger<PaymentService> _logger;

        public PaymentService(ILogger<PaymentService> logger)
        {
            _logger = logger;
        }

        public Task<Receipt> Charge(Domain.Order.Order order)
        {
            _logger.LogInformation($"Payment received for order id: {order.Id}");

            return Task.FromResult(new Receipt());
        }
    }
}