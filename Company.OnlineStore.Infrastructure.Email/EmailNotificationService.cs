using System;
using System.Threading.Tasks;
using Company.OnlineStore.Domain;
using Microsoft.Extensions.Logging;

namespace Company.OnlineStore.Infrastructure.Email
{
    public class EmailNotificationService : INotificationService
    {
        private readonly ILogger<EmailNotificationService> _logger;

        public EmailNotificationService(ILogger<EmailNotificationService> logger)
        {
            _logger = logger;
        }
        public Task NotifyCustomer(Guid customerId, Receipt receipt)
        {
            _logger.LogInformation($"Sending receipt to customer: {customerId}");
            return Task.CompletedTask;
        }
    }
}